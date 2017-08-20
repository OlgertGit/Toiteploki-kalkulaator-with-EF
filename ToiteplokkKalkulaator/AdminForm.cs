using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToiteplokkKalkulaator.Klassid;

namespace ToiteplokkKalkulaator
{
public partial class AdminForm : Form
{

    public AdminForm() // Formi meetod.
    {
        InitializeComponent(); // Disaini meetodid.
    }

    private void BoolEnabled() // Meetod "BoolEnabled()"
    {
        btn_Sisesta.Enabled = true; // Nupp Sisesta "true".
        btn_Kustuta.Enabled = true; // Nupp Kustuta "true".
        btn_LisaVeerg.Enabled = true; // Nupp Lisa Veerg "true".
        btn_Muuda.Enabled = true; // Nupp Muuda "true".
        btn_KustutaVeerg.Enabled = true; // Nupp Kustuta Veerg "true".
        cb_KustutaVeerg.Enabled = true; // ComboBox Kustuta Veerg "true".
        cb_Id.Enabled = true; // ComboBox Id "true".
        cb_Veerud.Enabled = true; // ComboBox Veerud "true".
        cb_SqlMuutujad.Enabled = true; // ComboBox SqlMuutujad "true".
        tb_VeergNimi.Enabled = true; // Textbox Veerg Nimi "true".
        tb_Muutmine.Enabled = true; // Textbox Muutmine "true".
        tb_Nimetus.Enabled = true; // Textbox Nimetus "true".
        tb_Voimsus.Enabled = true; // Textbox Võimsus "true".
        tb_IdDelete.Enabled = true; // Textbox Kustuta, Id järgi "true".
        tb_Nimetus.ResetText(); // Puhastab Textbox väli.
        tb_Voimsus.ResetText();  // Puhastab Textbox väli.
        tb_IdDelete.ResetText();  // Puhastab Textbox väli.
    }

