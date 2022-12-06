namespace TesterSprawnosci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.optTest = new Form2(this);
            this.optTest.Show();
            MessageBox.Show("Po wćiśnięciu 'START' klikaj na pojawiające się czerwone kółko jak najszybciej. Po skończeniu testu pojawi się informacja o twoim wyniku.", "Informacja przed rozpoczęciem");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.akustTest = new Form3(this);
            this.akustTest.Show();
            MessageBox.Show("Twoim zadaniem jest po usłyszeniu specyficznego dźwięku wcisnąć przycisk jak najszybciej", "Informacja przed rozpoczęciem");
        }
    }
}