namespace Aplicacion_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hola a todos");
            //MessageBox.Show("hola a todos", " Mi MessageBox");
            DialogResult r =MessageBox.Show("probamos botones  ", " diferentes botones", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
            if (r == DialogResult.Abort)
                lblMensaje.Text = "Anular";
            if(r== DialogResult.Retry)
                lblMensaje.Text = "Reintentar";
            if (r == DialogResult.Ignore)
                lblMensaje.Text = "Omitir";



        }
    }
}