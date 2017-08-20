using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToiteplokkKalkulaator.Klassid;

namespace ToiteplokkKalkulaator
{
public partial class LoginForm : Form
{
    public LoginForm() // Formi meetod.
    {
        InitializeComponent(); // Disaini meetodid.
    }

    private void btn_Vajuta_Click(object sender, EventArgs e) // Nuppu vajutamise meetod.
    {

        Login loginC = new Login(); // Kutsume välja Login klassi.
        loginC.Sisselogimine(tb_Login.Text, tb_Password.Text); // Kutsume välja LoginO meetodi.
        lbl_Access.Text = loginC.Access; // Kutsume välja Access meetodi.
        lbl_Access.ForeColor = System.Drawing.Color.Red; // Muudab fonti värvi punaseks.
        if (lbl_Access.Text == "") // Kui logimine õnnestus, siis Login form kaob.
        {
            Visible = false; // Ei ole nähtav.
        }
    }

    private void btn_Tagasi_Click(object sender, EventArgs e) // Nuppu vajutamise meetod.
    {
        this.Hide(); // Peidab Login formi.
        ToiteplokkForm toiteF = new ToiteplokkForm(); // Kutsume välja Toiteplokk formi.
        toiteF.Show(); // Avab akna
    }

    private void LoginForm_Load(object sender, EventArgs e) // Formi meetod.
    {
        ControlBox = false; // Võtab formilt märgid maha.
        ShowIcon = true; // Näitab ikoone.
        this.AcceptButton = btn_Vajuta; // Enteri vajutamine.
    }
}
}
