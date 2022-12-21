using System;
using System.Data;
using System.Reflection.Emit;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsMySql
{
    public partial class ViewForm : Form
    {
        private string parametr;
        public ViewForm()
        {
            InitializeComponent();
        }

        private string connectionstring = "host=localhost;user=Monitor;password=123123123;database=mydb";

        public DataSet SelectRows(DataSet dataset, string connection, string query)
        {
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(query, conn);
            adapter.Fill(dataset);
            return dataset;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query;
            DataSet ds = new DataSet();
            if (comboBoxSelectParametr.SelectedIndex == -1)
            {
                MessageBox.Show("выберите параметр!");
                textBoxSearch.Text = null;
            }
            else
            {
                switch (comboBox1.SelectedIndex)
                {
                    case -1:
                        MessageBox.Show("Выберите параметр!");
                        textBoxSearch.Text = null;
                        break;
                    case 0:
                        label1.Text = "Введите должность работника";
                        query = "select *\r\nfrom instructors as i\r\njoin administration as a on a.admid = i.administratorsfk where i.post like '" + textBoxSearch.Text + "';";
                        dataGridView1.DataSource = SelectRows(ds, connectionstring, query).Tables[0];
                        break;
                    case 1:
                        query = "select lesstype as ВидУрока, lessdate as ДатаУрока, s.lastname as ФамилияСтудента, s.firstname as ИмяСтудента, s.patronymic as ОтчествоСтудента, g.groupname as Группа, i.lastname as ИмяИнструктора, i.firstname as ФамилияИнструктора, i.patronymic as ОтчествоИнструктора, c.vendor as МаркаАвто, c.model as МодельАвто," +
                            " c.regnumb as ГосНомер, c.regnumbreg as Регион\r\nfrom lesinf as l\r\njoin student as s on student_StID = StID\r\njoin groupss as g on student_groupfk = groupid\r\njoin instructors" +
                            " as i on instructors_mpovid = mpovid\r\njoin cars as c on instructors_carfk = carid\r\nwhere " + parametr + " like \"" + textBoxSearch.Text + "\";";
                        dataGridView1.DataSource = SelectRows(ds, connectionstring, query).Tables[0];
                        break;
                    case 2:
                        query = "select vendor as Производитель, model as Модель, btdate as ГодВыпуска, transmission as КПП, engcap as Объем, wheelloc as ПоложРуля, doornumb as ЧислоДверей, regnumb as ГосНомер, regnumbreg as Регион\r\nfrom cars where " + parametr + " like \"" + textBoxSearch.Text + "\";";
                        dataGridView1.DataSource = SelectRows(ds, connectionstring, query).Tables[0];
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("stop");
                    break;
                case 0:
                    comboBoxSelectParametr.Items.Clear();
                    comboBoxSelectParametr.Items.Add("Должность");
                    break;
                case 1:
                    comboBoxSelectParametr.Enabled = true;
                    comboBoxSelectParametr.Items.Clear();
                    comboBoxSelectParametr.Items.Add("Тип занятия");
                    comboBoxSelectParametr.Items.Add("Фамилия ученика");
                    comboBoxSelectParametr.Items.Add("Фамилия инструктора");
                    comboBoxSelectParametr.Items.Add("Гос номер авто");
                    break;
                case 2:
                    comboBoxSelectParametr.Enabled = true;
                    comboBoxSelectParametr.Items.Clear();
                    comboBoxSelectParametr.Items.Add("Модель");
                    comboBoxSelectParametr.Items.Add("Трансмиссия");
                    comboBoxSelectParametr.Items.Add("Гос номер");
                    break;
            }
        }

        private void comboBoxSelectParametr_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Ошибка");
                    break;
                    break;
                case 1:
                    switch (comboBoxSelectParametr.SelectedIndex)
                    {
                        case 0:
                            parametr = null;
                            parametr = "l.lesstype";
                            break;
                        case 1:
    
                            parametr = null;
                            parametr = "s.lastname";
                            break;
                        case 2:
                                
                            parametr = null;
                            parametr = "i.lastname";
                            break;
                        case 3:
                            parametr = null;
                            parametr = "c.regnumb";
                            break;

                    }
                    break;
                case 2:
                    switch (comboBoxSelectParametr.SelectedIndex)
                    {
                        case 0:
                            parametr = null;
                            parametr = "model";
                            break;
                        case 1:
                            parametr = null;
                            parametr = "transmission";
                            break;
                        case 2:
                            parametr = null;
                            parametr = "regnumb";
                            break;
                    }
                    break;
            }
        }
    }
} 
