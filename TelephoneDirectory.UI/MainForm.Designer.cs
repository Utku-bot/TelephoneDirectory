namespace TelephoneDirectory.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lst_list = new ListBox();
            groupBox2 = new GroupBox();
            btn_addrecord = new Button();
            label6 = new Label();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label2 = new Label();
            label7 = new Label();
            label4 = new Label();
            label1 = new Label();
            txt_webaddress = new TextBox();
            txt_email = new TextBox();
            txt_description = new TextBox();
            txt_address = new TextBox();
            txt_phoneI = new TextBox();
            txt_phoneIII = new TextBox();
            txt_phoneII = new TextBox();
            txt_surname = new TextBox();
            txt_name = new TextBox();
            groupBox3 = new GroupBox();
            btn_deleterecord = new Button();
            label18 = new Label();
            btn_updaterecord = new Button();
            label17 = new Label();
            txt_description_alt = new TextBox();
            label16 = new Label();
            txt_name_alt = new TextBox();
            label15 = new Label();
            txt_surname_alt = new TextBox();
            label14 = new Label();
            txt_phoneII_alt = new TextBox();
            label13 = new Label();
            txt_phoneIII_alt = new TextBox();
            label12 = new Label();
            txt_phoneI_alt = new TextBox();
            label11 = new Label();
            txt_address_alt = new TextBox();
            label10 = new Label();
            txt_email_alt = new TextBox();
            txt_webadress_alt = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lst_list);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Liste";
            // 
            // lst_list
            // 
            lst_list.FormattingEnabled = true;
            lst_list.ItemHeight = 15;
            lst_list.Location = new Point(6, 13);
            lst_list.Name = "lst_list";
            lst_list.Size = new Size(233, 409);
            lst_list.TabIndex = 0;
            lst_list.DoubleClick += lst_list_DoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_addrecord);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_webaddress);
            groupBox2.Controls.Add(txt_email);
            groupBox2.Controls.Add(txt_description);
            groupBox2.Controls.Add(txt_address);
            groupBox2.Controls.Add(txt_phoneI);
            groupBox2.Controls.Add(txt_phoneIII);
            groupBox2.Controls.Add(txt_phoneII);
            groupBox2.Controls.Add(txt_surname);
            groupBox2.Controls.Add(txt_name);
            groupBox2.Location = new Point(263, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(525, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yeni Kayıt Ekleme İşlemi";
            // 
            // btn_addrecord
            // 
            btn_addrecord.Location = new Point(15, 179);
            btn_addrecord.Name = "btn_addrecord";
            btn_addrecord.Size = new Size(244, 23);
            btn_addrecord.TabIndex = 2;
            btn_addrecord.Text = "Yeni Kayıt Oluştur";
            btn_addrecord.UseVisualStyleBackColor = true;
            btn_addrecord.Click += btn_addrecord_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(222, 106);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 1;
            label6.Text = "Web Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 106);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 1;
            label3.Text = "Email Adres";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(422, 27);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 1;
            label9.Text = "Açıklama";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 143);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 1;
            label8.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 69);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 1;
            label5.Text = "TelefonIII";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyisim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 138);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 1;
            label7.Text = "TelefonI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 30);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 1;
            label4.Text = "TelefonII";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "İsim";
            // 
            // txt_webaddress
            // 
            txt_webaddress.Location = new Point(295, 98);
            txt_webaddress.Name = "txt_webaddress";
            txt_webaddress.Size = new Size(100, 23);
            txt_webaddress.TabIndex = 0;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(100, 103);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(100, 23);
            txt_email.TabIndex = 0;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(419, 45);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(100, 141);
            txt_description.TabIndex = 0;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(295, 127);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(100, 59);
            txt_address.TabIndex = 0;
            // 
            // txt_phoneI
            // 
            txt_phoneI.Location = new Point(100, 135);
            txt_phoneI.Name = "txt_phoneI";
            txt_phoneI.Size = new Size(100, 23);
            txt_phoneI.TabIndex = 0;
            // 
            // txt_phoneIII
            // 
            txt_phoneIII.Location = new Point(295, 69);
            txt_phoneIII.Name = "txt_phoneIII";
            txt_phoneIII.Size = new Size(100, 23);
            txt_phoneIII.TabIndex = 0;
            txt_phoneIII.TextChanged += textBox5_TextChanged;
            // 
            // txt_phoneII
            // 
            txt_phoneII.Location = new Point(295, 27);
            txt_phoneII.Name = "txt_phoneII";
            txt_phoneII.Size = new Size(100, 23);
            txt_phoneII.TabIndex = 0;
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(100, 69);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(100, 23);
            txt_surname.TabIndex = 0;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(100, 32);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_deleterecord);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(btn_updaterecord);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(txt_description_alt);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(txt_name_alt);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txt_surname_alt);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txt_phoneII_alt);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txt_phoneIII_alt);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txt_phoneI_alt);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txt_address_alt);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txt_email_alt);
            groupBox3.Controls.Add(txt_webadress_alt);
            groupBox3.Location = new Point(263, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(525, 208);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Seçili Olan Kaydı Güncelle / Sil ";
            // 
            // btn_deleterecord
            // 
            btn_deleterecord.Location = new Point(143, 172);
            btn_deleterecord.Name = "btn_deleterecord";
            btn_deleterecord.Size = new Size(122, 23);
            btn_deleterecord.TabIndex = 2;
            btn_deleterecord.Text = "Sil";
            btn_deleterecord.UseVisualStyleBackColor = true;
            btn_deleterecord.Click += btn_deleterecord_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(222, 98);
            label18.Name = "label18";
            label18.Size = new Size(64, 15);
            label18.TabIndex = 1;
            label18.Text = "Web Adres";
            // 
            // btn_updaterecord
            // 
            btn_updaterecord.Location = new Point(15, 172);
            btn_updaterecord.Name = "btn_updaterecord";
            btn_updaterecord.Size = new Size(122, 23);
            btn_updaterecord.TabIndex = 2;
            btn_updaterecord.Text = "Kayıt Güncelle";
            btn_updaterecord.UseVisualStyleBackColor = true;
            btn_updaterecord.Click += btn_updaterecord_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 98);
            label17.Name = "label17";
            label17.Size = new Size(69, 15);
            label17.TabIndex = 1;
            label17.Text = "Email Adres";
            // 
            // txt_description_alt
            // 
            txt_description_alt.Location = new Point(419, 37);
            txt_description_alt.Multiline = true;
            txt_description_alt.Name = "txt_description_alt";
            txt_description_alt.Size = new Size(100, 141);
            txt_description_alt.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(422, 19);
            label16.Name = "label16";
            label16.Size = new Size(56, 15);
            label16.TabIndex = 1;
            label16.Text = "Açıklama";
            // 
            // txt_name_alt
            // 
            txt_name_alt.Location = new Point(100, 24);
            txt_name_alt.Name = "txt_name_alt";
            txt_name_alt.Size = new Size(100, 23);
            txt_name_alt.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(222, 135);
            label15.Name = "label15";
            label15.Size = new Size(37, 15);
            label15.TabIndex = 1;
            label15.Text = "Adres";
            // 
            // txt_surname_alt
            // 
            txt_surname_alt.Location = new Point(100, 61);
            txt_surname_alt.Name = "txt_surname_alt";
            txt_surname_alt.Size = new Size(100, 23);
            txt_surname_alt.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(222, 61);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 1;
            label14.Text = "TelefonIII";
            // 
            // txt_phoneII_alt
            // 
            txt_phoneII_alt.Location = new Point(295, 19);
            txt_phoneII_alt.Name = "txt_phoneII_alt";
            txt_phoneII_alt.Size = new Size(100, 23);
            txt_phoneII_alt.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 61);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 1;
            label13.Text = "Soyisim";
            // 
            // txt_phoneIII_alt
            // 
            txt_phoneIII_alt.Location = new Point(295, 61);
            txt_phoneIII_alt.Name = "txt_phoneIII_alt";
            txt_phoneIII_alt.Size = new Size(100, 23);
            txt_phoneIII_alt.TabIndex = 0;
            txt_phoneIII_alt.TextChanged += textBox5_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 130);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 1;
            label12.Text = "TelefonI";
            // 
            // txt_phoneI_alt
            // 
            txt_phoneI_alt.Location = new Point(100, 127);
            txt_phoneI_alt.Name = "txt_phoneI_alt";
            txt_phoneI_alt.Size = new Size(100, 23);
            txt_phoneI_alt.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(222, 22);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 1;
            label11.Text = "TelefonII";
            // 
            // txt_address_alt
            // 
            txt_address_alt.Location = new Point(295, 119);
            txt_address_alt.Multiline = true;
            txt_address_alt.Name = "txt_address_alt";
            txt_address_alt.Size = new Size(100, 59);
            txt_address_alt.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 27);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 1;
            label10.Text = "İsim";
            // 
            // txt_email_alt
            // 
            txt_email_alt.Location = new Point(100, 95);
            txt_email_alt.Name = "txt_email_alt";
            txt_email_alt.Size = new Size(100, 23);
            txt_email_alt.TabIndex = 0;
            // 
            // txt_webadress_alt
            // 
            txt_webadress_alt.Location = new Point(295, 90);
            txt_webadress_alt.Name = "txt_webadress_alt";
            txt_webadress_alt.Size = new Size(100, 23);
            txt_webadress_alt.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Telefon Rehberi ";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lst_list;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label3;
        private Label label8;
        private Label label5;
        private Label label2;
        private Label label7;
        private Label label4;
        private Label label1;
        private TextBox txt_webaddress;
        private TextBox txt_email;
        private TextBox txt_address;
        private TextBox txt_phoneI;
        private TextBox txt_phoneIII;
        private TextBox txt_phoneII;
        private TextBox txt_surname;
        private TextBox txt_name;
        private Button btn_addrecord;
        private Label label9;
        private TextBox txt_description;
        private Button btn_updaterecord;
        private Button btn_deleterecord;
        private Label label18;
        private Label label17;
        private TextBox txt_description_alt;
        private Label label16;
        private TextBox txt_name_alt;
        private Label label15;
        private TextBox txt_surname_alt;
        private Label label14;
        private TextBox txt_phoneII_alt;
        private Label label13;
        private TextBox txt_phoneIII_alt;
        private Label label12;
        private TextBox txt_phoneI_alt;
        private Label label11;
        private TextBox textBox6;
        private Label label10;
        private TextBox txt_email_alt;
        private TextBox txt_webadress_alt;
        private TextBox txt_address_alt;
    }
}