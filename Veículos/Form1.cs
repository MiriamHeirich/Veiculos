namespace Veículos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeFotosDosCarros = Directory.GetFiles(@"C:\Users\Bsoft\source\repos\Veículos\Images");
                foreach (string img in nomeFotosDosCarros)
                             {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CHEVROLET") {
                comboBox2.Items.Add("Cruze");
                comboBox2.Items.Add("Tracker");

              
            }
            else if (comboBox1.Text == "FIAT")
            {
                comboBox2.Items.Clear();    
                comboBox2.Items.Add("Uno");
                comboBox2.Items.Add("Tipo");
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ka");
                comboBox2.Items.Add("EcoSport");
            }
        }
    }
}