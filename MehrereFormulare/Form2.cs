using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehrereFormulare
{
    public partial class Form2 : Form
    {
        private Form1 hauptFormular;
        public Form2(Form1 aufrufer)
        {
            hauptFormular = aufrufer;
            // hauptFormular.Hide();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtUnter.Text = hauptFormular.Controls["txtHaupt"].Text;
            CheckBox chkHaupt = hauptFormular.Controls["chkHaupt"] as CheckBox;
            chkUnter.Checked = chkHaupt.Checked;
        }

        private void btnEndeUnter_Click(object sender, EventArgs e)
        {
            hauptFormular.Controls["txtHaupt"].Text = txtUnter.Text;
            CheckBox chkHaupt = hauptFormular.Controls["chkHaupt"] as CheckBox;
            chkHaupt.Checked = chkUnter.Checked;
            // hauptFormular.Show();
            Close();
        }
    }
}
