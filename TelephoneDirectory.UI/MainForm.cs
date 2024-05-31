using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneDirectory.Entities;

namespace TelephoneDirectory.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RecordList();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        // her seferinde bll çağırılıyor

        private void btn_addrecord_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            int returnValue = bll.AddRecord(txt_name.Text, txt_surname.Text, txt_phoneI.Text, txt_phoneII.Text, txt_phoneIII.Text, txt_email.Text, txt_address.Text, txt_webaddress.Text, txt_description.Text);
            if (returnValue > 0)
            {
                MessageBox.Show("Yeni kayıt eklendi");
                RecordList();
            }
            else
            {
                MessageBox.Show("İsim, soyisim, ve telefon numarası bilgilerini eksizsiz doldurun");

            }
        }

        private void btn_updaterecord_Click(object sender, EventArgs e)

        {
            if (!string.IsNullOrEmpty(txt_name_alt.Text)&& !string.IsNullOrEmpty(txt_surname_alt.Text) && !string.IsNullOrEmpty(txt_phoneI_alt.Text))
            {
                Guid id = ((PhoneDirectory)lst_list.SelectedItem).ID;

                BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
                int returnValue = bll.UpdateRecord(id, txt_name_alt.Text, txt_surname_alt.Text, txt_phoneI_alt.Text, txt_phoneII_alt.Text, txt_phoneIII_alt.Text, txt_email_alt.Text, txt_address_alt.Text, txt_address_alt.Text, txt_description_alt.Text);
                if (returnValue > 0)
                {
                    MessageBox.Show("Yeni kayıt eklendi");
                    RecordList();

                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("İsim, soyisim, ve telefon numarası bilgilerini eksizsiz doldurun");

            }
        }

        private void btn_deleterecord_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            Guid id = ((PhoneDirectory)lst_list.SelectedItem).ID;
            int result = bll.DeleteRecord(id);

            if (result>0)
            {
                MessageBox.Show("Kayıt silindi");
                RecordList();
            }
            else
            {
                MessageBox.Show("Kayıt silinme aşamasında hata meydana geldi");

            }
        }

        private void RecordList()
        {
            BusinessLogicLayer.BLL bll = new BusinessLogicLayer.BLL();
            List<PhoneDirectory> records = bll.RecordList();
            if (records != null)
            {
                lst_list.DataSource = records;
            }
            else
            {

                MessageBox.Show("Liste boş veya başka bir sıkıntı oldu");

            }

        }

        private void lst_list_DoubleClick(object sender, EventArgs e)
        {
            if (lst_list!=null)
            {
                PhoneDirectory phoneDirectory = (PhoneDirectory)lst_list.SelectedItem;
                txt_address_alt.Text = phoneDirectory.address;
                txt_description_alt.Text = phoneDirectory.description;
                txt_email_alt.Text = phoneDirectory.emailAddress;
                txt_name_alt.Text = phoneDirectory.name;
                txt_phoneI_alt.Text = phoneDirectory.phoneNumberI;
                txt_phoneII_alt.Text = phoneDirectory.phoneNumberII;
                txt_phoneIII_alt.Text = phoneDirectory.phoneNumberIII;
                txt_surname_alt.Text = phoneDirectory.surname;
                txt_webadress_alt.Text = phoneDirectory.webAddress;
                txt_description_alt.Text = phoneDirectory.description;
            }

        }
    }
}