    private void ShowData() // Meetod "ShowData()"
    {
        try // Proovib
        {
            cb_Id.Items.Clear(); // Kustutab andmed ComboBoxist.
            cb_Id.ResetText(); // Kustutab väli ComboBoxis.
            cb_Veerud.Items.Clear(); // Kustutab andmed ComboBoxist.
            cb_Veerud.ResetText(); // Kustutab väli ComboBoxis.
            cb_KustutaVeerg.Items.Clear(); // Kustutab andmed ComboBoxist.
            cb_KustutaVeerg.ResetText(); // Kustutab väli ComboBoxis.
            cb_SqlMuutujad.ResetText(); // Kustutab väli ComboBoxis.
            tb_VeergNimi.ResetText(); // Kustutab väli TextBoxis.
            tb_Muutmine.ResetText(); // Kustutab väli TextBoxis.
            if (cb_Andmed.Text == "Intel Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "Intel Protsessor".
            {
                Komponendid intelProtsessor = new IntelProtessor(); // Klassi kutsumine.
                cb_Veerud.Items.AddRange(intelProtsessor.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_KustutaVeerg.Items.AddRange(intelProtsessor.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_Id.Items.AddRange(intelProtsessor.IdM().ToArray()); // ComboBoxi andmete lisamine.
                dgv_Andmebaas.DataSource = intelProtsessor.TabelM(); // Meetodi määramine.
                dgv_Andmebaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Automaatselt muudab suuruse veerudel.
                tb_ValitudTabel.Text = intelProtsessor.ValitudTabel(); // Meetodi määramine.
                lbl_Nimetus.Text = intelProtsessor.NimetusM(); // Meetodi määramine.
                lbl_Voimsus.Text = intelProtsessor.VoimsusM(); // Meetodi määramine.
                BoolEnabled(); // Meetod "BoolEnabled()".

            }
            else if (cb_Andmed.Text == "AMD Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Protsessor".
            {
                Komponendid amdProtsessor = new AmdProtsessor(); // Klassi kutsumine.
                cb_Veerud.Items.AddRange(amdProtsessor.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_KustutaVeerg.Items.AddRange(amdProtsessor.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_Id.Items.AddRange(amdProtsessor.IdM().ToArray()); // ComboBoxi andmete lisamine.
                dgv_Andmebaas.DataSource = amdProtsessor.TabelM(); // Meetodi määramine.
                dgv_Andmebaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Automaatselt muudab suuruse veerudel.
                tb_ValitudTabel.Text = amdProtsessor.ValitudTabel(); // Meetodi määramine.
                lbl_Nimetus.Text = amdProtsessor.NimetusM(); // Meetodi määramine.
                lbl_Voimsus.Text = amdProtsessor.VoimsusM(); // Meetodi määramine.
                BoolEnabled(); // Meetod "BoolEnabled()".

            }
            else if (cb_Andmed.Text == "AMD Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Videokaart".
            {
                Komponendid amdVideokaart = new AmdVideokaart(); // Klassi kutsumine.
                cb_Veerud.Items.AddRange(amdVideokaart.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_KustutaVeerg.Items.AddRange(amdVideokaart.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_Id.Items.AddRange(amdVideokaart.IdM().ToArray()); // ComboBoxi andmete lisamine.
                dgv_Andmebaas.DataSource = amdVideokaart.TabelM(); // Meetodi määramine.
                dgv_Andmebaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Automaatselt muudab suuruse veerudel.
                tb_ValitudTabel.Text = amdVideokaart.ValitudTabel(); // Meetodi määramine.
                lbl_Nimetus.Text = amdVideokaart.NimetusM(); // Meetodi määramine.
                lbl_Voimsus.Text = amdVideokaart.VoimsusM(); // Meetodi määramine.
                BoolEnabled(); // Meetod "BoolEnabled()".

            }
            else if (cb_Andmed.Text == "Nvidia Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "Nvidia Videokaartr".
            {
                Komponendid nvidiaVideokaart = new NvidiaVideokaart(); // Klassi kutsumine.
                cb_Veerud.Items.AddRange(nvidiaVideokaart.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_KustutaVeerg.Items.AddRange(nvidiaVideokaart.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_Id.Items.AddRange(nvidiaVideokaart.IdM().ToArray()); // ComboBoxi andmete lisamine.
                dgv_Andmebaas.DataSource = nvidiaVideokaart.TabelM(); // Meetodi määramine.
                dgv_Andmebaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Automaatselt muudab suuruse veerudel.
                tb_ValitudTabel.Text = nvidiaVideokaart.ValitudTabel(); // Meetodi määramine.
                lbl_Nimetus.Text = nvidiaVideokaart.NimetusM(); // Meetodi määramine.
                lbl_Voimsus.Text = nvidiaVideokaart.VoimsusM(); // Meetodi määramine.
                BoolEnabled(); // Meetod "BoolEnabled()".

            }
            else if (cb_Andmed.Text == "Operatiivmälu") // Kui Comboboxi väljal tekst võrdub sama, mis "Operatiivmälu".
            {
                Komponendid operatiivmälu = new Operatiivmälu(); // Klassi kutsumine.
                cb_Veerud.Items.AddRange(operatiivmälu.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_KustutaVeerg.Items.AddRange(operatiivmälu.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_Id.Items.AddRange(operatiivmälu.IdM().ToArray()); // ComboBoxi andmete lisamine.
                dgv_Andmebaas.DataSource = operatiivmälu.TabelM(); // Meetodi määramine.
                dgv_Andmebaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Automaatselt muudab suuruse veerudel.
                tb_ValitudTabel.Text = operatiivmälu.ValitudTabel(); // Meetodi määramine.
                lbl_Nimetus.Text = operatiivmälu.NimetusM(); // Meetodi määramine.
                lbl_Voimsus.Text = operatiivmälu.VoimsusM(); // Meetodi määramine.
                BoolEnabled(); // Meetod "BoolEnabled()".

            }
            else if (cb_Andmed.Text == "Optilised seadmed") // Kui Comboboxi väljal tekst võrdub sama, mis "Optilised seadmed".
            {
                Komponendid optilineSeade = new OptilineSeade(); // Klassi kutsumine.
                cb_Veerud.Items.AddRange(optilineSeade.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_KustutaVeerg.Items.AddRange(optilineSeade.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_Id.Items.AddRange(optilineSeade.IdM().ToArray()); // ComboBoxi andmete lisamine.
                dgv_Andmebaas.DataSource = optilineSeade.TabelM(); // Meetodi määramine.
                dgv_Andmebaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Automaatselt muudab suuruse veerudel.
                tb_ValitudTabel.Text = optilineSeade.ValitudTabel(); // Meetodi määramine.
                lbl_Nimetus.Text = optilineSeade.NimetusM(); // Meetodi määramine.
                lbl_Voimsus.Text = optilineSeade.VoimsusM(); // Meetodi määramine.
                BoolEnabled(); // Meetod "BoolEnabled()".

            }
            else if (cb_Andmed.Text == "Kõvakettas") // Kui Comboboxi väljal tekst võrdub sama, mis "Kõvakettas".
            {
                Komponendid sailitusSeade = new SailitusSeade(); // Klassi kutsumine.
                cb_Veerud.Items.AddRange(sailitusSeade.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_KustutaVeerg.Items.AddRange(sailitusSeade.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_Id.Items.AddRange(sailitusSeade.IdM().ToArray()); // ComboBoxi andmete lisamine.
                dgv_Andmebaas.DataSource = sailitusSeade.TabelM(); // Meetodi määramine.
                dgv_Andmebaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Automaatselt muudab suuruse veerudel.
                tb_ValitudTabel.Text = sailitusSeade.ValitudTabel(); // Meetodi määramine.
                lbl_Nimetus.Text = sailitusSeade.NimetusM(); // Meetodi määramine.
                lbl_Voimsus.Text = sailitusSeade.VoimsusM(); // Meetodi määramine.
                BoolEnabled(); // Meetod "BoolEnabled()".

            }
            else if (cb_Andmed.Text == "Toiteplokk Võimsus") // Kui Comboboxi väljal tekst võrdub sama, mis "Toiteplokk Võimsus".
            {
                Komponendid TPC = new ToiteplokkVoimsus(); // Klassi kutsumine.
                cb_Veerud.Items.AddRange(TPC.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_KustutaVeerg.Items.AddRange(TPC.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_Id.Items.AddRange(TPC.IdM().ToArray()); // ComboBoxi andmete lisamine.
                dgv_Andmebaas.DataSource = TPC.TabelM(); // Meetodi määramine.
                dgv_Andmebaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Automaatselt muudab suuruse veerudel.
                tb_ValitudTabel.Text = TPC.ValitudTabel(); // Meetodi määramine.
                lbl_Nimetus.Text = TPC.NimetusM(); // Meetodi määramine.
                lbl_Voimsus.Text = TPC.VoimsusM(); // Meetodi määramine.
                BoolEnabled(); // Meetod "BoolEnabled()".

            }
            else if (cb_Andmed.Text == "Kasutajad") // Kui Comboboxi väljal tekst võrdub sama, mis "Kasutajad".
            {
                Login LoginC = new Login(); // Klassi kutsumine.
                cb_Veerud.Items.AddRange(LoginC.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_KustutaVeerg.Items.AddRange(LoginC.ListVeerudM().ToArray()); // ComboBoxi andmete lisamine.
                cb_Id.Items.AddRange(LoginC.IdM().ToArray()); // ComboBoxi andmete lisamine.
                dgv_Andmebaas.DataSource = LoginC.TabelM(); // Meetodi määramine.
                dgv_Andmebaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Automaatselt muudab suuruse veerudel.
                tb_ValitudTabel.Text = LoginC.ValitudTabel(); // Meetodi määramine.
                lbl_Nimetus.Text = LoginC.NimetusM(); // Meetodi määramine.
                lbl_Voimsus.Text = LoginC.VoimsusM(); // Meetodi määramine.
                BoolEnabled(); // Meetod "BoolEnabled()".

            }
            else // Muu
            {
                return; // Tagastab
            }
        }
        catch (Exception ex) // Püüab viga.
        {

            MessageBox.Show(ex.Message,"Viga!",MessageBoxButtons.OK,MessageBoxIcon.Error); // Näitab viga MessageBoxis.
        }

    }

    private void InsertData() // Meetod "InsertData()"
    {
        try // Proovib
        {
            if (cb_Andmed.Text == "Intel Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "Intel Protsessor".
            {
                Komponendid IntelC = new IntelProtessor(); // Klassi kutsumine.
                IntelC.Sisestamine(tb_Nimetus.Text, tb_Voimsus.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "AMD Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Protsessor".
            {
                Komponendid AmdC = new AmdProtsessor(); // Klassi kutsumine.
                AmdC.Sisestamine(tb_Nimetus.Text, tb_Voimsus.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "AMD Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Videokaart".
            {
                Komponendid AmdGpuC = new AmdVideokaart(); // Klassi kutsumine.
                AmdGpuC.Sisestamine(tb_Nimetus.Text, tb_Voimsus.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "Nvidia Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "Nvidia Videokaart".
            {
                Komponendid NvidiaC = new NvidiaVideokaart(); // Klassi kutsumine.
                NvidiaC.Sisestamine(tb_Nimetus.Text, tb_Voimsus.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "Operatiivmälu") // Kui Comboboxi väljal tekst võrdub sama, mis "Operatiivmälu".
            {
                Komponendid RamC = new Operatiivmälu(); // Klassi kutsumine.
                RamC.Sisestamine(tb_Nimetus.Text, tb_Voimsus.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Optilised seadmed") // Kui Comboboxi väljal tekst võrdub sama, mis "Optilised seadmed".
            {
                Komponendid OpticalC = new OptilineSeade(); // Klassi kutsumine.
                OpticalC.Sisestamine(tb_Nimetus.Text, tb_Voimsus.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Kõvakettas") // Kui Comboboxi väljal tekst võrdub sama, mis "Kõvakettas".
            {
                Komponendid StorageC = new SailitusSeade(); // Klassi kutsumine.
                StorageC.Sisestamine(tb_Nimetus.Text, tb_Voimsus.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Toiteplokk Võimsus") // Kui Comboboxi väljal tekst võrdub sama, mis "Toiteplokk Võimsus".
            {
                Komponendid TPC = new ToiteplokkVoimsus(); // Klassi kutsumine.
                TPC.Sisestamine(tb_Nimetus.Text, tb_Voimsus.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Kasutajad") // Kui Comboboxi väljal tekst võrdub sama, mis "Kasutajad".
            {
                Komponendid LoginC = new Login(); // Klassi kutsumine.
                LoginC.Sisestamine(tb_Nimetus.Text, tb_Voimsus.Text); // Meetodi kutsumine.

            }
            else // Muu.
            {
                return; // Tagastab.
            }
        }
        catch (Exception ex) // Püüab viga.
        {

            MessageBox.Show(ex.Message, "Viga!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Näitab viga MessageBoxis.
        }

    }

    private void DeleteData() // Meetod "DeleteData()"
    {
        try // Proovib
        {
            if (cb_Andmed.Text == "Intel Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "Intel Protsessor".
            {
                Komponendid IntelC = new IntelProtessor(); // Klassi kutsumine.
                IntelC.Kustutamine(tb_IdDelete.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "AMD Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Protsessor".
            {
                Komponendid AmdC = new AmdProtsessor(); // Klassi kutsumine.
                AmdC.Kustutamine(tb_IdDelete.Text);  // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "AMD Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Videokaart".
            {
                Komponendid AmdGpuC = new AmdVideokaart(); // Klassi kutsumine.
                AmdGpuC.Kustutamine(tb_IdDelete.Text);  // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "Nvidia Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "Nvidia Videokaart".
            {
                Komponendid NvidiaC = new NvidiaVideokaart(); // Klassi kutsumine.
                NvidiaC.Kustutamine(tb_IdDelete.Text);  // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Operatiivmälu") // Kui Comboboxi väljal tekst võrdub sama, mis "Operatiivmälu".
            {
                Komponendid RamC = new Operatiivmälu(); // Klassi kutsumine.
                RamC.Kustutamine(tb_IdDelete.Text);  // Meetodi kutsumine.


            }
            else if (cb_Andmed.Text == "Optilised seadmed") // Kui Comboboxi väljal tekst võrdub sama, mis "Optilised seadmed".
            {
                Komponendid OpticalC = new OptilineSeade(); // Klassi kutsumine.
                OpticalC.Kustutamine(tb_IdDelete.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Kõvakettas") // Kui Comboboxi väljal tekst võrdub sama, mis "Kõvakettas".
            {
                Komponendid StorageC = new SailitusSeade(); // Klassi kutsumine.
                StorageC.Kustutamine(tb_IdDelete.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "Toiteplokk Võimsus") // Kui Comboboxi väljal tekst võrdub sama, mis "Toiteplokk Võimsus".
            {
                Komponendid TPC = new ToiteplokkVoimsus(); // Klassi kutsumine.
                TPC.Kustutamine(tb_IdDelete.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Kasutajad") // Kui Comboboxi väljal tekst võrdub sama, mis "Kasutajad".
            {
                Komponendid LoginC = new Login(); // Klassi kutsumine.
                LoginC.Kustutamine(tb_IdDelete.Text); // Meetodi kutsumine.
            }
            else // Muu.
            {
                return; // Tagastab.
            }
        }
        catch (Exception ex) // Püüab viga.
        {

            MessageBox.Show(ex.Message, "Viga!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Näitab viga MessageBoxis.
        }

    }

    private void UpdateData() // Meetod "UpdateData()"
    {

        try // Proovib
        {
            if (cb_Andmed.Text == "Intel Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "Intel Protsessor".
            {
                Komponendid IntelC = new IntelProtessor(); // Klassi kutsumine.
                IntelC.Uuendamine(cb_Veerud.Text, cb_Id.Text, tb_Muutmine.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "AMD Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Protsessor".
            {
                Komponendid AmdC = new AmdProtsessor(); // Klassi kutsumine.
                AmdC.Uuendamine(cb_Veerud.Text, cb_Id.Text, tb_Muutmine.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "AMD Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Videokaart".
            {
                Komponendid AmdGpuC = new AmdVideokaart(); // Klassi kutsumine.
                AmdGpuC.Uuendamine(cb_Veerud.Text, cb_Id.Text, tb_Muutmine.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Nvidia Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "Nvidia Videokaart".
            {
                Komponendid NvidiaC = new NvidiaVideokaart(); // Klassi kutsumine.
                NvidiaC.Uuendamine(cb_Veerud.Text, cb_Id.Text, tb_Muutmine.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "Operatiivmälu") // Kui Comboboxi väljal tekst võrdub sama, mis "Operatiivmälu".
            {
                Komponendid RamC = new Operatiivmälu(); // Klassi kutsumine.
                RamC.Uuendamine(cb_Veerud.Text, cb_Id.Text, tb_Muutmine.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Optilised seadmed") // Kui Comboboxi väljal tekst võrdub sama, mis "Optilised seadmed".
            {
                Komponendid OpticalC = new OptilineSeade(); // Klassi kutsumine.
                OpticalC.Uuendamine(cb_Veerud.Text, cb_Id.Text, tb_Muutmine.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Kõvakettas") // Kui Comboboxi väljal tekst võrdub sama, mis "Kõvakettas".
            {
                Komponendid StorageC = new SailitusSeade(); // Klassi kutsumine.
                StorageC.Uuendamine(cb_Veerud.Text, cb_Id.Text, tb_Muutmine.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Toiteplokk Võimsus") // Kui Comboboxi väljal tekst võrdub sama, mis "Toiteplokk Võimsus".
            {
                Komponendid TPC = new ToiteplokkVoimsus(); // Klassi kutsumine.
                TPC.Uuendamine(cb_Veerud.Text, cb_Id.Text, tb_Muutmine.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Kasutajad") // Kui Comboboxi väljal tekst võrdub sama, mis "Kasutajad".
            {
                Komponendid LoginC = new Login(); // Klassi kutsumine.
                LoginC.Uuendamine(cb_Veerud.Text, cb_Id.Text, tb_Muutmine.Text); // Meetodi kutsumine.

            }
            else // Muu.
            {
                return; // Tagastab.
            }
        }
        catch (Exception ex) // Püüab viga.
        {

            MessageBox.Show(ex.Message, "Viga!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Näitab viga MessageBoxis.
        }


    }

    private void InsertColumn() // Meetod "InsertColumn()"
    {
        try // Proovib
        {
            if (cb_Andmed.Text == "Intel Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "Intel Protsessor".
            {
                Komponendid IntelC = new IntelProtessor(); // Klassi kutsumine.
                IntelC.LisaVeergM(tb_VeergNimi.Text, cb_SqlMuutujad.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "AMD Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Protsessor".
            {
                Komponendid AmdC = new AmdProtsessor(); // Klassi kutsumine.
                AmdC.LisaVeergM(tb_VeergNimi.Text, cb_SqlMuutujad.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "AMD Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Videokaart".
            {
                Komponendid AmdGpuC = new AmdVideokaart(); // Klassi kutsumine.
                AmdGpuC.LisaVeergM(tb_VeergNimi.Text, cb_SqlMuutujad.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Nvidia Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "Nvidia Videokaart".
            {
                Komponendid NvidiaC = new NvidiaVideokaart(); // Klassi kutsumine.
                NvidiaC.LisaVeergM(tb_VeergNimi.Text, cb_SqlMuutujad.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "Operatiivmälu") // Kui Comboboxi väljal tekst võrdub sama, mis "Operatiivmälu".
            {
                Komponendid RamC = new Operatiivmälu(); // Klassi kutsumine.
                RamC.LisaVeergM(tb_VeergNimi.Text, cb_SqlMuutujad.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Optilised seadmed") // Kui Comboboxi väljal tekst võrdub sama, mis "Optilised seadmed".
            {
                Komponendid OpticalC = new OptilineSeade(); // Klassi kutsumine.
                OpticalC.LisaVeergM(tb_VeergNimi.Text, cb_SqlMuutujad.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Kõvakettas") // Kui Comboboxi väljal tekst võrdub sama, mis "Kõvakettas".
            {
                Komponendid StorageC = new SailitusSeade(); // Klassi kutsumine.
                StorageC.LisaVeergM(tb_VeergNimi.Text, cb_SqlMuutujad.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Toiteplokk Võimsus") // Kui Comboboxi väljal tekst võrdub sama, mis "Toiteplokk Võimsus".
            {
                Komponendid TPC = new ToiteplokkVoimsus(); // Klassi kutsumine.
                TPC.LisaVeergM(tb_VeergNimi.Text, cb_SqlMuutujad.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Kasutajad") // Kui Comboboxi väljal tekst võrdub sama, mis "Kasutajad".
            {
                Komponendid LoginC = new Login(); // Klassi kutsumine.
                LoginC.LisaVeergM(tb_VeergNimi.Text, cb_SqlMuutujad.Text); // Meetodi kutsumine.

            }
            else // Muu.
            {
                return; // Tagastab.
            }
        }
        catch (Exception ex) // Püüab viga.
        {

            MessageBox.Show(ex.Message, "Viga!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Näitab viga MessageBoxis.
        }

    }
    private void DeleteColumn() // Meetod "DeleteColumn()"
    {
        try // Proovib
        {
            if (cb_Andmed.Text == "Intel Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "Intel Protsessor".
            {
                Komponendid IntelC = new IntelProtessor(); // Klassi kutsumine.
                IntelC.KustutaVeergM(cb_KustutaVeerg.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "AMD Protsessor") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Protsessor".
            {
                Komponendid AmdC = new AmdProtsessor(); // Klassi kutsumine.
                AmdC.KustutaVeergM(cb_KustutaVeerg.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "AMD Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "AMD Videokaart".
            {
                Komponendid AmdGpuC = new AmdVideokaart(); // Klassi kutsumine.
                AmdGpuC.KustutaVeergM(cb_KustutaVeerg.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "Nvidia Videokaart") // Kui Comboboxi väljal tekst võrdub sama, mis "Nvidia Videokaart".
            {
                Komponendid NvidiaC = new NvidiaVideokaart(); // Klassi kutsumine.
                NvidiaC.KustutaVeergM(cb_KustutaVeerg.Text); // Meetodi kutsumine.
            }
            else if (cb_Andmed.Text == "Operatiivmälu") // Kui Comboboxi väljal tekst võrdub sama, mis "Operatiivmälu".
            {
                Komponendid RamC = new Operatiivmälu(); // Klassi kutsumine.
                RamC.KustutaVeergM(cb_KustutaVeerg.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Optilised seadmed") // Kui Comboboxi väljal tekst võrdub sama, mis "Optilised seadmed".
            {
                Komponendid OpticalC = new OptilineSeade(); // Klassi kutsumine.
                OpticalC.KustutaVeergM(cb_KustutaVeerg.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Kõvakettas") // Kui Comboboxi väljal tekst võrdub sama, mis "Kõvakettas".
            {
                Komponendid StorageC = new SailitusSeade(); // Klassi kutsumine.
                StorageC.KustutaVeergM(cb_KustutaVeerg.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Toiteplokk Võimsus") // Kui Comboboxi väljal tekst võrdub sama, mis "Toiteplokk Võimsus".
            {
                Komponendid TPC = new ToiteplokkVoimsus(); // Klassi kutsumine.
                TPC.KustutaVeergM(cb_KustutaVeerg.Text); // Meetodi kutsumine.

            }
            else if (cb_Andmed.Text == "Kasutajad") // Kui Comboboxi väljal tekst võrdub sama, mis "Kasutajad".
            {
                Komponendid LoginC = new Login(); // Klassi kutsumine.
                LoginC.KustutaVeergM(cb_KustutaVeerg.Text); // Meetodi kutsumine.

            }
            else // Muu.
            {
                return; // Tagastab.
            }
        }
        catch (Exception ex) // Püüab viga.
        {

            MessageBox.Show(ex.Message, "Viga!", MessageBoxButtons.OK, MessageBoxIcon.Error); // Näitab viga MessageBoxis.
        }

    }

    private void AdminForm_FormClosing(object sender, FormClosingEventArgs e) // Formi sulgemise sündmus.
    {
        Application.Exit(); // Rakenduse sulgemine.
    }

    private void btn_Vajuta_Click(object sender, EventArgs e) // Vajuta sündmus.
    {
        ShowData(); // Meetod "ShowData()".
    }

    private void btn_Sisesta_Click(object sender, EventArgs e) // Sisesta sündmus.
    {
        InsertData(); // Meetod "InsertData()".
        ShowData(); // Meetod "ShowData()".
    }

    private void AdminForm_Load(object sender, EventArgs e) // Formi laadimise sündmus.
    {
        SqlMuutujadClass SqlC = new SqlMuutujadClass(); // Klassi kutsumine.
        cb_SqlMuutujad.Items.AddRange(SqlC.SqlMuutujad()); // Meetodi kutsumine.
    }

    private void btn_Kustuta_Click(object sender, EventArgs e) // Kustuta sündmus.
    {
        DeleteData(); // Meetod "DeleteData()".
        ShowData(); // Meetod "ShowData()".
    }

    private void btn_Tagasi_Click(object sender, EventArgs e) // Tagasi sündmus.
    {
        this.Hide(); // Peidab Login formi.
        ToiteplokkForm toiteF = new ToiteplokkForm(); // Kutsume välja Toiteplokk formi.
        toiteF.Show(); // Avab akna
    }


    private void btn_Muuda_Click(object sender, EventArgs e) // Muuda sündmus.
    {
        UpdateData(); // Meetod "UpdateData()".
        ShowData(); // Meetod "ShowData()".
    }

    private void btn_LisaVeerg_Click(object sender, EventArgs e) // Lisa Veerg sündmus.
    {
        InsertColumn(); // Meetod "InsertColumn()".
        ShowData(); // Meetod "ShowData()".
    }

    private void btn_KustutaVeerg_Click(object sender, EventArgs e) // Kustuta Veerg sündmus.
    {
        DeleteColumn(); // Meetod "DeleteColumn()".
        ShowData(); // Meetod "ShowData()".
    }
}
}
