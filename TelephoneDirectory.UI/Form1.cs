namespace TelephoneDirectory.UI
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer.BLL bll;
        public Form1()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int returnValue =  bll.SystemControl(txt_username.Text,txt_password.Text);
            if (returnValue>0)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Hatalý kullanýcý adý veya þifre","Uyarý",MessageBoxButtons.OK);
            }
        }
    }
}
