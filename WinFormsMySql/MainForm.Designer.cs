namespace WinFormsMySql
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
            this._groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._textBoxSex = new System.Windows.Forms.TextBox();
            this._textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxLastName = new System.Windows.Forms.TextBox();
            this._textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._textBoxPhone = new System.Windows.Forms.TextBox();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._buttonRemove = new System.Windows.Forms.Button();
            this._dataGridViewSelecNow = new System.Windows.Forms.DataGridView();
            this.comboBoxSelectTable = new System.Windows.Forms.ComboBox();
            this.textBoxSearchOnDb = new System.Windows.Forms.TextBox();
            this.comboBoxSelectColumn = new System.Windows.Forms.ComboBox();
            this._textBoxPasseria = new System.Windows.Forms.TextBox();
            this._textBoxPassnumber = new System.Windows.Forms.TextBox();
            this.groupBoxDocuments = new System.Windows.Forms.GroupBox();
            this._textBoxRegistration = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._textBoxIssued = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._textBoxAdmFk = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._textBoxPost = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискПоБдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личнаяИнформацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._textBoxCarfk = new System.Windows.Forms.TextBox();
            this._groupBoxEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSelecNow)).BeginInit();
            this.groupBoxDocuments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _groupBoxEmployee
            // 
            this._groupBoxEmployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this._groupBoxEmployee.Controls.Add(this.label7);
            this._groupBoxEmployee.Controls.Add(this.label6);
            this._groupBoxEmployee.Controls.Add(this._textBoxSex);
            this._groupBoxEmployee.Controls.Add(this._textBoxBirthDate);
            this._groupBoxEmployee.Controls.Add(this.label5);
            this._groupBoxEmployee.Controls.Add(this._textBoxPatronymic);
            this._groupBoxEmployee.Controls.Add(this.label2);
            this._groupBoxEmployee.Controls.Add(this.label1);
            this._groupBoxEmployee.Controls.Add(this._textBoxLastName);
            this._groupBoxEmployee.Controls.Add(this._textBoxFirstName);
            this._groupBoxEmployee.Controls.Add(this.label3);
            this._groupBoxEmployee.Controls.Add(this._textBoxPhone);
            this._groupBoxEmployee.Location = new System.Drawing.Point(13, 38);
            this._groupBoxEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._groupBoxEmployee.Name = "_groupBoxEmployee";
            this._groupBoxEmployee.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._groupBoxEmployee.Size = new System.Drawing.Size(560, 129);
            this._groupBoxEmployee.TabIndex = 0;
            this._groupBoxEmployee.TabStop = false;
            this._groupBoxEmployee.Text = "Сотрудник";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата рождения";
            // 
            // _textBoxSex
            // 
            this._textBoxSex.Location = new System.Drawing.Point(378, 53);
            this._textBoxSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._textBoxSex.Name = "_textBoxSex";
            this._textBoxSex.Size = new System.Drawing.Size(112, 26);
            this._textBoxSex.TabIndex = 14;
            // 
            // _textBoxBirthDate
            // 
            this._textBoxBirthDate.Location = new System.Drawing.Point(378, 21);
            this._textBoxBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._textBoxBirthDate.Name = "_textBoxBirthDate";
            this._textBoxBirthDate.Size = new System.Drawing.Size(112, 26);
            this._textBoxBirthDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Отчество";
            // 
            // _textBoxPatronymic
            // 
            this._textBoxPatronymic.Location = new System.Drawing.Point(97, 85);
            this._textBoxPatronymic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._textBoxPatronymic.Name = "_textBoxPatronymic";
            this._textBoxPatronymic.Size = new System.Drawing.Size(140, 26);
            this._textBoxPatronymic.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.Location = new System.Drawing.Point(97, 53);
            this._textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.Size = new System.Drawing.Size(140, 26);
            this._textBoxLastName.TabIndex = 2;
            // 
            // _textBoxFirstName
            // 
            this._textBoxFirstName.Location = new System.Drawing.Point(97, 21);
            this._textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.Size = new System.Drawing.Size(140, 26);
            this._textBoxFirstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Телефон";
            // 
            // _textBoxPhone
            // 
            this._textBoxPhone.Location = new System.Drawing.Point(378, 88);
            this._textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._textBoxPhone.Name = "_textBoxPhone";
            this._textBoxPhone.Size = new System.Drawing.Size(112, 26);
            this._textBoxPhone.TabIndex = 3;
            // 
            // _buttonSave
            // 
            this._buttonSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this._buttonSave.Location = new System.Drawing.Point(372, 170);
            this._buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(184, 64);
            this._buttonSave.TabIndex = 4;
            this._buttonSave.Text = "Сохранить";
            this._buttonSave.UseVisualStyleBackColor = false;
            this._buttonSave.Click += new System.EventHandler(this._buttonSave_Click);
            // 
            // _buttonAdd
            // 
            this._buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this._buttonAdd.Location = new System.Drawing.Point(172, 171);
            this._buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(184, 64);
            this._buttonAdd.TabIndex = 4;
            this._buttonAdd.Text = "Добавить";
            this._buttonAdd.UseVisualStyleBackColor = false;
            this._buttonAdd.Click += new System.EventHandler(this._buttonAdd_Click);
            // 
            // _buttonRemove
            // 
            this._buttonRemove.BackColor = System.Drawing.SystemColors.ControlDark;
            this._buttonRemove.Location = new System.Drawing.Point(227, 244);
            this._buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._buttonRemove.Name = "_buttonRemove";
            this._buttonRemove.Size = new System.Drawing.Size(276, 61);
            this._buttonRemove.TabIndex = 5;
            this._buttonRemove.Text = "Удалить";
            this._buttonRemove.UseVisualStyleBackColor = false;
            this._buttonRemove.Click += new System.EventHandler(this._buttonRemove_Click);
            // 
            // _dataGridViewSelecNow
            // 
            this._dataGridViewSelecNow.AllowUserToAddRows = false;
            this._dataGridViewSelecNow.AllowUserToDeleteRows = false;
            this._dataGridViewSelecNow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewSelecNow.Location = new System.Drawing.Point(13, 315);
            this._dataGridViewSelecNow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._dataGridViewSelecNow.Name = "_dataGridViewSelecNow";
            this._dataGridViewSelecNow.RowHeadersWidth = 51;
            this._dataGridViewSelecNow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewSelecNow.Size = new System.Drawing.Size(815, 212);
            this._dataGridViewSelecNow.TabIndex = 1;
            // 
            // comboBoxSelectTable
            // 
            this.comboBoxSelectTable.FormattingEnabled = true;
            this.comboBoxSelectTable.Items.AddRange(new object[] {
            "Администраторы",
            "Преподаватели"});
            this.comboBoxSelectTable.Location = new System.Drawing.Point(6, 53);
            this.comboBoxSelectTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSelectTable.Name = "comboBoxSelectTable";
            this.comboBoxSelectTable.Size = new System.Drawing.Size(223, 28);
            this.comboBoxSelectTable.TabIndex = 8;
            // 
            // textBoxSearchOnDb
            // 
            this.textBoxSearchOnDb.Location = new System.Drawing.Point(6, 171);
            this.textBoxSearchOnDb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearchOnDb.Name = "textBoxSearchOnDb";
            this.textBoxSearchOnDb.Size = new System.Drawing.Size(223, 26);
            this.textBoxSearchOnDb.TabIndex = 9;
            this.textBoxSearchOnDb.TextChanged += new System.EventHandler(this.textBoxSearchOnDb_TextChanged);
            // 
            // comboBoxSelectColumn
            // 
            this.comboBoxSelectColumn.FormattingEnabled = true;
            this.comboBoxSelectColumn.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Дата рождения",
            "Должность"});
            this.comboBoxSelectColumn.Location = new System.Drawing.Point(6, 109);
            this.comboBoxSelectColumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSelectColumn.Name = "comboBoxSelectColumn";
            this.comboBoxSelectColumn.Size = new System.Drawing.Size(223, 28);
            this.comboBoxSelectColumn.TabIndex = 11;
            this.comboBoxSelectColumn.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectColumn_SelectedIndexChanged);
            // 
            // _textBoxPasseria
            // 
            this._textBoxPasseria.Location = new System.Drawing.Point(140, 31);
            this._textBoxPasseria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._textBoxPasseria.Name = "_textBoxPasseria";
            this._textBoxPasseria.Size = new System.Drawing.Size(112, 26);
            this._textBoxPasseria.TabIndex = 15;
            // 
            // _textBoxPassnumber
            // 
            this._textBoxPassnumber.Location = new System.Drawing.Point(140, 78);
            this._textBoxPassnumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._textBoxPassnumber.Name = "_textBoxPassnumber";
            this._textBoxPassnumber.Size = new System.Drawing.Size(112, 26);
            this._textBoxPassnumber.TabIndex = 16;
            // 
            // groupBoxDocuments
            // 
            this.groupBoxDocuments.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxDocuments.Controls.Add(this._textBoxRegistration);
            this.groupBoxDocuments.Controls.Add(this.label11);
            this.groupBoxDocuments.Controls.Add(this._textBoxIssued);
            this.groupBoxDocuments.Controls.Add(this.label10);
            this.groupBoxDocuments.Controls.Add(this.label9);
            this.groupBoxDocuments.Controls.Add(this._textBoxPassnumber);
            this.groupBoxDocuments.Controls.Add(this._textBoxPasseria);
            this.groupBoxDocuments.Controls.Add(this.label8);
            this.groupBoxDocuments.Location = new System.Drawing.Point(13, 33);
            this.groupBoxDocuments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDocuments.Name = "groupBoxDocuments";
            this.groupBoxDocuments.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDocuments.Size = new System.Drawing.Size(561, 125);
            this.groupBoxDocuments.TabIndex = 17;
            this.groupBoxDocuments.TabStop = false;
            this.groupBoxDocuments.Text = "Документы";
            // 
            // _textBoxRegistration
            // 
            this._textBoxRegistration.Location = new System.Drawing.Point(378, 78);
            this._textBoxRegistration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._textBoxRegistration.Name = "_textBoxRegistration";
            this._textBoxRegistration.Size = new System.Drawing.Size(155, 26);
            this._textBoxRegistration.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Регистрация";
            // 
            // _textBoxIssued
            // 
            this._textBoxIssued.Location = new System.Drawing.Point(378, 31);
            this._textBoxIssued.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._textBoxIssued.Name = "_textBoxIssued";
            this._textBoxIssued.Size = new System.Drawing.Size(155, 26);
            this._textBoxIssued.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Кем выдан";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Номер паспорта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Серия паспорта";
            // 
            // _textBoxAdmFk
            // 
            this._textBoxAdmFk.Location = new System.Drawing.Point(6, 74);
            this._textBoxAdmFk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._textBoxAdmFk.Name = "_textBoxAdmFk";
            this._textBoxAdmFk.Size = new System.Drawing.Size(50, 26);
            this._textBoxAdmFk.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxSearchOnDb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxSelectTable);
            this.groupBox1.Controls.Add(this.comboBoxSelectColumn);
            this.groupBox1.Location = new System.Drawing.Point(580, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(235, 216);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по бд";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Поиск";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Выберите параметр поиска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Выберите таблицу";
            // 
            // _textBoxPost
            // 
            this._textBoxPost.Location = new System.Drawing.Point(6, 25);
            this._textBoxPost.Name = "_textBoxPost";
            this._textBoxPost.Size = new System.Drawing.Size(116, 26);
            this._textBoxPost.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this._textBoxCarfk);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this._textBoxAdmFk);
            this.groupBox2.Controls.Add(this._textBoxPost);
            this.groupBox2.Location = new System.Drawing.Point(13, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 107);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Должность";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Подчиненный";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоБдToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 33);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискПоБдToolStripMenuItem
            // 
            this.поискПоБдToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.личнаяИнформацияToolStripMenuItem});
            this.поискПоБдToolStripMenuItem.Name = "поискПоБдToolStripMenuItem";
            this.поискПоБдToolStripMenuItem.Size = new System.Drawing.Size(205, 29);
            this.поискПоБдToolStripMenuItem.Text = "Управление данными";
            // 
            // личнаяИнформацияToolStripMenuItem
            // 
            this.личнаяИнформацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.документыToolStripMenuItem,
            this.справочникToolStripMenuItem});
            this.личнаяИнформацияToolStripMenuItem.Name = "личнаяИнформацияToolStripMenuItem";
            this.личнаяИнформацияToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.личнаяИнформацияToolStripMenuItem.Text = "Личная информация";
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.документыToolStripMenuItem.Text = "Документы";
            this.документыToolStripMenuItem.Click += new System.EventHandler(this.документыToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.справочникToolStripMenuItem.Text = "Справочник";
            this.справочникToolStripMenuItem.Click += new System.EventHandler(this.справочникToolStripMenuItem_Click);
            // 
            // _textBoxCarfk
            // 
            this._textBoxCarfk.Location = new System.Drawing.Point(62, 74);
            this._textBoxCarfk.Name = "_textBoxCarfk";
            this._textBoxCarfk.Size = new System.Drawing.Size(60, 26);
            this._textBoxCarfk.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._dataGridViewSelecNow);
            this.Controls.Add(this.groupBoxDocuments);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._buttonRemove);
            this.Controls.Add(this._groupBoxEmployee);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "ИС автошколы";
            this._groupBoxEmployee.ResumeLayout(false);
            this._groupBoxEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewSelecNow)).EndInit();
            this.groupBoxDocuments.ResumeLayout(false);
            this.groupBoxDocuments.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _groupBoxEmployee;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.Button _buttonRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxPhone;
        private System.Windows.Forms.TextBox _textBoxLastName;
        private System.Windows.Forms.TextBox _textBoxFirstName;
        private System.Windows.Forms.DataGridView _dataGridViewSelecNow;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.ComboBox comboBoxSelectTable;
        private System.Windows.Forms.TextBox textBoxSearchOnDb;
        private System.Windows.Forms.ComboBox comboBoxSelectColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _textBoxPatronymic;
        private System.Windows.Forms.TextBox _textBoxBirthDate;
        private System.Windows.Forms.TextBox _textBoxPassnumber;
        private System.Windows.Forms.TextBox _textBoxPasseria;
        private System.Windows.Forms.TextBox _textBoxSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxDocuments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _textBoxIssued;
        private System.Windows.Forms.TextBox _textBoxRegistration;
        private System.Windows.Forms.TextBox _textBoxAdmFk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _textBoxPost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискПоБдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личнаяИнформацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox _textBoxCarfk;
    }
}

