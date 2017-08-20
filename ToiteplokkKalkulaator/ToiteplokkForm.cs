using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToiteplokkKalkulaator.Klassid;

namespace ToiteplokkKalkulaator
{
public partial class ToiteplokkForm : Form
{
    ToiteplokkVoimsus voimsus = new ToiteplokkVoimsus();
    private void ToiteplokkForm_Load(object sender, EventArgs e) // Formi laadimise sündmus.
    {
        this.AcceptButton = btn_Arvuta; // Enteri vajutamine.
        RAM(); // Meetod "RAM()"
        Storage(); // Meetod "Storage()"
        Optical(); // Meetod "Optical()"
    }
    public ToiteplokkForm() // Formi meetod.
    {
        InitializeComponent(); // Disaini meetodid.
    }

    private void väljuToolStripMenuItem_Click(object sender, EventArgs e) // Formi sulgemise sündmus.
    {
        Application.Exit(); // Rakenduse välja lülitamine.
    }

    private void infoToolStripMenuItem_Click(object sender, EventArgs e) // Menüüst info nupp.
    {
        InfoForm info = new InfoForm(); // Klassi kutsumine.
        info.Show(); // Info akna avamine.
    }
    private void RAM() // Meetod "RAM()"
    {
        Komponendid RamC = new Operatiivmälu(); // Klassi kutsumine.
        cb_RAM.Items.AddRange(RamC.AndmedM().ToArray()); // ComboBoxi andmete lisamine.
    }

    private void Optical() // Meetod "Optical()"
    {
        Komponendid OpticalC = new OptilineSeade(); // Klassi kutsumine.
        cb_Optical.Items.AddRange(OpticalC.AndmedM().ToArray()); // ComboBoxi andmete lisamine.
    }

    private void Storage() // Meetod "Storage()"
    {
        Komponendid StorageC = new SailitusSeade(); // Klassi kutsumine.
        cb_Storage.Items.AddRange(StorageC.AndmedM().ToArray()); // ComboBoxi andmete lisamine.
    }


    private void rb_Intel_CheckedChanged(object sender, EventArgs e) // RadioButton Intel Valitud
    {
        pb_Intel.Visible = true; // PictureBox nähtav true.
        pb_AMD.Visible = false; // PictureBox nähtav false.
        lbl_PowerProtsessor.Text = ("0 W"); // Labelis tekst on "0 W"
        voimsus.PowerProtsessor = 0;
        cb_Protsessor.ResetText(); // Kustutab väli ComboBoxis.
        cb_Protsessor.Items.Clear(); // Kustutab andmed ComboBoxist.
        Komponendid IntelC = new IntelProtessor(); // Klassi kutsumine.
        cb_Protsessor.Items.AddRange(IntelC.AndmedM().ToArray()); // ComboBoxi andmete lisamine.
    }

    private void rb_AMD_CheckedChanged(object sender, EventArgs e) // RadioButton AMD Valitud
    {
        pb_AMD.Visible = true; // PictureBox nähtav true.
        pb_Intel.Visible = false; // PictureBox nähtav false.
        lbl_PowerProtsessor.Text = ("0 W"); // Labelis tekst on "0 W"
        voimsus.PowerProtsessor = 0;
        cb_Protsessor.ResetText(); // Kustutab väli ComboBoxis.
        cb_Protsessor.Items.Clear(); // Kustutab andmed ComboBoxist.
        Komponendid AmdC = new AmdProtsessor(); // Klassi kutsumine.
        cb_Protsessor.Items.AddRange(AmdC.AndmedM().ToArray());
    }

    private void rb_NVIDIA_CheckedChanged(object sender, EventArgs e) // RadioButton NVIDIA Valitud
    {
        pb_Nvidia.Visible = true; // PictureBox nähtav true.
        pb_AmdGpu.Visible = false; // PictureBox nähtav false.
        lbl_PowerVideokaart.Text = ("0 W"); // Labelis tekst on "0 W"
        voimsus.PowerVideokaart = 0;
        cb_Videokaart.ResetText(); // Kustutab väli ComboBoxis.
        cb_Videokaart.Items.Clear(); // Kustutab andmed ComboBoxist.
        Komponendid NvidiaC = new NvidiaVideokaart(); // Klassi kutsumine.
        cb_Videokaart.Items.AddRange(NvidiaC.AndmedM().ToArray()); // ComboBoxi andmete lisamine.
    }

