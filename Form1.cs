using Microsoft.Win32;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Colourie;

public partial class Form1 : Form
{
    private bool _isPicking;
    private bool picked;
    private Color defDisplayColor;

    private const int WmHotkey = 0x0312;
    [DllImport("dwmapi.dll")] private static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);
    [DllImport("user32.dll")] private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, int vk);
    [DllImport("user32.dll")] private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    protected override void WndProc(ref Message m) { if (m.Msg == WmHotkey) { doPicking(); } base.WndProc(ref m); }
    private void EnableRoundedCorners() { if (Environment.OSVersion.Platform == PlatformID.Win32NT) { int dwmwaWindowCornerPreference = 33; int dwmncrpRound = 2; DwmSetWindowAttribute(this.Handle, dwmwaWindowCornerPreference, ref dwmncrpRound, sizeof(int)); } }

    private string ColorToHex(Color color) => $"#{color.R:X2}{color.G:X2}{color.B:X2}";
    private string ColorToHsv(Color color) { double r = color.R / 255.0; double g = color.G / 255.0; double b = color.B / 255.0; double max = Math.Max(r, Math.Max(g, b)); double min = Math.Min(r, Math.Min(g, b)); double delta = max - min; double h = 0; if (delta > 0) { if (max == r) { h = 60 * (((g - b) / delta) % 6); } else if (max == g) h = 60 * (((b - r) / delta) + 2); else if (max == b) h = 60 * (((r - g) / delta) + 4); } if (h < 0) h += 360; double s = (max == 0) ? 0 : delta / max; double v = max; return Math.Round(h) + "\u00b0, " + Math.Round(s * 100) + "%, " + Math.Round(v * 100) + "%"; }
    private void PickScreenColor() { Point cursorPos = Cursor.Position; using (Bitmap screenPixel = new Bitmap(1, 1)) { using (Graphics g = Graphics.FromImage(screenPixel)) { g.CopyFromScreen(cursorPos, Point.Empty, new Size(1, 1)); } Color pickedColor = screenPixel.GetPixel(0, 0); UpdateInfo(pickedColor); } }
    private void UpdateInfo(Color color) { string rgb = color.R + ", " + color.G + ", " + color.B; string hex = ColorToHex(color); string hsv = ColorToHsv(color); rgbLabel.Text = rgb; hexLabel.Text = hex; hsvLabel.Text = hsv; color_display.BackColor = color; hexLabel.Visible = true; rgbLabel.Visible = true; hsvLabel.Visible = true; deco_hex.Visible = true; deco_hsv.Visible = true; deco_rgb.Visible = true; }
    private void doPicking() { if (_isPicking) { _isPicking = false; picked = true; PickScreenColor(); Activate(); button_pick.Text = "Pick again (E)"; } else { _isPicking = true; color_display.BackColor = defDisplayColor; picked = false; hexLabel.Visible = false; rgbLabel.Visible = false; hsvLabel.Visible = false; deco_hex.Visible = false; deco_hsv.Visible = false; deco_rgb.Visible = false; button_pick.Text = "Picking..."; } }

    private bool IsWindowsDarkMode() { const string registryKey = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"; using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(registryKey)) { if (key != null && key.GetValue("AppsUseLightTheme") is int value) { return value == 0; } } return false; }
    private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e) { if (e.Category == UserPreferenceCategory.General) { updateTheme(IsWindowsDarkMode()); } }
    private Color rgb(int r, int g, int b) => Color.FromArgb(r, g, b);
    private Image img(byte[] stream) => Image.FromStream(new MemoryStream(stream));
    private void updateTheme(bool d)
    {
        deco_hex.BackColor = d ? rgb(60, 60, 60) : rgb(240, 240, 240);
        deco_hsv.BackColor = d ? rgb(60, 60, 60) : rgb(240, 240, 240);
        deco_rgb.BackColor = d ? rgb(60, 60, 60) : rgb(240, 240, 240);
        BackColor = d ? rgb(0, 0, 0) : rgb(230, 230, 230);
        hex_copy.BackgroundImage = d ? img(Resource.icon_copydark) : img(Resource.icon_copylight);
        rgb_copy.BackgroundImage = d ? img(Resource.icon_copydark) : img(Resource.icon_copylight);
        hsv_copy.BackgroundImage = d ? img(Resource.icon_copydark) : img(Resource.icon_copylight);
        rgbLabel.ForeColor = d ? Color.White : Color.Black;
        hexLabel.ForeColor = d ? Color.White : Color.Black;
        hsvLabel.ForeColor = d ? Color.White : Color.Black;
        defDisplayColor = d ? rgb(20, 20, 20) : Color.White;
        if (!picked) { color_display.BackColor = defDisplayColor; }
        button_pick.BackColor = d ? rgb(60, 60, 60) : SystemColors.ButtonFace;
        button_pick.ForeColor = d ? Color.White : Color.Black;
    }

    public Form1()
    {
        InitializeComponent();
        Application.EnableVisualStyles();
        EnableRoundedCorners();
        updateTheme(IsWindowsDarkMode());
        SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
    }

    private void Form1_Activated(object sender, EventArgs e) { RegisterHotKey(Handle, 1, 0, Keys.E.GetHashCode()); }
    private void Form1_Deactivate(object sender, EventArgs e) { if (!_isPicking) { UnregisterHotKey(Handle, 1); } }
    private void hsv_copy_Click(object sender, EventArgs e) { if (picked) { Clipboard.SetText(hsvLabel.Text); } }
    private void rgb_copy_Click(object sender, EventArgs e) { if (picked) { Clipboard.SetText(rgbLabel.Text); } }
    private void hex_copy_Click(object sender, EventArgs e) { if (picked) { Clipboard.SetText(hexLabel.Text); } }
    private void button_pick_Click(object sender, EventArgs e) { if (!_isPicking) { doPicking(); } }
}