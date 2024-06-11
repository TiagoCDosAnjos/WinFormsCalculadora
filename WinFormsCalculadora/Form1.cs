namespace WinFormsCalculadora
{
    public partial class Form1 : Form
    {
        double resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbSomar.Checked)
            {
                resultado = double.Parse(tbNumero1.Text) + double.Parse(tbNumero2.Text);
            }

            if (rbSubtrair.Checked)
            {
                resultado = double.Parse(tbNumero1.Text) - double.Parse(tbNumero2.Text);
            }

            if (rbMultiplicar.Checked)
            {
                resultado = double.Parse(tbNumero1.Text) * double.Parse(tbNumero2.Text);
            }

            if (rbDividir.Checked)
            {
                resultado = double.Parse(tbNumero1.Text) / double.Parse(tbNumero2.Text);
            }

            listBoxResultados.Items.Add(resultado);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();
            tbNumero1.Clear();
            tbNumero2.Clear();
        }
    }
}
