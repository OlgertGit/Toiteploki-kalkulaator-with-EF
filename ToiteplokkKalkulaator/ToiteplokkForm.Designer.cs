namespace ToiteplokkKalkulaator
{
partial class ToiteplokkForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToiteplokkForm));
        this.lbl_RAM = new System.Windows.Forms.Label();
        this.lbl_Storage = new System.Windows.Forms.Label();
        this.lbl_Optical = new System.Windows.Forms.Label();
        this.btn_Arvuta = new System.Windows.Forms.Button();
        this.cb_RAM = new System.Windows.Forms.ComboBox();
        this.cb_Storage = new System.Windows.Forms.ComboBox();
        this.cb_Optical = new System.Windows.Forms.ComboBox();
        this.lbl_PowerRecommended = new System.Windows.Forms.Label();
        this.lbl_VastusRecommended = new System.Windows.Forms.Label();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.failToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.adminKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.väljuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.gb_Protsessor = new System.Windows.Forms.GroupBox();
        this.lbl_PowerProtsessor = new System.Windows.Forms.Label();
        this.cb_Protsessor = new System.Windows.Forms.ComboBox();
        this.rb_AMD = new System.Windows.Forms.RadioButton();
        this.rb_Intel = new System.Windows.Forms.RadioButton();
        this.gb_Videokaart = new System.Windows.Forms.GroupBox();
        this.lbl_PowerVideokaart = new System.Windows.Forms.Label();
        this.cb_Videokaart = new System.Windows.Forms.ComboBox();
        this.rb_AMDGPU = new System.Windows.Forms.RadioButton();
        this.rb_NVIDIA = new System.Windows.Forms.RadioButton();
        this.lbl_PowerRAM = new System.Windows.Forms.Label();
        this.lbl_PowerStorage = new System.Windows.Forms.Label();
        this.lbl_PowerOptical = new System.Windows.Forms.Label();
        this.btn_Clear = new System.Windows.Forms.Button();
        this.lbl_Vastus = new System.Windows.Forms.Label();
        this.lbl_Power = new System.Windows.Forms.Label();
        this.lbl_Link = new System.Windows.Forms.LinkLabel();
        this.pb_Nvidia = new System.Windows.Forms.PictureBox();
        this.pb_Intel = new System.Windows.Forms.PictureBox();
        this.pb_AMD = new System.Windows.Forms.PictureBox();
        this.pb_AmdGpu = new System.Windows.Forms.PictureBox();
        this.menuStrip1.SuspendLayout();
        this.gb_Protsessor.SuspendLayout();
        this.gb_Videokaart.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pb_Nvidia)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pb_Intel)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pb_AMD)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pb_AmdGpu)).BeginInit();
        this.SuspendLayout();
        //
        // lbl_RAM
        //
        this.lbl_RAM.AutoSize = true;
        this.lbl_RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_RAM.Location = new System.Drawing.Point(29, 187);
        this.lbl_RAM.Name = "lbl_RAM";
        this.lbl_RAM.Size = new System.Drawing.Size(91, 16);
        this.lbl_RAM.TabIndex = 2;
        this.lbl_RAM.Text = "Operatiivmälu";
        //
        // lbl_Storage
        //
        this.lbl_Storage.AutoSize = true;
        this.lbl_Storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_Storage.Location = new System.Drawing.Point(29, 333);
        this.lbl_Storage.Name = "lbl_Storage";
        this.lbl_Storage.Size = new System.Drawing.Size(75, 16);
        this.lbl_Storage.TabIndex = 4;
        this.lbl_Storage.Text = "Kõvakettas";
        //
        // lbl_Optical
        //
        this.lbl_Optical.AutoSize = true;
        this.lbl_Optical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_Optical.Location = new System.Drawing.Point(29, 387);
        this.lbl_Optical.Name = "lbl_Optical";
        this.lbl_Optical.Size = new System.Drawing.Size(122, 16);
        this.lbl_Optical.TabIndex = 5;
        this.lbl_Optical.Text = "Optilised seadmed";
        //
        // btn_Arvuta
        //
        this.btn_Arvuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.btn_Arvuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.btn_Arvuta.Location = new System.Drawing.Point(29, 534);
        this.btn_Arvuta.Name = "btn_Arvuta";
        this.btn_Arvuta.Size = new System.Drawing.Size(75, 23);
        this.btn_Arvuta.TabIndex = 6;
        this.btn_Arvuta.Text = "Arvuta";
        this.btn_Arvuta.UseVisualStyleBackColor = true;
        this.btn_Arvuta.Click += new System.EventHandler(this.btn_Arvuta_Click);
        //
        // cb_RAM
        //
        this.cb_RAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                              | System.Windows.Forms.AnchorStyles.Right)));
        this.cb_RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.cb_RAM.FormattingEnabled = true;
        this.cb_RAM.Items.AddRange(new object[]
        {
            ""
        });
        this.cb_RAM.Location = new System.Drawing.Point(163, 184);
        this.cb_RAM.Name = "cb_RAM";
        this.cb_RAM.Size = new System.Drawing.Size(212, 24);
        this.cb_RAM.TabIndex = 9;
        this.cb_RAM.SelectedIndexChanged += new System.EventHandler(this.cb_RAM_SelectedIndexChanged);
        //
        // cb_Storage
        //
        this.cb_Storage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                  | System.Windows.Forms.AnchorStyles.Right)));
        this.cb_Storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.cb_Storage.FormattingEnabled = true;
        this.cb_Storage.Items.AddRange(new object[]
        {
            ""
        });
        this.cb_Storage.Location = new System.Drawing.Point(163, 330);
        this.cb_Storage.Name = "cb_Storage";
        this.cb_Storage.Size = new System.Drawing.Size(212, 24);
        this.cb_Storage.TabIndex = 11;
        this.cb_Storage.SelectedIndexChanged += new System.EventHandler(this.cb_Storage_SelectedIndexChanged);
        //
        // cb_Optical
        //
        this.cb_Optical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                  | System.Windows.Forms.AnchorStyles.Right)));
        this.cb_Optical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.cb_Optical.FormattingEnabled = true;
        this.cb_Optical.Items.AddRange(new object[]
        {
            ""
        });
        this.cb_Optical.Location = new System.Drawing.Point(163, 384);
        this.cb_Optical.Name = "cb_Optical";
        this.cb_Optical.Size = new System.Drawing.Size(212, 24);
        this.cb_Optical.TabIndex = 12;
        this.cb_Optical.SelectedIndexChanged += new System.EventHandler(this.cb_Optical_SelectedIndexChanged);
        //
        // lbl_PowerRecommended
        //
        this.lbl_PowerRecommended.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lbl_PowerRecommended.AutoSize = true;
        this.lbl_PowerRecommended.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_PowerRecommended.Location = new System.Drawing.Point(156, 468);
        this.lbl_PowerRecommended.Name = "lbl_PowerRecommended";
        this.lbl_PowerRecommended.Size = new System.Drawing.Size(329, 39);
        this.lbl_PowerRecommended.TabIndex = 13;
        this.lbl_PowerRecommended.Text = "Soovitatav võimsus:";
        //
        // lbl_VastusRecommended
        //
        this.lbl_VastusRecommended.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lbl_VastusRecommended.AutoSize = true;
        this.lbl_VastusRecommended.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_VastusRecommended.Location = new System.Drawing.Point(481, 465);
        this.lbl_VastusRecommended.Name = "lbl_VastusRecommended";
        this.lbl_VastusRecommended.Size = new System.Drawing.Size(84, 42);
        this.lbl_VastusRecommended.TabIndex = 14;
        this.lbl_VastusRecommended.Text = "0 W";
        //
        // menuStrip1
        //
        this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.failToolStripMenuItem,
            this.helpToolStripMenuItem
        });
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(729, 24);
        this.menuStrip1.TabIndex = 15;
        this.menuStrip1.Text = "menuStrip1";
        //
        // failToolStripMenuItem
        //
        this.failToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.adminKontoToolStripMenuItem,
            this.väljuToolStripMenuItem
        });
        this.failToolStripMenuItem.Name = "failToolStripMenuItem";
        this.failToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        this.failToolStripMenuItem.Text = "Fail";
        //
        // adminKontoToolStripMenuItem
        //
        this.adminKontoToolStripMenuItem.Name = "adminKontoToolStripMenuItem";
        this.adminKontoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        this.adminKontoToolStripMenuItem.Text = "Admin konto";
        this.adminKontoToolStripMenuItem.Click += new System.EventHandler(this.adminKontoToolStripMenuItem_Click);
        //
        // väljuToolStripMenuItem
        //
        this.väljuToolStripMenuItem.Name = "väljuToolStripMenuItem";
        this.väljuToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        this.väljuToolStripMenuItem.Text = "Välju";
        this.väljuToolStripMenuItem.Click += new System.EventHandler(this.väljuToolStripMenuItem_Click);
        //
        // helpToolStripMenuItem
        //
        this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            this.infoToolStripMenuItem
        });
        this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        this.helpToolStripMenuItem.Text = "Help";
        //
        // infoToolStripMenuItem
        //
        this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
        this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
        this.infoToolStripMenuItem.Text = "Info";
        this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
        //
        // gb_Protsessor
        //
        this.gb_Protsessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
        this.gb_Protsessor.Controls.Add(this.lbl_PowerProtsessor);
        this.gb_Protsessor.Controls.Add(this.cb_Protsessor);
        this.gb_Protsessor.Controls.Add(this.rb_AMD);
        this.gb_Protsessor.Controls.Add(this.rb_Intel);
        this.gb_Protsessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.gb_Protsessor.Location = new System.Drawing.Point(32, 71);
        this.gb_Protsessor.Name = "gb_Protsessor";
        this.gb_Protsessor.Size = new System.Drawing.Size(416, 79);
        this.gb_Protsessor.TabIndex = 33;
        this.gb_Protsessor.TabStop = false;
        this.gb_Protsessor.Text = "Protsessor";
        //
        // lbl_PowerProtsessor
        //
        this.lbl_PowerProtsessor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lbl_PowerProtsessor.AutoSize = true;
        this.lbl_PowerProtsessor.Location = new System.Drawing.Point(365, 40);
        this.lbl_PowerProtsessor.Name = "lbl_PowerProtsessor";
        this.lbl_PowerProtsessor.Size = new System.Drawing.Size(31, 16);
        this.lbl_PowerProtsessor.TabIndex = 37;
        this.lbl_PowerProtsessor.Text = "0 W";
        //
        // cb_Protsessor
        //
        this.cb_Protsessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
        this.cb_Protsessor.FormattingEnabled = true;
        this.cb_Protsessor.Items.AddRange(new object[]
        {
            ""
        });
        this.cb_Protsessor.Location = new System.Drawing.Point(131, 40);
        this.cb_Protsessor.Name = "cb_Protsessor";
        this.cb_Protsessor.Size = new System.Drawing.Size(212, 24);
        this.cb_Protsessor.TabIndex = 36;
        this.cb_Protsessor.SelectedIndexChanged += new System.EventHandler(this.cb_Protsessor_SelectedIndexChanged);
        //
        // rb_AMD
        //
        this.rb_AMD.AutoSize = true;
        this.rb_AMD.Location = new System.Drawing.Point(281, 10);
        this.rb_AMD.Name = "rb_AMD";
        this.rb_AMD.Size = new System.Drawing.Size(56, 20);
        this.rb_AMD.TabIndex = 34;
        this.rb_AMD.TabStop = true;
        this.rb_AMD.Text = "AMD";
        this.rb_AMD.UseVisualStyleBackColor = true;
        this.rb_AMD.CheckedChanged += new System.EventHandler(this.rb_AMD_CheckedChanged);
        //
        // rb_Intel
        //
        this.rb_Intel.AutoSize = true;
        this.rb_Intel.Location = new System.Drawing.Point(131, 10);
        this.rb_Intel.Name = "rb_Intel";
        this.rb_Intel.Size = new System.Drawing.Size(50, 20);
        this.rb_Intel.TabIndex = 33;
        this.rb_Intel.TabStop = true;
        this.rb_Intel.Text = "Intel";
        this.rb_Intel.UseVisualStyleBackColor = true;
        this.rb_Intel.CheckedChanged += new System.EventHandler(this.rb_Intel_CheckedChanged);
        //
        // gb_Videokaart
        //
        this.gb_Videokaart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
        this.gb_Videokaart.Controls.Add(this.lbl_PowerVideokaart);
        this.gb_Videokaart.Controls.Add(this.cb_Videokaart);
        this.gb_Videokaart.Controls.Add(this.rb_AMDGPU);
        this.gb_Videokaart.Controls.Add(this.rb_NVIDIA);
        this.gb_Videokaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.gb_Videokaart.Location = new System.Drawing.Point(29, 236);
        this.gb_Videokaart.Name = "gb_Videokaart";
        this.gb_Videokaart.Size = new System.Drawing.Size(419, 79);
        this.gb_Videokaart.TabIndex = 37;
        this.gb_Videokaart.TabStop = false;
        this.gb_Videokaart.Text = "Videokaart";
        //
        // lbl_PowerVideokaart
        //
        this.lbl_PowerVideokaart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lbl_PowerVideokaart.AutoSize = true;
        this.lbl_PowerVideokaart.Location = new System.Drawing.Point(368, 46);
        this.lbl_PowerVideokaart.Name = "lbl_PowerVideokaart";
        this.lbl_PowerVideokaart.Size = new System.Drawing.Size(31, 16);
        this.lbl_PowerVideokaart.TabIndex = 39;
        this.lbl_PowerVideokaart.Text = "0 W";
        //
        // cb_Videokaart
        //
        this.cb_Videokaart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
        this.cb_Videokaart.FormattingEnabled = true;
        this.cb_Videokaart.Items.AddRange(new object[]
        {
            ""
        });
        this.cb_Videokaart.Location = new System.Drawing.Point(134, 43);
        this.cb_Videokaart.Name = "cb_Videokaart";
        this.cb_Videokaart.Size = new System.Drawing.Size(212, 24);
        this.cb_Videokaart.TabIndex = 32;
        this.cb_Videokaart.SelectedIndexChanged += new System.EventHandler(this.cb_Videokaart_SelectedIndexChanged);
        //
        // rb_AMDGPU
        //
        this.rb_AMDGPU.AutoSize = true;
        this.rb_AMDGPU.Location = new System.Drawing.Point(284, 10);
        this.rb_AMDGPU.Name = "rb_AMDGPU";
        this.rb_AMDGPU.Size = new System.Drawing.Size(56, 20);
        this.rb_AMDGPU.TabIndex = 31;
        this.rb_AMDGPU.TabStop = true;
        this.rb_AMDGPU.Text = "AMD";
        this.rb_AMDGPU.UseVisualStyleBackColor = true;
        this.rb_AMDGPU.CheckedChanged += new System.EventHandler(this.rb_AMDGPU_CheckedChanged);
        //
        // rb_NVIDIA
        //
        this.rb_NVIDIA.AutoSize = true;
        this.rb_NVIDIA.Location = new System.Drawing.Point(134, 10);
        this.rb_NVIDIA.Name = "rb_NVIDIA";
        this.rb_NVIDIA.Size = new System.Drawing.Size(70, 20);
        this.rb_NVIDIA.TabIndex = 30;
        this.rb_NVIDIA.TabStop = true;
        this.rb_NVIDIA.Text = "NVIDIA";
        this.rb_NVIDIA.UseVisualStyleBackColor = true;
        this.rb_NVIDIA.CheckedChanged += new System.EventHandler(this.rb_NVIDIA_CheckedChanged);
        //
        // lbl_PowerRAM
        //
        this.lbl_PowerRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lbl_PowerRAM.AutoSize = true;
        this.lbl_PowerRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_PowerRAM.Location = new System.Drawing.Point(397, 192);
        this.lbl_PowerRAM.Name = "lbl_PowerRAM";
        this.lbl_PowerRAM.Size = new System.Drawing.Size(31, 16);
        this.lbl_PowerRAM.TabIndex = 38;
        this.lbl_PowerRAM.Text = "0 W";
        //
        // lbl_PowerStorage
        //
        this.lbl_PowerStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lbl_PowerStorage.AutoSize = true;
        this.lbl_PowerStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_PowerStorage.Location = new System.Drawing.Point(397, 333);
        this.lbl_PowerStorage.Name = "lbl_PowerStorage";
        this.lbl_PowerStorage.Size = new System.Drawing.Size(31, 16);
        this.lbl_PowerStorage.TabIndex = 40;
        this.lbl_PowerStorage.Text = "0 W";
        //
        // lbl_PowerOptical
        //
        this.lbl_PowerOptical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lbl_PowerOptical.AutoSize = true;
        this.lbl_PowerOptical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_PowerOptical.Location = new System.Drawing.Point(397, 387);
        this.lbl_PowerOptical.Name = "lbl_PowerOptical";
        this.lbl_PowerOptical.Size = new System.Drawing.Size(31, 16);
        this.lbl_PowerOptical.TabIndex = 41;
        this.lbl_PowerOptical.Text = "0 W";
        //
        // btn_Clear
        //
        this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.btn_Clear.Location = new System.Drawing.Point(133, 534);
        this.btn_Clear.Name = "btn_Clear";
        this.btn_Clear.Size = new System.Drawing.Size(75, 23);
        this.btn_Clear.TabIndex = 42;
        this.btn_Clear.Text = "Tühista";
        this.btn_Clear.UseVisualStyleBackColor = true;
        this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
        //
        // lbl_Vastus
        //
        this.lbl_Vastus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lbl_Vastus.AutoSize = true;
        this.lbl_Vastus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_Vastus.Location = new System.Drawing.Point(481, 431);
        this.lbl_Vastus.Name = "lbl_Vastus";
        this.lbl_Vastus.Size = new System.Drawing.Size(75, 37);
        this.lbl_Vastus.TabIndex = 44;
        this.lbl_Vastus.Text = "0 W";
        //
        // lbl_Power
        //
        this.lbl_Power.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lbl_Power.AutoSize = true;
        this.lbl_Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_Power.Location = new System.Drawing.Point(325, 431);
        this.lbl_Power.Name = "lbl_Power";
        this.lbl_Power.Size = new System.Drawing.Size(150, 37);
        this.lbl_Power.TabIndex = 43;
        this.lbl_Power.Text = "Võimsus:";
        //
        // lbl_Link
        //
        this.lbl_Link.AutoSize = true;
        this.lbl_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lbl_Link.LinkColor = System.Drawing.Color.LightSeaGreen;
        this.lbl_Link.Location = new System.Drawing.Point(592, 515);
        this.lbl_Link.Name = "lbl_Link";
        this.lbl_Link.Size = new System.Drawing.Size(97, 42);
        this.lbl_Link.TabIndex = 45;
        this.lbl_Link.TabStop = true;
        this.lbl_Link.Text = "Osta";
        this.lbl_Link.Visible = false;
        this.lbl_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Link_LinkClicked);
        //
        // pb_Nvidia
        //
        this.pb_Nvidia.Image = global::ToiteplokkKalkulaator.Properties.Resources.nvidialogo;
        this.pb_Nvidia.Location = new System.Drawing.Point(503, 220);
        this.pb_Nvidia.Name = "pb_Nvidia";
        this.pb_Nvidia.Size = new System.Drawing.Size(186, 185);
        this.pb_Nvidia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pb_Nvidia.TabIndex = 47;
        this.pb_Nvidia.TabStop = false;
        this.pb_Nvidia.Visible = false;
        //
        // pb_Intel
        //
        this.pb_Intel.Image = global::ToiteplokkKalkulaator.Properties.Resources.intellogo;
        this.pb_Intel.Location = new System.Drawing.Point(503, 33);
        this.pb_Intel.Name = "pb_Intel";
        this.pb_Intel.Size = new System.Drawing.Size(186, 172);
        this.pb_Intel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pb_Intel.TabIndex = 46;
        this.pb_Intel.TabStop = false;
        this.pb_Intel.Visible = false;
        //
        // pb_AMD
        //
        this.pb_AMD.Image = global::ToiteplokkKalkulaator.Properties.Resources.amdlogo;
        this.pb_AMD.Location = new System.Drawing.Point(503, 33);
        this.pb_AMD.Name = "pb_AMD";
        this.pb_AMD.Size = new System.Drawing.Size(186, 172);
        this.pb_AMD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pb_AMD.TabIndex = 48;
        this.pb_AMD.TabStop = false;
        this.pb_AMD.Visible = false;
        //
        // pb_AmdGpu
        //
        this.pb_AmdGpu.Image = global::ToiteplokkKalkulaator.Properties.Resources.amdgpulogo;
        this.pb_AmdGpu.Location = new System.Drawing.Point(503, 220);
        this.pb_AmdGpu.Name = "pb_AmdGpu";
        this.pb_AmdGpu.Size = new System.Drawing.Size(186, 185);
        this.pb_AmdGpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pb_AmdGpu.TabIndex = 49;
        this.pb_AmdGpu.TabStop = false;
        this.pb_AmdGpu.Visible = false;
        //
        // ToiteplokkForm
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(729, 580);
        this.Controls.Add(this.pb_AmdGpu);
        this.Controls.Add(this.pb_AMD);
        this.Controls.Add(this.pb_Nvidia);
        this.Controls.Add(this.pb_Intel);
        this.Controls.Add(this.lbl_Link);
        this.Controls.Add(this.lbl_Vastus);
        this.Controls.Add(this.lbl_Power);
        this.Controls.Add(this.btn_Clear);
        this.Controls.Add(this.lbl_PowerOptical);
        this.Controls.Add(this.lbl_PowerStorage);
        this.Controls.Add(this.lbl_PowerRAM);
        this.Controls.Add(this.gb_Videokaart);
        this.Controls.Add(this.gb_Protsessor);
        this.Controls.Add(this.lbl_VastusRecommended);
        this.Controls.Add(this.lbl_PowerRecommended);
        this.Controls.Add(this.cb_Optical);
        this.Controls.Add(this.cb_Storage);
        this.Controls.Add(this.cb_RAM);
        this.Controls.Add(this.btn_Arvuta);
        this.Controls.Add(this.lbl_Optical);
        this.Controls.Add(this.lbl_Storage);
        this.Controls.Add(this.lbl_RAM);
        this.Controls.Add(this.menuStrip1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MainMenuStrip = this.menuStrip1;
        this.MinimumSize = new System.Drawing.Size(745, 593);
        this.Name = "ToiteplokkForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Toiteploki kalkulaator";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToiteplokkForm_FormClosing);
        this.Load += new System.EventHandler(this.ToiteplokkForm_Load);
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.gb_Protsessor.ResumeLayout(false);
        this.gb_Protsessor.PerformLayout();
        this.gb_Videokaart.ResumeLayout(false);
        this.gb_Videokaart.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pb_Nvidia)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pb_Intel)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pb_AMD)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pb_AmdGpu)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lbl_RAM;
    private System.Windows.Forms.Label lbl_Storage;
    private System.Windows.Forms.Label lbl_Optical;
    private System.Windows.Forms.Button btn_Arvuta;
    private System.Windows.Forms.ComboBox cb_RAM;
    private System.Windows.Forms.ComboBox cb_Storage;
    private System.Windows.Forms.ComboBox cb_Optical;
    private System.Windows.Forms.Label lbl_PowerRecommended;
    private System.Windows.Forms.Label lbl_VastusRecommended;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem failToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem väljuToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    private System.Windows.Forms.GroupBox gb_Protsessor;
    private System.Windows.Forms.ComboBox cb_Protsessor;
    private System.Windows.Forms.RadioButton rb_AMD;
    private System.Windows.Forms.RadioButton rb_Intel;
    private System.Windows.Forms.GroupBox gb_Videokaart;
    private System.Windows.Forms.ComboBox cb_Videokaart;
    private System.Windows.Forms.RadioButton rb_AMDGPU;
    private System.Windows.Forms.RadioButton rb_NVIDIA;
    private System.Windows.Forms.Label lbl_PowerProtsessor;
    private System.Windows.Forms.Label lbl_PowerVideokaart;
    private System.Windows.Forms.Label lbl_PowerRAM;
    private System.Windows.Forms.Label lbl_PowerStorage;
    private System.Windows.Forms.Label lbl_PowerOptical;
    private System.Windows.Forms.Button btn_Clear;
    private System.Windows.Forms.ToolStripMenuItem adminKontoToolStripMenuItem;
    private System.Windows.Forms.Label lbl_Vastus;
    private System.Windows.Forms.Label lbl_Power;
    private System.Windows.Forms.LinkLabel lbl_Link;
    private System.Windows.Forms.PictureBox pb_Intel;
    private System.Windows.Forms.PictureBox pb_Nvidia;
    private System.Windows.Forms.PictureBox pb_AMD;
    private System.Windows.Forms.PictureBox pb_AmdGpu;
}
}

