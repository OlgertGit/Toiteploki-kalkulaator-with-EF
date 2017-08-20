namespace ToiteplokkKalkulaator
{
partial class InfoForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
        this.lbl_Version = new System.Windows.Forms.Label();
        this.btn_Exit = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.label2 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        //
        // lbl_Version
        //
        this.lbl_Version.AutoSize = true;
        this.lbl_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
        this.lbl_Version.Location = new System.Drawing.Point(58, 34);
        this.lbl_Version.Name = "lbl_Version";
        this.lbl_Version.Size = new System.Drawing.Size(287, 25);
        this.lbl_Version.TabIndex = 0;
        this.lbl_Version.Text = "Programmi versioon on: 1.00";
        //
        // btn_Exit
        //
        this.btn_Exit.Location = new System.Drawing.Point(309, 325);
        this.btn_Exit.Name = "btn_Exit";
        this.btn_Exit.Size = new System.Drawing.Size(75, 23);
        this.btn_Exit.TabIndex = 1;
        this.btn_Exit.Text = "Välju";
        this.btn_Exit.UseVisualStyleBackColor = true;
        this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
        //
        // label1
        //
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
        this.label1.Location = new System.Drawing.Point(87, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(216, 25);
        this.label1.TabIndex = 2;
        this.label1.Text = "Toiteploki kalkulaator";
        //
        // pictureBox1
        //
        this.pictureBox1.Image = global::ToiteplokkKalkulaator.Properties.Resources.psu;
        this.pictureBox1.Location = new System.Drawing.Point(45, 90);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(300, 199);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.pictureBox1.TabIndex = 3;
        this.pictureBox1.TabStop = false;
        //
        // label2
        //
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label2.Location = new System.Drawing.Point(42, 325);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(146, 16);
        this.label2.TabIndex = 4;
        this.label2.Text = "2017 © Olgert Mihhaljov";
        //
        // InfoForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(396, 360);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.btn_Exit);
        this.Controls.Add(this.lbl_Version);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MinimumSize = new System.Drawing.Size(333, 301);
        this.Name = "InfoForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Info";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_Version;
    private System.Windows.Forms.Button btn_Exit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label2;
}
}