    private void rb_AMDGPU_CheckedChanged(object sender, EventArgs e) // RadioButton AMDGPU Valitud
    {
        pb_AmdGpu.Visible = true; // PictureBox nähtav true.
        pb_Nvidia.Visible = false; // PictureBox nähtav false.
        lbl_PowerVideokaart.Text = ("0 W"); // Labelis tekst on "0 W"
        voimsus.PowerVideokaart = 0;
        cb_Videokaart.ResetText(); // Kustutab väli ComboBoxis.
        cb_Videokaart.Items.Clear(); // Kustutab andmed ComboBoxist.
        Komponendid AmdGpuC = new AmdVideokaart(); // Klassi kutsumine.
        cb_Videokaart.Items.AddRange(AmdGpuC.AndmedM().ToArray()); // ComboBoxi andmete lisamine.
    }

    private void cb_Protsessor_SelectedIndexChanged(object sender, EventArgs e) // ComboBoxist valitud tekst.
    {

        if (rb_Intel.Checked) // Kui Intel RadioButton valitud.
        {
            if (cb_Protsessor.SelectedItem.ToString().Equals("")) // Kui ComboBoxi väli on tühi.
                return; // Tagastab.
            ComboBox cb = sender as ComboBox; // Klassi kutsumine.
            ToiteplokkAndmed Valitud = cb.SelectedItem as ToiteplokkAndmed; // ComboBoxi määramine klassi.
            lbl_PowerProtsessor.Text = Valitud.Power.ToString() + " W"; // Label võimsus.
            voimsus.PowerProtsessor = Valitud.Power; // Muutuja määramine.

        }
        else if (rb_AMD.Checked) // Kui AMD RadioButton valitud.
        {
            if (cb_Protsessor.SelectedItem.ToString().Equals("")) // Kui ComboBoxi väli on tühi.
                return; // Tagastab.
            ComboBox cb = sender as ComboBox; // Klassi kutsumine.
            ToiteplokkAndmed Valitud = cb.SelectedItem as ToiteplokkAndmed; // ComboBoxi määramine klassi.
            lbl_PowerProtsessor.Text = Valitud.Power.ToString() + " W"; // Label võimsus.
            voimsus.PowerProtsessor = Valitud.Power; // Muutuja määramine.
        }
    }

    private void cb_RAM_SelectedIndexChanged(object sender, EventArgs e) // ComboBoxist valitud tekst.
    {
        if (cb_RAM.SelectedItem.ToString().Equals("")) // Kui ComboBoxi väli on tühi.
            return; // Tagastab.
        ComboBox cb = sender as ComboBox; // Klassi kutsumine.
        ToiteplokkAndmed Valitud = cb.SelectedItem as ToiteplokkAndmed; // ComboBoxi määramine klassi.
        lbl_PowerRAM.Text = Valitud.Power.ToString() + " W"; // Label võimsus.
        voimsus.PowerRAM = Valitud.Power; // Muutuja määramine.
    }

    private void cb_Videokaart_SelectedIndexChanged(object sender, EventArgs e) // ComboBoxist valitud tekst.
    {
        if (rb_NVIDIA.Checked) // Kui NVIDIA RadioButton valitud.
        {
            if (cb_Videokaart.SelectedItem.ToString().Equals("")) // Kui ComboBoxi väli on tühi.
                return; // Tagastab.
            ComboBox cb = sender as ComboBox; // Klassi kutsumine.
            ToiteplokkAndmed Valitud = cb.SelectedItem as ToiteplokkAndmed; // ComboBoxi määramine klassi.
            lbl_PowerVideokaart.Text = Valitud.Power.ToString() + " W"; // Label võimsus.
            voimsus.PowerVideokaart = Valitud.Power; // Muutuja määramine.
        }
        else if (rb_AMDGPU.Checked) // Kui AMDGPU RadioButton valitud.
        {
            if (cb_Videokaart.SelectedItem.ToString().Equals("")) // Kui ComboBoxi väli on tühi.
                return; // Tagastab.
            ComboBox cb = sender as ComboBox; // Klassi kutsumine.
            ToiteplokkAndmed Valitud = cb.SelectedItem as ToiteplokkAndmed; // ComboBoxi määramine klassi.
            lbl_PowerVideokaart.Text = Valitud.Power.ToString() + " W"; // Label võimsus.
            voimsus.PowerVideokaart = Valitud.Power; // Muutuja määramine.
        }
    }

