namespace WinAppTestandoExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iConta = 0;

            try
            { 
                //for�a erro
                iConta = iConta / 0;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Erro Exe��o", MessageBoxButtons.OK);
            }          

        }
    }
}