namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void müþterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            frm.MdiParent = this;
            frm.Show();
            
        }
    }
}
