namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void ShowAboutProgram()
        {
            MessageBox.Show("This is a sample WinForms application.", "About Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