    private void cb_Storage_SelectedIndexChanged(object sender, EventArgs e) // ComboBoxist valitud tekst.
    {
        if (cb_Storage.SelectedItem.ToString().Equals("")) // Kui ComboBoxi väli on tühi.
            return; // Tagastab.
        ComboBox cb = sender as ComboBox; // Klassi kutsumine.
        ToiteplokkAndmed Valitud = cb.SelectedItem as ToiteplokkAndmed; // ComboBoxi määramine klassi.
        lbl_PowerStorage.Text = Valitud.Power.ToString() + " W"; // Label võimsus.
        voimsus.PowerStorage = Valitud.Power; // Muutuja määramine.
    }

    private void cb_Optical_SelectedIndexChanged(object sender, EventArgs e) // ComboBoxist valitud tekst.
    {
        if (cb_Optical.SelectedItem.ToString().Equals("")) // Kui ComboBoxi väli on tühi.
            return; // Tagastab.
        ComboBox cb = sender as ComboBox; // Klassi kutsumine.
        ToiteplokkAndmed Valitud = cb.SelectedItem as ToiteplokkAndmed; // ComboBoxi määramine klassi.
        lbl_PowerOptical.Text = Valitud.Power.ToString() + " W"; // Label võimsus.
        voimsus.PowerOptical = Valitud.Power; // Muutuja määramine.
    }


    private void btn_Arvuta_Click(object sender, EventArgs e) // Nupp arvuta.
    {
        lbl_Vastus.Text = (voimsus.Vastus()) + " W"; // Label vastus.
        lbl_VastusRecommended.Text = (voimsus.VastusRecommended()) + " W"; // Label vastus recommended.
        if(voimsus.VastusRecommended() != 0)
            lbl_Link.Visible = true; // LinkLabel nähtav true.
    }
    private void btn_Clear_Click(object sender, EventArgs e) // Nupp tühista.
    {
        lbl_Link.Visible = false; // LinkLabel nähtav false.
        rb_AMD.Checked = false; // RadioButton kontrollitud false.
        rb_Intel.Checked = false; // RadioButton kontrollitud false.
        rb_AMDGPU.Checked = false; // RadioButton kontrollitud false.
        rb_NVIDIA.Checked = false; // RadioButton kontrollitud false.
        pb_AMD.Visible = false; // Pilt peidab.
        pb_AmdGpu.Visible = false; // Pilt peidab.
        pb_Intel.Visible = false; // Pilt peidab.
        pb_Nvidia.Visible = false; // Pilt peidab.
        cb_Protsessor.ResetText(); // Kustutab väli ComboBoxis.
        cb_Protsessor.Items.Clear(); // Kustutab andmed ComboBoxist.
        cb_Videokaart.Items.Clear(); // Kustutab andmed ComboBoxist.
        cb_Videokaart.ResetText(); // Kustutab väli ComboBoxis.
        cb_RAM.ResetText(); // Kustutab väli ComboBoxis.
        cb_Optical.ResetText(); // Kustutab väli ComboBoxis.
        cb_Storage.ResetText(); // Kustutab väli ComboBoxis.
        lbl_PowerProtsessor.Text = ("0 W"); // Label on "0 W".
        lbl_PowerRAM.Text = ("0 W"); // Label on "0 W".
        lbl_PowerVideokaart.Text = ("0 W"); // Label on "0 W".
        lbl_PowerStorage.Text = ("0 W"); // Label on "0 W".
        lbl_PowerOptical.Text = ("0 W"); // Label on "0 W".
        lbl_Vastus.Text = ("0 W"); // Label on "0 W".
        lbl_VastusRecommended.Text = ("0 W"); // Label on "0 W".
        voimsus.PowerProtsessor = 0; // Muutuja on 0.
        voimsus.PowerRAM = 0; // Muutuja on 0.
        voimsus.PowerVideokaart = 0; // Muutuja on 0.
        voimsus.PowerStorage = 0; // Muutuja on 0.
        voimsus.PowerOptical = 0; // Muutuja on 0.
    }

    private void adminKontoToolStripMenuItem_Click(object sender, EventArgs e) // Menüüst admini nupp.
    {
        Hide(); // Peida
        LoginForm login = new LoginForm(); // Klassi kutsumine.
        login.ShowDialog(); // Ava aken.
    }

    private void ToiteplokkForm_FormClosing(object sender, FormClosingEventArgs e) // Akna sulgemine.
    {
        Application.Exit(); // Rakenduse välja lülitamine.
    }

    private void lbl_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // LinkLabel vajutatud.
    {
        voimsus.Vordle();
    }
}
}
