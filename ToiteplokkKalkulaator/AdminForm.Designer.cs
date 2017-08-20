namespace ToiteplokkKalkulaator
{
partial class AdminForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
        this.btn_Vajuta = new System.Windows.Forms.Button();
        this.cb_Andmed = new System.Windows.Forms.ComboBox();
        this.dgv_Andmebaas = new System.Windows.Forms.DataGridView();
        this.label1 = new System.Windows.Forms.Label();
        this.lbl_ValitudTabel = new System.Windows.Forms.Label();
        this.tb_ValitudTabel = new System.Windows.Forms.TextBox();
        this.btn_Sisesta = new System.Windows.Forms.Button();
        this.lbl_Id = new System.Windows.Forms.Label();
        this.tb_IdDelete = new System.Windows.Forms.TextBox();
        this.btn_Kustuta = new System.Windows.Forms.Button();
        this.btn_Tagasi = new System.Windows.Forms.Button();
        this.cb_Veerud = new System.Windows.Forms.ComboBox();
        this.lbl_Veerud = new System.Windows.Forms.Label();
        this.cb_Id = new System.Windows.Forms.ComboBox();
        this.label2 = new System.Windows.Forms.Label();
        this.tb_Muutmine = new System.Windows.Forms.TextBox();
        this.btn_Muuda = new System.Windows.Forms.Button();
        this.tb_VeergNimi = new System.Windows.Forms.TextBox();
        this.btn_LisaVeerg = new System.Windows.Forms.Button();
        this.cb_SqlMuutujad = new System.Windows.Forms.ComboBox();
        this.cb_KustutaVeerg = new System.Windows.Forms.ComboBox();
        this.btn_KustutaVeerg = new System.Windows.Forms.Button();
        this.lbl_Voimsus = new System.Windows.Forms.Label();
        this.lbl_Nimetus = new System.Windows.Forms.Label();
        this.tb_Voimsus = new System.Windows.Forms.TextBox();
        this.tb_Nimetus = new System.Windows.Forms.TextBox();
        this.lbl_VeeruNimi = new System.Windows.Forms.Label();
        this.lbl_ValiVeerg = new System.Windows.Forms.Label();
        this.gb_Kustutamine = new System.Windows.Forms.GroupBox();
        this.gb_Sisestamine = new System.Windows.Forms.GroupBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.dgv_Andmebaas)).BeginInit();
        this.gb_Kustutamine.SuspendLayout();
        this.gb_Sisestamine.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        //
        // btn_Vajuta
        //
        this.btn_Vajuta.Location = new System.Drawing.Point(692, 89);
        this.btn_Vajuta.Name = "btn_Vajuta";
        this.btn_Vajuta.Size = new System.Drawing.Size(75, 23);
        this.btn_Vajuta.TabIndex = 1;
        this.btn_Vajuta.Text = "Vajuta";
        this.btn_Vajuta.UseVisualStyleBackColor = true;
        this.btn_Vajuta.Click += new System.EventHandler(this.btn_Vajuta_Click);
        //
        // cb_Andmed
        //
        this.cb_Andmed.FormattingEnabled = true;
        this.cb_Andmed.Items.AddRange(new object[]
        {
            "Intel Protsessor",
            "AMD Protsessor",
            "Nvidia Videokaart",
            "AMD Videokaart",
            "Operatiivmälu",
            "Kõvakettas",
            "Optilised seadmed",
            "Toiteplokk Võimsus",
            "Kasutajad"
        });
        this.cb_Andmed.Location = new System.Drawing.Point(555, 91);
        this.cb_Andmed.Name = "cb_Andmed";
        this.cb_Andmed.Size = new System.Drawing.Size(121, 21);
        this.cb_Andmed.TabIndex = 2;
        //
        // dgv_Andmebaas
        //
        this.dgv_Andmebaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgv_Andmebaas.Location = new System.Drawing.Point(12, 131);
        this.dgv_Andmebaas.Name = "dgv_Andmebaas";
        this.dgv_Andmebaas.Size = new System.Drawing.Size(451, 465);
        this.dgv_Andmebaas.TabIndex = 3;
        //
        // label1
        //
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(493, 94);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(56, 13);
        this.label1.TabIndex = 4;
        this.label1.Text = "Vali tabel: ";
        //
        // lbl_ValitudTabel
        //
        this.lbl_ValitudTabel.AutoSize = true;
        this.lbl_ValitudTabel.Location = new System.Drawing.Point(22, 53);
        this.lbl_ValitudTabel.Name = "lbl_ValitudTabel";
        this.lbl_ValitudTabel.Size = new System.Drawing.Size(68, 13);
        this.lbl_ValitudTabel.TabIndex = 5;
        this.lbl_ValitudTabel.Text = "Valitud tabel:";
        //
        // tb_ValitudTabel
        //
        this.tb_ValitudTabel.Enabled = false;
        this.tb_ValitudTabel.Location = new System.Drawing.Point(96, 50);
        this.tb_ValitudTabel.Name = "tb_ValitudTabel";
        this.tb_ValitudTabel.Size = new System.Drawing.Size(166, 20);
        this.tb_ValitudTabel.TabIndex = 8;
        //
        // btn_Sisesta
        //
        this.btn_Sisesta.Enabled = false;
        this.btn_Sisesta.Location = new System.Drawing.Point(187, 95);
        this.btn_Sisesta.Name = "btn_Sisesta";
        this.btn_Sisesta.Size = new System.Drawing.Size(75, 23);
        this.btn_Sisesta.TabIndex = 11;
        this.btn_Sisesta.Text = "Sisesta";
        this.btn_Sisesta.UseVisualStyleBackColor = true;
        this.btn_Sisesta.Click += new System.EventHandler(this.btn_Sisesta_Click);
        //
        // lbl_Id
        //
        this.lbl_Id.AutoSize = true;
        this.lbl_Id.Location = new System.Drawing.Point(6, 45);
        this.lbl_Id.Name = "lbl_Id";
        this.lbl_Id.Size = new System.Drawing.Size(24, 13);
        this.lbl_Id.TabIndex = 12;
        this.lbl_Id.Text = "ID: ";
        //
        // tb_IdDelete
        //
        this.tb_IdDelete.Enabled = false;
        this.tb_IdDelete.Location = new System.Drawing.Point(36, 42);
        this.tb_IdDelete.Name = "tb_IdDelete";
        this.tb_IdDelete.Size = new System.Drawing.Size(100, 20);
        this.tb_IdDelete.TabIndex = 13;
        //
        // btn_Kustuta
        //
        this.btn_Kustuta.Enabled = false;
        this.btn_Kustuta.Location = new System.Drawing.Point(152, 40);
        this.btn_Kustuta.Name = "btn_Kustuta";
        this.btn_Kustuta.Size = new System.Drawing.Size(75, 23);
        this.btn_Kustuta.TabIndex = 14;
        this.btn_Kustuta.Text = "Kustuta";
        this.btn_Kustuta.UseVisualStyleBackColor = true;
        this.btn_Kustuta.Click += new System.EventHandler(this.btn_Kustuta_Click);
        //
        // btn_Tagasi
        //
        this.btn_Tagasi.Location = new System.Drawing.Point(692, 601);
        this.btn_Tagasi.Name = "btn_Tagasi";
        this.btn_Tagasi.Size = new System.Drawing.Size(75, 23);
        this.btn_Tagasi.TabIndex = 15;
        this.btn_Tagasi.Text = "Tagasi";
        this.btn_Tagasi.UseVisualStyleBackColor = true;
        this.btn_Tagasi.Click += new System.EventHandler(this.btn_Tagasi_Click);
        //
        // cb_Veerud
        //
        this.cb_Veerud.Enabled = false;
        this.cb_Veerud.FormattingEnabled = true;
        this.cb_Veerud.Location = new System.Drawing.Point(123, 109);
        this.cb_Veerud.Name = "cb_Veerud";
        this.cb_Veerud.Size = new System.Drawing.Size(139, 21);
        this.cb_Veerud.TabIndex = 16;
        //
        // lbl_Veerud
        //
        this.lbl_Veerud.AutoSize = true;
        this.lbl_Veerud.Location = new System.Drawing.Point(73, 116);
        this.lbl_Veerud.Name = "lbl_Veerud";
        this.lbl_Veerud.Size = new System.Drawing.Size(44, 13);
        this.lbl_Veerud.TabIndex = 17;
        this.lbl_Veerud.Text = "Veerud:";
        //
        // cb_Id
        //
        this.cb_Id.Enabled = false;
        this.cb_Id.FormattingEnabled = true;
        this.cb_Id.Location = new System.Drawing.Point(123, 79);
        this.cb_Id.Name = "cb_Id";
        this.cb_Id.Size = new System.Drawing.Size(139, 21);
        this.cb_Id.TabIndex = 18;
        //
        // label2
        //
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(93, 84);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(24, 13);
        this.label2.TabIndex = 19;
        this.label2.Text = "ID: ";
        //
        // tb_Muutmine
        //
        this.tb_Muutmine.Enabled = false;
        this.tb_Muutmine.Location = new System.Drawing.Point(123, 139);
        this.tb_Muutmine.Name = "tb_Muutmine";
        this.tb_Muutmine.Size = new System.Drawing.Size(139, 20);
        this.tb_Muutmine.TabIndex = 20;
        //
        // btn_Muuda
        //
        this.btn_Muuda.Enabled = false;
        this.btn_Muuda.Location = new System.Drawing.Point(187, 165);
        this.btn_Muuda.Name = "btn_Muuda";
        this.btn_Muuda.Size = new System.Drawing.Size(75, 23);
        this.btn_Muuda.TabIndex = 21;
        this.btn_Muuda.Text = "Muuda";
        this.btn_Muuda.UseVisualStyleBackColor = true;
        this.btn_Muuda.Click += new System.EventHandler(this.btn_Muuda_Click);
        //
        // tb_VeergNimi
        //
        this.tb_VeergNimi.Enabled = false;
        this.tb_VeergNimi.Location = new System.Drawing.Point(76, 43);
        this.tb_VeergNimi.Name = "tb_VeergNimi";
        this.tb_VeergNimi.Size = new System.Drawing.Size(105, 20);
        this.tb_VeergNimi.TabIndex = 22;
        //
        // btn_LisaVeerg
        //
        this.btn_LisaVeerg.Enabled = false;
        this.btn_LisaVeerg.Location = new System.Drawing.Point(187, 69);
        this.btn_LisaVeerg.Name = "btn_LisaVeerg";
        this.btn_LisaVeerg.Size = new System.Drawing.Size(75, 23);
        this.btn_LisaVeerg.TabIndex = 23;
        this.btn_LisaVeerg.Text = "Lisa";
        this.btn_LisaVeerg.UseVisualStyleBackColor = true;
        this.btn_LisaVeerg.Click += new System.EventHandler(this.btn_LisaVeerg_Click);
        //
        // cb_SqlMuutujad
        //
        this.cb_SqlMuutujad.Enabled = false;
        this.cb_SqlMuutujad.FormattingEnabled = true;
        this.cb_SqlMuutujad.Location = new System.Drawing.Point(187, 42);
        this.cb_SqlMuutujad.Name = "cb_SqlMuutujad";
        this.cb_SqlMuutujad.Size = new System.Drawing.Size(75, 21);
        this.cb_SqlMuutujad.TabIndex = 24;
        //
        // cb_KustutaVeerg
        //
        this.cb_KustutaVeerg.Enabled = false;
        this.cb_KustutaVeerg.FormattingEnabled = true;
        this.cb_KustutaVeerg.Location = new System.Drawing.Point(75, 100);
        this.cb_KustutaVeerg.Name = "cb_KustutaVeerg";
        this.cb_KustutaVeerg.Size = new System.Drawing.Size(102, 21);
        this.cb_KustutaVeerg.TabIndex = 25;
        //
        // btn_KustutaVeerg
        //
        this.btn_KustutaVeerg.Enabled = false;
        this.btn_KustutaVeerg.Location = new System.Drawing.Point(187, 100);
        this.btn_KustutaVeerg.Name = "btn_KustutaVeerg";
        this.btn_KustutaVeerg.Size = new System.Drawing.Size(75, 23);
        this.btn_KustutaVeerg.TabIndex = 26;
        this.btn_KustutaVeerg.Text = "Kustuta";
        this.btn_KustutaVeerg.UseVisualStyleBackColor = true;
        this.btn_KustutaVeerg.Click += new System.EventHandler(this.btn_KustutaVeerg_Click);
        //
        // lbl_Voimsus
        //
        this.lbl_Voimsus.AutoSize = true;
        this.lbl_Voimsus.Location = new System.Drawing.Point(57, 72);
        this.lbl_Voimsus.Name = "lbl_Voimsus";
        this.lbl_Voimsus.Size = new System.Drawing.Size(49, 13);
        this.lbl_Voimsus.TabIndex = 30;
        this.lbl_Voimsus.Text = "Võimsus:";
        //
        // lbl_Nimetus
        //
        this.lbl_Nimetus.AutoSize = true;
        this.lbl_Nimetus.Location = new System.Drawing.Point(58, 39);
        this.lbl_Nimetus.Name = "lbl_Nimetus";
        this.lbl_Nimetus.Size = new System.Drawing.Size(48, 13);
        this.lbl_Nimetus.TabIndex = 29;
        this.lbl_Nimetus.Text = "Nimetus:";
        //
        // tb_Voimsus
        //
        this.tb_Voimsus.Enabled = false;
        this.tb_Voimsus.Location = new System.Drawing.Point(123, 69);
        this.tb_Voimsus.Name = "tb_Voimsus";
        this.tb_Voimsus.Size = new System.Drawing.Size(139, 20);
        this.tb_Voimsus.TabIndex = 28;
        //
        // tb_Nimetus
        //
        this.tb_Nimetus.Enabled = false;
        this.tb_Nimetus.Location = new System.Drawing.Point(123, 36);
        this.tb_Nimetus.Name = "tb_Nimetus";
        this.tb_Nimetus.Size = new System.Drawing.Size(139, 20);
        this.tb_Nimetus.TabIndex = 27;
        //
        // lbl_VeeruNimi
        //
        this.lbl_VeeruNimi.AutoSize = true;
        this.lbl_VeeruNimi.Location = new System.Drawing.Point(8, 46);
        this.lbl_VeeruNimi.Name = "lbl_VeeruNimi";
        this.lbl_VeeruNimi.Size = new System.Drawing.Size(62, 13);
        this.lbl_VeeruNimi.TabIndex = 31;
        this.lbl_VeeruNimi.Text = "Veeru nimi: ";
        //
        // lbl_ValiVeerg
        //
        this.lbl_ValiVeerg.AutoSize = true;
        this.lbl_ValiVeerg.Location = new System.Drawing.Point(10, 105);
        this.lbl_ValiVeerg.Name = "lbl_ValiVeerg";
        this.lbl_ValiVeerg.Size = new System.Drawing.Size(60, 13);
        this.lbl_ValiVeerg.TabIndex = 32;
        this.lbl_ValiVeerg.Text = "Vali veerg: ";
        //
        // gb_Kustutamine
        //
        this.gb_Kustutamine.Controls.Add(this.lbl_Id);
        this.gb_Kustutamine.Controls.Add(this.tb_IdDelete);
        this.gb_Kustutamine.Controls.Add(this.btn_Kustuta);
        this.gb_Kustutamine.Location = new System.Drawing.Point(12, 47);
        this.gb_Kustutamine.Name = "gb_Kustutamine";
        this.gb_Kustutamine.Size = new System.Drawing.Size(245, 69);
        this.gb_Kustutamine.TabIndex = 33;
        this.gb_Kustutamine.TabStop = false;
        this.gb_Kustutamine.Text = "Kustutamine";
        //
        // gb_Sisestamine
        //
        this.gb_Sisestamine.Controls.Add(this.tb_Nimetus);
        this.gb_Sisestamine.Controls.Add(this.btn_Sisesta);
        this.gb_Sisestamine.Controls.Add(this.tb_Voimsus);
        this.gb_Sisestamine.Controls.Add(this.lbl_Voimsus);
        this.gb_Sisestamine.Controls.Add(this.lbl_Nimetus);
        this.gb_Sisestamine.Location = new System.Drawing.Point(485, 131);
        this.gb_Sisestamine.Name = "gb_Sisestamine";
        this.gb_Sisestamine.Size = new System.Drawing.Size(282, 126);
        this.gb_Sisestamine.TabIndex = 34;
        this.gb_Sisestamine.TabStop = false;
        this.gb_Sisestamine.Text = "Andmete sisestamine";
        //
        // groupBox1
        //
        this.groupBox1.Controls.Add(this.tb_ValitudTabel);
        this.groupBox1.Controls.Add(this.lbl_ValitudTabel);
        this.groupBox1.Controls.Add(this.cb_Veerud);
        this.groupBox1.Controls.Add(this.lbl_Veerud);
        this.groupBox1.Controls.Add(this.cb_Id);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.tb_Muutmine);
        this.groupBox1.Controls.Add(this.btn_Muuda);
        this.groupBox1.Location = new System.Drawing.Point(485, 263);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(282, 194);
        this.groupBox1.TabIndex = 35;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Andmete muutmine";
        //
        // groupBox2
        //
        this.groupBox2.Controls.Add(this.lbl_VeeruNimi);
        this.groupBox2.Controls.Add(this.tb_VeergNimi);
        this.groupBox2.Controls.Add(this.btn_LisaVeerg);
        this.groupBox2.Controls.Add(this.cb_SqlMuutujad);
        this.groupBox2.Controls.Add(this.lbl_ValiVeerg);
        this.groupBox2.Controls.Add(this.cb_KustutaVeerg);
        this.groupBox2.Controls.Add(this.btn_KustutaVeerg);
        this.groupBox2.Location = new System.Drawing.Point(485, 463);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(282, 132);
        this.groupBox2.TabIndex = 36;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Veerude lisamine või kustutamine";
        //
        // pictureBox1
        //
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(263, 12);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(212, 113);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 37;
        this.pictureBox1.TabStop = false;
        //
        // AdminForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.ClientSize = new System.Drawing.Size(779, 634);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.btn_Tagasi);
        this.Controls.Add(this.gb_Sisestamine);
        this.Controls.Add(this.gb_Kustutamine);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.dgv_Andmebaas);
        this.Controls.Add(this.cb_Andmed);
        this.Controls.Add(this.btn_Vajuta);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MinimumSize = new System.Drawing.Size(523, 350);
        this.Name = "AdminForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Haldamine";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
        this.Load += new System.EventHandler(this.AdminForm_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgv_Andmebaas)).EndInit();
        this.gb_Kustutamine.ResumeLayout(false);
        this.gb_Kustutamine.PerformLayout();
        this.gb_Sisestamine.ResumeLayout(false);
        this.gb_Sisestamine.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btn_Vajuta;
    private System.Windows.Forms.ComboBox cb_Andmed;
    private System.Windows.Forms.DataGridView dgv_Andmebaas;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lbl_ValitudTabel;
    private System.Windows.Forms.TextBox tb_ValitudTabel;
    private System.Windows.Forms.Button btn_Sisesta;
    private System.Windows.Forms.Label lbl_Id;
    private System.Windows.Forms.TextBox tb_IdDelete;
    private System.Windows.Forms.Button btn_Kustuta;
    private System.Windows.Forms.Button btn_Tagasi;
    private System.Windows.Forms.ComboBox cb_Veerud;
    private System.Windows.Forms.Label lbl_Veerud;
    private System.Windows.Forms.ComboBox cb_Id;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tb_Muutmine;
    private System.Windows.Forms.Button btn_Muuda;
    private System.Windows.Forms.TextBox tb_VeergNimi;
    private System.Windows.Forms.Button btn_LisaVeerg;
    private System.Windows.Forms.ComboBox cb_SqlMuutujad;
    private System.Windows.Forms.ComboBox cb_KustutaVeerg;
    private System.Windows.Forms.Button btn_KustutaVeerg;
    private System.Windows.Forms.Label lbl_Voimsus;
    private System.Windows.Forms.Label lbl_Nimetus;
    private System.Windows.Forms.TextBox tb_Voimsus;
    private System.Windows.Forms.TextBox tb_Nimetus;
    private System.Windows.Forms.Label lbl_VeeruNimi;
    private System.Windows.Forms.Label lbl_ValiVeerg;
    private System.Windows.Forms.GroupBox gb_Kustutamine;
    private System.Windows.Forms.GroupBox gb_Sisestamine;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
}
}