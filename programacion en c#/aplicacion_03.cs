namespace Aplicacion_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtA.Text = "0";
            txtB.Text = "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);

            double R = A + B;
            lblResultado.Text = R.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);

            double R = A - B;
            lblResultado.Text = R.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);

            double R = A * B;
            lblResultado.Text = R.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);

            double R = A / B;
            lblResultado.Text = R.ToString();
        }
    }
}