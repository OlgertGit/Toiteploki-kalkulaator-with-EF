namespace ToiteplokkKalkulaator
{
partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
        this.tb_Login = new System.Windows.Forms.TextBox();
        this.tb_Password = new System.Windows.Forms.TextBox();
        this.btn_Vajuta = new System.Windows.Forms.Button();
        this.lbl_Login = new System.Windows.Forms.Label();
        this.lbl_Password = new System.Windows.Forms.Label();
        this.lbl_Access = new System.Windows.Forms.Label();
        this.btn_Tagasi = new System.Windows.Forms.Button();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        //
        // tb_Login
        //
        this.tb_Login.Location = new System.Drawing.Point(66, 43);
        this.tb_Login.Name = "tb_Login";
        this.tb_Login.Size = new System.Drawing.Size(366, 20);
        this.tb_Login.TabIndex = 0;
        //
        // tb_Password
        //
        this.tb_Password.Location = new System.Drawing.Point(66, 80);
        this.tb_Password.Name = "tb_Password";
        this.tb_Password.PasswordChar = '*';
        this.tb_Password.Size = new System.Drawing.Size(366, 20);
        this.tb_Password.TabIndex = 1;
        //
        // btn_Vajuta
        //
        this.btn_Vajuta.Location = new System.Drawing.Point(276, 117);
        this.btn_Vajuta.Name = "btn_Vajuta";
        this.btn_Vajuta.Size = new System.Drawing.Size(75, 23);
        this.btn_Vajuta.TabIndex = 2;
        this.btn_Vajuta.Text = "Logi sisse";
        this.btn_Vajuta.UseVisualStyleBackColor = true;
        this.btn_Vajuta.Click += new System.EventHandler(this.btn_Vajuta_Click);
        //
        // lbl_Login
        //
        this.lbl_Login.AutoSize = true;
        this.lbl_Login.Location = new System.Drawing.Point(12, 46);
        this.lbl_Login.Name = "lbl_Login";
        this.lbl_Login.Size = new System.Drawing.Size(33, 13);
        this.lbl_Login.TabIndex = 3;
        this.lbl_Login.Text = "Login";
        //
        // lbl_Password
        //
        this.lbl_Password.AutoSize = true;
        this.lbl_Password.Location = new System.Drawing.Point(12, 83);
        this.lbl_Password.Name = "lbl_Password";
        this.lbl_Password.Size = new System.Drawing.Size(37, 13);
        this.lbl_Password.TabIndex = 4;
        this.lbl_Password.Text = "Parool";
        //
        // lbl_Access
        //
        this.lbl_Access.AutoSize = true;
        this.lbl_Access.ForeColor = System.Drawing.Color.Black;
        this.lbl_Access.Location = new System.Drawing.Point(12, 9);
        this.lbl_Access.Name = "lbl_Access";
        this.lbl_Access.Size = new System.Drawing.Size(171, 13);
        this.lbl_Access.TabIndex = 5;
        this.lbl_Access.Text = "Sisestage palun kasutaja ja parool!";
        //
        // btn_Tagasi
        //
        this.btn_Tagasi.Location = new System.Drawing.Point(357, 117);
        this.btn_Tagasi.Name = "btn_Tagasi";
        this.btn_Tagasi.Size = new System.Drawing.Size(75, 23);
        this.btn_Tagasi.TabIndex = 6;
        this.btn_Tagasi.Text = "Tagasi";
        this.btn_Tagasi.UseVisualStyleBackColor = true;
        this.btn_Tagasi.Click += new System.EventHandler(this.btn_Tagasi_Click);
        //
        // pictureBox1
        //
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(438, 12);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(171, 125);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 7;
        this.pictureBox1.TabStop = false;
        //
        // LoginForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(621, 149);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.btn_Tagasi);
        this.Controls.Add(this.lbl_Access);
        this.Controls.Add(this.lbl_Password);
        this.Controls.Add(this.lbl_Login);
        this.Controls.Add(this.btn_Vajuta);
        this.Controls.Add(this.tb_Password);
        this.Controls.Add(this.tb_Login);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MinimumSize = new System.Drawing.Size(637, 188);
        this.Name = "LoginForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Sisselogimine";
        this.Load += new System.EventHandler(this.LoginForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tb_Login;
    private System.Windows.Forms.TextBox tb_Password;
    private System.Windows.Forms.Button btn_Vajuta;
    private System.Windows.Forms.Label lbl_Login;
    private System.Windows.Forms.Label lbl_Password;
    private System.Windows.Forms.Label lbl_Access;
    private System.Windows.Forms.Button btn_Tagasi;
    private System.Windows.Forms.PictureBox pictureBox1;
}
}