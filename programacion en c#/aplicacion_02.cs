namespace Aolicacion_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = textNombre.Text + " es el nombre, Hola!!!";
        }


    }
}