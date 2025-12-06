namespace Tema2_3_2EntornosJoseGMarquezG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste = 0.0;

            textoTelegrama = richTextBox1.Text;
            //ALOGUNOS CAMBIOS AQUI

            if (checkBoxUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else
            {
                tipoTelegrama = 'o';
            }

            string textoLimpio = textoTelegrama.Trim();

            string[] palabras = textoLimpio.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            numPalabras = palabras.Length;

            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            textBoxCoste.Text = coste.ToString("N2") + " euros";
        }
    }
}