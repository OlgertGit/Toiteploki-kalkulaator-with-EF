using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToiteplokkKalkulaator
{
public partial class InfoForm : Form
{
    public InfoForm() // Formi meetod.
    {
        InitializeComponent(); // Disaini meetodid.
    }

    private void btn_Exit_Click(object sender, EventArgs e) // Formi sulgemine meetod.
    {
        this.Close(); // Akna sulgemine.
    }
}
}
