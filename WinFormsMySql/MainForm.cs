using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMySql.Interfaces;
using WinFormsMySql.Models;
using WinFormsMySql.Services;
using WinFormsMySql.Utils;

namespace WinFormsMySql
{
    public partial class MainForm : Form
    {
        //Переменные коннекторы для sql запроса
        public static string SearchString;
        public static string ColumnString;
        //Источник данных для DGV
        private static BindingSource _bindingsourceObject;
        //редактируемый сотрудник
        private static BindingSource _bindingourcesObjectCurrent;
        //работа с БД
        private static ITaskRepository _repo;

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            //Репозиторий базы данных
            _repo = new MySqlRepository();
            //Блокировка комбобоксов
            comboBoxSelectColumn.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectTable.DropDownStyle = ComboBoxStyle.DropDownList;
            groupBoxDocuments.Visible = false;
            _groupBoxEmployee.Visible = false;

            switch (comboBoxSelectTable.SelectedIndex)
            {
                case 0:
                    _dataGridViewSelecNow.MouseClick += (s, a) => SetCurrentAdmin();
                 
                    break;
                case 1:
                    _dataGridViewSelecNow.MouseClick += (s, a) => SetCurrentEmployee();
                    break;

            }
        }

        private void SetBindingsEmployee()
        {
            //Объект бс для возможности отображения
            _bindingsourceObject = new BindingSource();
            _bindingsourceObject.DataSource = typeof(List<Employee>);
            //привязки для DGV
            _dataGridViewSelecNow.AutoGenerateColumns = true;
            _dataGridViewSelecNow.DataSource = _bindingsourceObject;

            _bindingourcesObjectCurrent = new BindingSource();
            _bindingourcesObjectCurrent.DataSource = new List<Employee> { new Employee(0) };

            //Очистка тб для избежания возникновения ошибки
            _textBoxFirstName.DataBindings.Clear();
            _textBoxLastName.DataBindings.Clear();
            _textBoxPhone.DataBindings.Clear();
            _textBoxPassnumber.DataBindings.Clear();
            _textBoxIssued.DataBindings.Clear();
            _textBoxPasseria.DataBindings.Clear();
            _textBoxRegistration.DataBindings.Clear();
            _textBoxSex.DataBindings.Clear();
            _textBoxPatronymic.DataBindings.Clear();
            _textBoxBirthDate.DataBindings.Clear();
            _textBoxAdmFk.DataBindings.Clear();
            _textBoxPost.DataBindings.Clear();
            _textBoxCarfk.DataBindings.Clear();
            //Прикрепление данных к ТБ
            _textBoxFirstName.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.FirstName));
            _textBoxLastName.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.LastName));
            _textBoxPhone.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Number));
            _textBoxPatronymic.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Patronymic));
            _textBoxBirthDate.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Dtdate));
            _textBoxSex.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Sex));
            _textBoxPasseria.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Passeria));
            _textBoxPassnumber.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Passnumber));
            _textBoxIssued.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Issued));
            _textBoxRegistration.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Registration));
            _textBoxAdmFk.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Admfk));
            _textBoxPost.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Post)); 
            _textBoxCarfk.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Employee.Carfk));
        }

        private async Task SetBindingsAdministrator()
        {
            //Объект бс для возможности отображения
            _bindingsourceObject = new BindingSource();
            _bindingsourceObject.DataSource = typeof(List<Admins>);
            //привязки для DGV
            _dataGridViewSelecNow.AutoGenerateColumns = true;
            _dataGridViewSelecNow.DataSource = _bindingsourceObject;
            //Бинды
            _bindingourcesObjectCurrent = new BindingSource();
            _bindingourcesObjectCurrent.DataSource = new List<Admins> { new Admins(0) };
            //Очистка тб для избежания возникновения ошибки
            _textBoxFirstName.DataBindings.Clear();
            _textBoxLastName.DataBindings.Clear();
            _textBoxPhone.DataBindings.Clear();
            _textBoxPassnumber.DataBindings.Clear();
            _textBoxIssued.DataBindings.Clear();
            _textBoxPasseria.DataBindings.Clear();
            _textBoxRegistration.DataBindings.Clear();
            _textBoxSex.DataBindings.Clear();
            _textBoxPatronymic.DataBindings.Clear();
            _textBoxBirthDate.DataBindings.Clear();
            _textBoxAdmFk.DataBindings.Clear();
            _textBoxPost.DataBindings.Clear();
            //Прикрепление данных к ТБ
            _textBoxFirstName.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.FirstName));
            _textBoxLastName.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.LastName));
            _textBoxPhone.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.Number));
            _textBoxPatronymic.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.Patronymic));
            _textBoxBirthDate.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.Dtdate));
            _textBoxSex.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.Sex));
            _textBoxPasseria.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.Passeria));
            _textBoxPassnumber.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.Passnumber));
            _textBoxIssued.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.Issued));
            _textBoxRegistration.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.Registration));
            _textBoxPost.DataBindings.Add("Text", _bindingourcesObjectCurrent, nameof(Admins.Post));
        }

        private async void LoadDataAdministrator()
        {
            var result = await _repo.GetAdmins();
            await SetBindingsAdministrator();
            if (result)
            {
                //извлекаем
                List<Admins> admins = result.Value;
                //отображаем
                _bindingsourceObject.DataSource = admins;
                _bindingsourceObject.MoveFirst();
                SetCurrentAdmin();
            }
            else
            {
                MessageBox.Show(result.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadDataEmployee()
        {
            //асинхронный запрос в бд
            var result = await _repo.GetEmployee();
            //привязки для тб, дгв
            SetBindingsEmployee();
            if (result)
            {
                //извлекаем
                List<Employee> employee = result.Value;
                //отображаем
                _bindingsourceObject.DataSource = employee;
                _bindingsourceObject.MoveFirst();
                SetCurrentEmployee();
            }
            else
            {
                MessageBox.Show(result.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetCurrentEmployee()
        {
            if (_bindingsourceObject.Count > 0)
            {
                _bindingourcesObjectCurrent.List[0] = Employee.GetClone((Employee)_bindingsourceObject.Current);
                 
            }
            else
            {
                _bindingourcesObjectCurrent.List[0] = new Employee(0);
            }

            _bindingourcesObjectCurrent.ResetItem(0);
        }

        private void SetCurrentAdmin()
        {
            if (_bindingsourceObject.Count > 0)
            {
                _bindingourcesObjectCurrent.List[0] = Admins.GetClone((Admins)_bindingsourceObject.Current);

            }
            else
            {
                _bindingourcesObjectCurrent.List[0] = new Admins(0);
            }

            _bindingourcesObjectCurrent.ResetItem(0);
        }

        private void SwitchOnWaiting()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Enabled = false;
            }
            _dataGridViewSelecNow.Enabled = false;
            Cursor = Cursors.WaitCursor;
        }

        private void SwitchOffWaiting()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Enabled = true;
            }
            _dataGridViewSelecNow.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void _buttonAdd_Click(object sender, EventArgs e)
        {
            //курсор на последнего
            _bindingsourceObject.MoveLast();
            //добавляем нового

            switch (comboBoxSelectTable.SelectedIndex)
            {
                case 0:
                    _bindingsourceObject.Add(new Admins(0));
                    break;
                case 1:
                    _bindingsourceObject.Add(new Employee(0));
                    break;
            }
            //выделяем его
            _bindingsourceObject.MoveNext();
            SetCurrentEmployee();
            //выделяем имя для редактирования
            _textBoxFirstName.Focus();
        }

        private void textBoxSearchOnDb_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxSearchOnDb.Text, "^[a-zA-Z]") | System.Text.RegularExpressions.Regex.IsMatch(textBoxSearchOnDb.Text, "^[1-9]"))
            {
                MessageBox.Show("Не пытайтесь сломать программу");
                textBoxSearchOnDb.Text.Remove(textBoxSearchOnDb.Text.Length - 1);
                textBoxSearchOnDb.Text = null;
            }
            else
            {
                SearchString = ("'" + textBoxSearchOnDb.Text.ToString() + "'");
                if (comboBoxSelectColumn.SelectedIndex != -1)
                {
                    switch (comboBoxSelectTable.SelectedIndex)
                    {
                        case -1:
                            MessageBox.Show("Выберите таблицу!");
                            break;
                        case 0:
                            LoadDataAdministrator();
                            _textBoxAdmFk.Enabled = false;
                            _groupBoxEmployee.Visible = true;
                            break;
                        case 1:
                            LoadDataEmployee();
                            _textBoxAdmFk.Enabled = true;
                            _groupBoxEmployee.Visible = true;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Выберите параметр поиска");
                }
            }
        }

        private void comboBoxSelectColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectColumn.SelectedIndex)
            {
                case 0:
                    ColumnString = "lastname";
                    break;
                case 1:
                    ColumnString = "firstname";
                    break;
                case 2:
                    ColumnString = "dtdate";
                    break;
                case 3:
                    ColumnString = "post";
                    break;
                    
            }
        }

        private async void _buttonSave_Click(object sender, EventArgs e)
        {
            switch (comboBoxSelectTable.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Таблица не выбрана!");
                    break;
                case 0:
                    SwitchOnWaiting();
                    //получаем текущего
                    var currentadministrator = (Admins)_bindingourcesObjectCurrent.Current;
                    //проверяем введенную информацию введенную пользователем
                    Result<int> result;
                    try
                    {
                        if (currentadministrator.Admid == 0)
                        {
                            //добавляем нового сотрудника
                            result = await _repo.AddAdmin(currentadministrator);
                        }
                        else
                        {
                            //иначе обновляем существующего сотрудника
                            result = await _repo.UpdateAdmin(currentadministrator);
                        }

                        if (result)
                        {
                            //перечитываем данные
                            LoadDataAdministrator();
                        }
                    }
                    finally
                    {
                        SwitchOffWaiting();
                    }

                    if (!result)
                    {
                        MessageBox.Show(result.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    SwitchOnWaiting();
                    //получаем текущего
                    var currentemployee = (Employee)_bindingourcesObjectCurrent.Current;
                    //проверяем введенную информацию введенную пользователем
                    try
                    {
                        if (currentemployee.Id == 0)
                        {
                            //добавляем нового сотрудника
                            result = await _repo.AddEmployee(currentemployee);
                        }
                        else
                        {
                            //иначе обновляем существующего сотрудника
                            result = await _repo.UpdateEmployee(currentemployee);
                        }

                        if (result)
                        {
                            //перечитываем данные
                            LoadDataEmployee();
                        }
                    }
                    finally
                    {
                        SwitchOffWaiting();
                    }

                    if (!result)
                    {
                        MessageBox.Show(result.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

            }
        }

        private void документыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxDocuments.Visible = true;
            _groupBoxEmployee.Visible = false;   
        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxDocuments.Visible = false;
            _groupBoxEmployee.Visible = true;
        }

        private async void _buttonRemove_Click(object sender, EventArgs e)
        {

            switch (comboBoxSelectTable.SelectedIndex)
            {
                case 0:
                    SwitchOnWaiting();
                    //получаем текущего
                    var admin = (Admins)_bindingsourceObject.Current;
                    Result<int> result;
                    try
                    {
                        //удаляем из БД
                        result = await _repo.RemoveAdmin(admin.Admid);
                        if (result)
                        {
                            //удаляем из отображения
                            _bindingsourceObject.Remove(admin);
                            _bindingsourceObject.MoveFirst();
                            SetCurrentAdmin();
                        }
                    }
                    finally
                    {
                        SwitchOffWaiting();
                    }

                    if (!result)
                    {
                        MessageBox.Show(result.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    SwitchOnWaiting();
                    //получаем текущего
                    var employee = (Employee)_bindingsourceObject.Current;
                    /*Result<int>*/ /*result;*/
                    try
                    {
                        //удаляем из БД
                        result = await _repo.RemoveEmployee(employee.Id);
                        if (result)
                        {
                            //удаляем из отображения
                            _bindingsourceObject.Remove(employee);
                            _bindingsourceObject.MoveFirst();
                            SetCurrentEmployee();
                        }
                    }
                    finally
                    {
                        SwitchOffWaiting();
                    }

                    if (!result)
                    {
                        MessageBox.Show(result.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void авторизацияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSearch form = new FormSearch();
            form.ShowDialog();
        }
    }
}
