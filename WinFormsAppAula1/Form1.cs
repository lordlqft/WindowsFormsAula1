namespace WinFormsAppAula1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {

        }

        private void btnMessage_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "2";
        }
    }
}
