namespace MehrereFormulare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartUnter_Click(object sender, EventArgs e)
        {
            Form2 fu = new Form2(this);
            fu.ShowDialog();
            // Close();
        }

        private void btnEndeHaupt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}