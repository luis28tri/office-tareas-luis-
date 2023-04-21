namespace aplicacion_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lBLMesanje.Text = "hola a todos!";
        }

        private void btnDespedida_Click(object sender, EventArgs e)
        {
            lBLMesanje.Text = "Adios!";
            this.Text = "BYE!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lBLMesanje.Text = "";
        }
    }
}