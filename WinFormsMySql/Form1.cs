using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMySql
{
    public partial class FormSearch : Form
    {
        public static string ColumnString, SearchString;
        public FormSearch()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(FormSearch_Closing);
        }

        void FormSearch_Closing(object sender, CancelEventArgs e)

        {
            if (true && (string.Equals(textBoxPwd.Text, "monitor") == false || string.Equals(textBoxPwd.Text, "manager") == false))
            {
                Application.Exit();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBoxSelectUser.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Выберите пользователя!");
                    break;
                case 0:
                    if (textBoxPwd.Text == "manager")
                    {
                        FormOpenManager();
                    }
                    else
                    {
                        MessageBox.Show("Пароль неверный!");
                    }
                    break;
                case 1:
                    if (textBoxPwd.Text == "monitor")
                    {
                        FormOpenMonitor();
                    }
                    else
                    {
                        MessageBox.Show("Пароль неверный!");
                    }
                    break;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void FormOpenMonitor()
        {
            MessageBox.Show("Вход выполнен");
            SelectForm selectForm = new SelectForm();
            selectForm.button1.Enabled=false;
            selectForm.ShowDialog();
        }

        private void FormOpenManager()
        {
            MessageBox.Show("Вход выполнен");
            SelectForm selectForm = new SelectForm();
            selectForm.ShowDialog();
        }
    }
}
