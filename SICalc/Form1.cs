namespace SICalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SICalcClass si = new SICalcClass(); 
            si.P = Double.Parse(textBox1.Text);
            si.R = Double.Parse(textBox2.Text);
            si.T = int.Parse(textBox3.Text);

            MessageBox.Show("SI is " + si.getSI(), "SI");
        }
    }
}