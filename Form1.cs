namespace CursoProgramacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoPeso = txtPeso.Text;
            double peso = double.Parse(textoPeso);

            string textoAltura = txtAltura.Text;
            double altura = double.Parse(textoAltura);

            double imc = peso / (altura * altura); // formula IMC

            lblIMC.Text = imc.ToString("F2"); // F2 sirve para limitar 2 decimales después de la coma
        }
    }
}
