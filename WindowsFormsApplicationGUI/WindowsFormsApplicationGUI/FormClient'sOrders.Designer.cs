namespace WindowsFormsApplicationGUI
{
    partial class FormClient_sOrders
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxMethPmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonListBook = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxClientIDName = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hiTechDBDataSet = new WindowsFormsApplicationGUI.HiTechDBDataSet();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonSaveBook = new System.Windows.Forms.Button();
            this.dataGridViewOrderBook = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxClientID = new System.Windows.Forms.ComboBox();
            this.buttonupdatesoftware = new System.Windows.Forms.Button();
            this.buttondeleteSoftware = new System.Windows.Forms.Button();
            this.buttonaddSoftware = new System.Windows.Forms.Button();
            this.dataGridViewOrderSoftware = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxClient_Id = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxsoftName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSoftwareId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerOrder_Date = new System.Windows.Forms.DateTimePicker();
            this.textBoxMeth_pmt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOrder_Id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonsearchsoftware = new System.Windows.Forms.Button();
            this.buttonlistsoftware = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new WindowsFormsApplicationGUI.HiTechDBDataSetTableAdapters.ClientsTableAdapter();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiTechDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderBook)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderSoftware)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderId:";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(6, 44);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrderID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxClientId);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxIsbn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePickerOrderDate);
            this.groupBox1.Controls.Add(this.textBoxMethPmt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxOrderID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client\'s Orders Information";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(248, 99);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(100, 22);
            this.textBoxClientId.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(245, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "ClientId:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(112, 99);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(127, 22);
            this.textBoxTitle.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "BookTitle:";
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(6, 99);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(100, 22);
            this.textBoxIsbn.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Book\'sIsbn:";
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(112, 44);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerOrderDate.TabIndex = 6;
            // 
            // textBoxMethPmt
            // 
            this.textBoxMethPmt.Location = new System.Drawing.Point(244, 44);
            this.textBoxMethPmt.Name = "textBoxMethPmt";
            this.textBoxMethPmt.Size = new System.Drawing.Size(138, 22);
            this.textBoxMethPmt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "MethodOfPayment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "OrderDate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ClientId:";
            // 
            // buttonListBook
            // 
            this.buttonListBook.Location = new System.Drawing.Point(145, 222);
            this.buttonListBook.Name = "buttonListBook";
            this.buttonListBook.Size = new System.Drawing.Size(122, 23);
            this.buttonListBook.TabIndex = 29;
            this.buttonListBook.Text = "&ListClient\'sOrders";
            this.buttonListBook.UseVisualStyleBackColor = true;
            this.buttonListBook.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Location = new System.Drawing.Point(6, 193);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(106, 23);
            this.buttonSearchBook.TabIndex = 26;
            this.buttonSearchBook.Text = "&SearchClient\'sOrders";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(359, 401);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 40);
            this.buttonExit.TabIndex = 31;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 374);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxClientIDName);
            this.tabPage1.Controls.Add(this.buttonUpdateBook);
            this.tabPage1.Controls.Add(this.buttonDeleteBook);
            this.tabPage1.Controls.Add(this.buttonSaveBook);
            this.tabPage1.Controls.Add(this.dataGridViewOrderBook);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.buttonSearchBook);
            this.tabPage1.Controls.Add(this.buttonListBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client\'s Orders(Books)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxClientIDName
            // 
            this.comboBoxClientIDName.DataSource = this.clientsBindingSource;
            this.comboBoxClientIDName.DisplayMember = "ClientName";
            this.comboBoxClientIDName.FormattingEnabled = true;
            this.comboBoxClientIDName.Location = new System.Drawing.Point(11, 21);
            this.comboBoxClientIDName.Name = "comboBoxClientIDName";
            this.comboBoxClientIDName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClientIDName.TabIndex = 35;
            this.comboBoxClientIDName.ValueMember = "ClientID";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hiTechDBDataSet;
            // 
            // hiTechDBDataSet
            // 
            this.hiTechDBDataSet.DataSetName = "HiTechDBDataSet";
            this.hiTechDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Location = new System.Drawing.Point(216, 193);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(88, 23);
            this.buttonUpdateBook.TabIndex = 34;
            this.buttonUpdateBook.Text = "&UpdateClient\'sOrders";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(115, 193);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(95, 23);
            this.buttonDeleteBook.TabIndex = 33;
            this.buttonDeleteBook.Text = "&DeleteClient\'sOrders";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonSaveBook
            // 
            this.buttonSaveBook.Location = new System.Drawing.Point(310, 193);
            this.buttonSaveBook.Name = "buttonSaveBook";
            this.buttonSaveBook.Size = new System.Drawing.Size(99, 23);
            this.buttonSaveBook.TabIndex = 32;
            this.buttonSaveBook.Text = "&SaveClient\'sOrders";
            this.buttonSaveBook.UseVisualStyleBackColor = true;
            this.buttonSaveBook.Click += new System.EventHandler(this.buttonSaveBook_Click);
            // 
            // dataGridViewOrderBook
            // 
            this.dataGridViewOrderBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderBook.Location = new System.Drawing.Point(0, 251);
            this.dataGridViewOrderBook.Name = "dataGridViewOrderBook";
            this.dataGridViewOrderBook.Size = new System.Drawing.Size(409, 91);
            this.dataGridViewOrderBook.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxClientID);
            this.tabPage2.Controls.Add(this.buttonupdatesoftware);
            this.tabPage2.Controls.Add(this.buttondeleteSoftware);
            this.tabPage2.Controls.Add(this.buttonaddSoftware);
            this.tabPage2.Controls.Add(this.dataGridViewOrderSoftware);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.buttonsearchsoftware);
            this.tabPage2.Controls.Add(this.buttonlistsoftware);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client\'sOrders(Softwares)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxClientID
            // 
            this.comboBoxClientID.DataSource = this.clientsBindingSource;
            this.comboBoxClientID.DisplayMember = "ClientName";
            this.comboBoxClientID.FormattingEnabled = true;
            this.comboBoxClientID.Location = new System.Drawing.Point(14, 23);
            this.comboBoxClientID.Name = "comboBoxClientID";
            this.comboBoxClientID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClientID.TabIndex = 45;
            this.comboBoxClientID.ValueMember = "ClientID";
            // 
            // buttonupdatesoftware
            // 
            this.buttonupdatesoftware.Location = new System.Drawing.Point(269, 195);
            this.buttonupdatesoftware.Name = "buttonupdatesoftware";
            this.buttonupdatesoftware.Size = new System.Drawing.Size(122, 23);
            this.buttonupdatesoftware.TabIndex = 44;
            this.buttonupdatesoftware.Text = "&UpdateClient\'sOrders";
            this.buttonupdatesoftware.UseVisualStyleBackColor = true;
            this.buttonupdatesoftware.Click += new System.EventHandler(this.buttonupdatesoftware_Click);
            // 
            // buttondeleteSoftware
            // 
            this.buttondeleteSoftware.Location = new System.Drawing.Point(137, 221);
            this.buttondeleteSoftware.Name = "buttondeleteSoftware";
            this.buttondeleteSoftware.Size = new System.Drawing.Size(122, 23);
            this.buttondeleteSoftware.TabIndex = 43;
            this.buttondeleteSoftware.Text = "&DeleteClient\'sOrders";
            this.buttondeleteSoftware.UseVisualStyleBackColor = true;
            this.buttondeleteSoftware.Click += new System.EventHandler(this.buttondeleteSoftware_Click);
            // 
            // buttonaddSoftware
            // 
            this.buttonaddSoftware.Location = new System.Drawing.Point(9, 221);
            this.buttonaddSoftware.Name = "buttonaddSoftware";
            this.buttonaddSoftware.Size = new System.Drawing.Size(122, 23);
            this.buttonaddSoftware.TabIndex = 42;
            this.buttonaddSoftware.Text = "&SaveClient\'sOrders";
            this.buttonaddSoftware.UseVisualStyleBackColor = true;
            this.buttonaddSoftware.Click += new System.EventHandler(this.buttonaddSoftware_Click);
            // 
            // dataGridViewOrderSoftware
            // 
            this.dataGridViewOrderSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderSoftware.Location = new System.Drawing.Point(3, 250);
            this.dataGridViewOrderSoftware.Name = "dataGridViewOrderSoftware";
            this.dataGridViewOrderSoftware.Size = new System.Drawing.Size(489, 56);
            this.dataGridViewOrderSoftware.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxClient_Id);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxsoftName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxSoftwareId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePickerOrder_Date);
            this.groupBox2.Controls.Add(this.textBoxMeth_pmt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxOrder_Id);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 139);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client\'s Orders Information";
            // 
            // textBoxClient_Id
            // 
            this.textBoxClient_Id.Location = new System.Drawing.Point(244, 99);
            this.textBoxClient_Id.Name = "textBoxClient_Id";
            this.textBoxClient_Id.Size = new System.Drawing.Size(138, 22);
            this.textBoxClient_Id.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(241, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "ClientId:";
            // 
            // textBoxsoftName
            // 
            this.textBoxsoftName.Location = new System.Drawing.Point(112, 99);
            this.textBoxsoftName.Name = "textBoxsoftName";
            this.textBoxsoftName.Size = new System.Drawing.Size(127, 22);
            this.textBoxsoftName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "SoftwareName:";
            // 
            // textBoxSoftwareId
            // 
            this.textBoxSoftwareId.Location = new System.Drawing.Point(6, 99);
            this.textBoxSoftwareId.Name = "textBoxSoftwareId";
            this.textBoxSoftwareId.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoftwareId.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "SoftwareId:";
            // 
            // dateTimePickerOrder_Date
            // 
            this.dateTimePickerOrder_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOrder_Date.Location = new System.Drawing.Point(112, 44);
            this.dateTimePickerOrder_Date.Name = "dateTimePickerOrder_Date";
            this.dateTimePickerOrder_Date.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerOrder_Date.TabIndex = 6;
            // 
            // textBoxMeth_pmt
            // 
            this.textBoxMeth_pmt.Location = new System.Drawing.Point(244, 44);
            this.textBoxMeth_pmt.Name = "textBoxMeth_pmt";
            this.textBoxMeth_pmt.Size = new System.Drawing.Size(138, 22);
            this.textBoxMeth_pmt.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(244, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "MethodOfPayment:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(125, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "OrderDate:";
            // 
            // textBoxOrder_Id
            // 
            this.textBoxOrder_Id.Location = new System.Drawing.Point(6, 44);
            this.textBoxOrder_Id.Name = "textBoxOrder_Id";
            this.textBoxOrder_Id.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrder_Id.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "OrderId:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "ClientId:";
            // 
            // buttonsearchsoftware
            // 
            this.buttonsearchsoftware.Location = new System.Drawing.Point(9, 195);
            this.buttonsearchsoftware.Name = "buttonsearchsoftware";
            this.buttonsearchsoftware.Size = new System.Drawing.Size(122, 23);
            this.buttonsearchsoftware.TabIndex = 39;
            this.buttonsearchsoftware.Text = "&SearchClient\'sOrders";
            this.buttonsearchsoftware.UseVisualStyleBackColor = true;
            this.buttonsearchsoftware.Click += new System.EventHandler(this.buttonsearchsoftware_Click);
            // 
            // buttonlistsoftware
            // 
            this.buttonlistsoftware.Location = new System.Drawing.Point(137, 195);
            this.buttonlistsoftware.Name = "buttonlistsoftware";
            this.buttonlistsoftware.Size = new System.Drawing.Size(122, 23);
            this.buttonlistsoftware.TabIndex = 40;
            this.buttonlistsoftware.Text = "&ListClient\'sOrders";
            this.buttonlistsoftware.UseVisualStyleBackColor = true;
            this.buttonlistsoftware.Click += new System.EventHandler(this.buttonlistsoftware_Click);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // FormClient_sOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 449);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonExit);
            this.Name = "FormClient_sOrders";
            this.Text = "FormClient\'s Orders";
            this.Load += new System.EventHandler(this.FormClient_sOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiTechDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderBook)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderSoftware)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMethPmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonListBook;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewOrderBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonSaveBook;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.Button buttonupdatesoftware;
        private System.Windows.Forms.Button buttondeleteSoftware;
        private System.Windows.Forms.Button buttonaddSoftware;
        private System.Windows.Forms.DataGridView dataGridViewOrderSoftware;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxsoftName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSoftwareId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder_Date;
        private System.Windows.Forms.TextBox textBoxMeth_pmt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxOrder_Id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonsearchsoftware;
        private System.Windows.Forms.Button buttonlistsoftware;
        private System.Windows.Forms.ComboBox comboBoxClientIDName;
        private HiTechDBDataSet hiTechDBDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HiTechDBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxClientID;
        private System.Windows.Forms.TextBox textBoxClient_Id;
        private System.Windows.Forms.Label label14;
    }
}