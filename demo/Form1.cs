namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Hello");
            this.label1.Text = "Hello demo How are you";
        }
    }
}