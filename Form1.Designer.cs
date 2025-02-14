namespace Colourie;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        hsvLabel = new Label();
        deco_hsv = new Panel();
        hsv_copy = new Button();
        deco_rgb = new Panel();
        rgb_copy = new Button();
        rgbLabel = new Label();
        deco_hex = new Panel();
        hex_copy = new Button();
        hexLabel = new Label();
        button_pick = new Button();
        color_display = new Panel();
        deco_hsv.SuspendLayout();
        deco_rgb.SuspendLayout();
        deco_hex.SuspendLayout();
        SuspendLayout();
        // 
        // hsvLabel
        // 
        hsvLabel.BackColor = Color.Transparent;
        hsvLabel.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        hsvLabel.Location = new Point(0, 0);
        hsvLabel.Name = "hsvLabel";
        hsvLabel.Size = new Size(259, 40);
        hsvLabel.TabIndex = 1;
        hsvLabel.Text = "HSV";
        hsvLabel.TextAlign = ContentAlignment.MiddleCenter;
        hsvLabel.Visible = false;
        // 
        // deco_hsv
        // 
        deco_hsv.BackColor = SystemColors.ButtonFace;
        deco_hsv.Controls.Add(hsv_copy);
        deco_hsv.Controls.Add(hsvLabel);
        deco_hsv.Location = new Point(0, 30);
        deco_hsv.Name = "deco_hsv";
        deco_hsv.Size = new Size(320, 40);
        deco_hsv.TabIndex = 2;
        deco_hsv.Visible = false;
        // 
        // hsv_copy
        // 
        hsv_copy.BackColor = Color.Transparent;
        hsv_copy.BackgroundImageLayout = ImageLayout.Stretch;
        hsv_copy.FlatAppearance.BorderSize = 0;
        hsv_copy.FlatStyle = FlatStyle.Flat;
        hsv_copy.Location = new Point(265, 5);
        hsv_copy.Name = "hsv_copy";
        hsv_copy.Size = new Size(30, 30);
        hsv_copy.TabIndex = 6;
        hsv_copy.UseVisualStyleBackColor = false;
        hsv_copy.Click += hsv_copy_Click;
        // 
        // deco_rgb
        // 
        deco_rgb.BackColor = SystemColors.ButtonFace;
        deco_rgb.Controls.Add(rgb_copy);
        deco_rgb.Controls.Add(rgbLabel);
        deco_rgb.Location = new Point(0, 80);
        deco_rgb.Name = "deco_rgb";
        deco_rgb.Size = new Size(320, 40);
        deco_rgb.TabIndex = 3;
        deco_rgb.Visible = false;
        // 
        // rgb_copy
        // 
        rgb_copy.BackColor = Color.Transparent;
        rgb_copy.BackgroundImageLayout = ImageLayout.Stretch;
        rgb_copy.FlatAppearance.BorderSize = 0;
        rgb_copy.FlatStyle = FlatStyle.Flat;
        rgb_copy.Location = new Point(265, 5);
        rgb_copy.Name = "rgb_copy";
        rgb_copy.Size = new Size(30, 30);
        rgb_copy.TabIndex = 7;
        rgb_copy.UseVisualStyleBackColor = false;
        rgb_copy.Click += rgb_copy_Click;
        // 
        // rgbLabel
        // 
        rgbLabel.BackColor = Color.Transparent;
        rgbLabel.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        rgbLabel.Location = new Point(0, 0);
        rgbLabel.Name = "rgbLabel";
        rgbLabel.Size = new Size(259, 40);
        rgbLabel.TabIndex = 5;
        rgbLabel.Text = "RGB";
        rgbLabel.TextAlign = ContentAlignment.MiddleCenter;
        rgbLabel.Visible = false;
        // 
        // deco_hex
        // 
        deco_hex.BackColor = SystemColors.ButtonFace;
        deco_hex.Controls.Add(hex_copy);
        deco_hex.Controls.Add(hexLabel);
        deco_hex.Location = new Point(0, 130);
        deco_hex.Name = "deco_hex";
        deco_hex.Size = new Size(320, 40);
        deco_hex.TabIndex = 4;
        deco_hex.Visible = false;
        // 
        // hex_copy
        // 
        hex_copy.BackColor = Color.Transparent;
        hex_copy.BackgroundImageLayout = ImageLayout.Stretch;
        hex_copy.FlatAppearance.BorderSize = 0;
        hex_copy.FlatStyle = FlatStyle.Flat;
        hex_copy.Location = new Point(265, 5);
        hex_copy.Name = "hex_copy";
        hex_copy.Size = new Size(30, 30);
        hex_copy.TabIndex = 8;
        hex_copy.UseVisualStyleBackColor = false;
        hex_copy.Click += hex_copy_Click;
        // 
        // hexLabel
        // 
        hexLabel.BackColor = Color.Transparent;
        hexLabel.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        hexLabel.Location = new Point(0, 0);
        hexLabel.Name = "hexLabel";
        hexLabel.Size = new Size(259, 40);
        hexLabel.TabIndex = 6;
        hexLabel.Text = "HEX";
        hexLabel.TextAlign = ContentAlignment.MiddleCenter;
        hexLabel.Visible = false;
        // 
        // button_pick
        // 
        button_pick.BackColor = SystemColors.ButtonFace;
        button_pick.FlatAppearance.BorderSize = 0;
        button_pick.FlatStyle = FlatStyle.Flat;
        button_pick.Location = new Point(115, 185);
        button_pick.Name = "button_pick";
        button_pick.Size = new Size(180, 40);
        button_pick.TabIndex = 5;
        button_pick.Text = "Activate Picker (E)";
        button_pick.UseVisualStyleBackColor = false;
        button_pick.Click += button_pick_Click;
        // 
        // color_display
        // 
        color_display.Location = new Point(7, 185);
        color_display.Name = "color_display";
        color_display.Size = new Size(102, 40);
        color_display.TabIndex = 6;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(230, 230, 230);
        ClientSize = new Size(302, 233);
        Controls.Add(color_display);
        Controls.Add(button_pick);
        Controls.Add(deco_hex);
        Controls.Add(deco_rgb);
        Controls.Add(deco_hsv);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Location = new Point(19, 19);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        Padding = new Padding(0, 40, 0, 0);
        Text = "Colourie";
        Activated += Form1_Activated;
        Deactivate += Form1_Deactivate;
        deco_hsv.ResumeLayout(false);
        deco_rgb.ResumeLayout(false);
        deco_hex.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button hsv_copy;
    private System.Windows.Forms.Button hex_copy;

    private System.Windows.Forms.Button rgb_copy;

    private System.Windows.Forms.Label hexLabel;

    private System.Windows.Forms.Label rgbLabel;

    private System.Windows.Forms.Panel deco_hsv;

    private System.Windows.Forms.Panel deco_hex;

    private System.Windows.Forms.Panel deco_rgb;

    private System.Windows.Forms.Label hsvLabel;

    #endregion

    private Button button_pick;
    private Panel color_display;
}