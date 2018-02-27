namespace WindowsFormsApplicationGUI
{
    partial class ProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLimitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYearPublished = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxQOH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPublisherID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCategoryIdforBook = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxSoftwareName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxSoftwareId = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonUpdateSoftware = new System.Windows.Forms.Button();
            this.buttonDeleteSoftware = new System.Windows.Forms.Button();
            this.buttonSearchSoftware = new System.Windows.Forms.Button();
            this.buttonAddSoftware = new System.Windows.Forms.Button();
            this.listViewBook = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSoftware = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonListBook = new System.Windows.Forms.Button();
            this.buttonListSoftware = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxAuthorID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCategoryIdForSoftware = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddAuthBook = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxBook.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TwoTypeOFProducts:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN:";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(7, 43);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(79, 20);
            this.textBoxISBN.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(107, 43);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(79, 20);
            this.textBoxTitle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Title:";
            // 
            // textBoxLimitPrice
            // 
            this.textBoxLimitPrice.Location = new System.Drawing.Point(207, 43);
            this.textBoxLimitPrice.Name = "textBoxLimitPrice";
            this.textBoxLimitPrice.Size = new System.Drawing.Size(79, 20);
            this.textBoxLimitPrice.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "LimitPrice:";
            // 
            // textBoxYearPublished
            // 
            this.textBoxYearPublished.Location = new System.Drawing.Point(303, 43);
            this.textBoxYearPublished.Name = "textBoxYearPublished";
            this.textBoxYearPublished.Size = new System.Drawing.Size(79, 20);
            this.textBoxYearPublished.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "YearPublished:";
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.Location = new System.Drawing.Point(399, 43);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(79, 20);
            this.textBoxQOH.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "QOH:";
            // 
            // textBoxPublisherID
            // 
            this.textBoxPublisherID.Location = new System.Drawing.Point(9, 109);
            this.textBoxPublisherID.Name = "textBoxPublisherID";
            this.textBoxPublisherID.Size = new System.Drawing.Size(79, 20);
            this.textBoxPublisherID.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "PublisherId:";
            // 
            // textBoxCategoryIdforBook
            // 
            this.textBoxCategoryIdforBook.Location = new System.Drawing.Point(108, 109);
            this.textBoxCategoryIdforBook.Name = "textBoxCategoryIdforBook";
            this.textBoxCategoryIdforBook.Size = new System.Drawing.Size(79, 20);
            this.textBoxCategoryIdforBook.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "CategoryId:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Publisher:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(107, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 16);
            this.label18.TabIndex = 31;
            this.label18.Text = "Book\'s Category:";
            // 
            // textBoxSoftwareName
            // 
            this.textBoxSoftwareName.Location = new System.Drawing.Point(106, 37);
            this.textBoxSoftwareName.Name = "textBoxSoftwareName";
            this.textBoxSoftwareName.Size = new System.Drawing.Size(79, 20);
            this.textBoxSoftwareName.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(106, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "SoftwareName:";
            // 
            // textBoxSoftwareId
            // 
            this.textBoxSoftwareId.Location = new System.Drawing.Point(6, 37);
            this.textBoxSoftwareId.Name = "textBoxSoftwareId";
            this.textBoxSoftwareId.Size = new System.Drawing.Size(79, 20);
            this.textBoxSoftwareId.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "SoftwareId:";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(15, 325);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(163, 23);
            this.buttonAddBook.TabIndex = 36;
            this.buttonAddBook.Text = "&AddBook";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(202, 325);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(145, 23);
            this.buttonSearch.TabIndex = 37;
            this.buttonSearch.Text = "&SearchBook";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(15, 354);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(163, 23);
            this.buttonDelete.TabIndex = 38;
            this.buttonDelete.Text = "&DeleteBook";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(202, 354);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(145, 23);
            this.buttonUpdate.TabIndex = 39;
            this.buttonUpdate.Text = "&UpdateBook";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonUpdateSoftware
            // 
            this.buttonUpdateSoftware.Location = new System.Drawing.Point(625, 360);
            this.buttonUpdateSoftware.Name = "buttonUpdateSoftware";
            this.buttonUpdateSoftware.Size = new System.Drawing.Size(94, 23);
            this.buttonUpdateSoftware.TabIndex = 43;
            this.buttonUpdateSoftware.Text = "&UpdateSoftware";
            this.buttonUpdateSoftware.UseVisualStyleBackColor = true;
            this.buttonUpdateSoftware.Click += new System.EventHandler(this.buttonUpdateSoftware_Click);
            // 
            // buttonDeleteSoftware
            // 
            this.buttonDeleteSoftware.Location = new System.Drawing.Point(519, 360);
            this.buttonDeleteSoftware.Name = "buttonDeleteSoftware";
            this.buttonDeleteSoftware.Size = new System.Drawing.Size(97, 23);
            this.buttonDeleteSoftware.TabIndex = 42;
            this.buttonDeleteSoftware.Text = "&DeleteSoftware";
            this.buttonDeleteSoftware.UseVisualStyleBackColor = true;
            this.buttonDeleteSoftware.Click += new System.EventHandler(this.buttonDeleteSoftware_Click);
            // 
            // buttonSearchSoftware
            // 
            this.buttonSearchSoftware.Location = new System.Drawing.Point(625, 331);
            this.buttonSearchSoftware.Name = "buttonSearchSoftware";
            this.buttonSearchSoftware.Size = new System.Drawing.Size(94, 23);
            this.buttonSearchSoftware.TabIndex = 41;
            this.buttonSearchSoftware.Text = "&SearchSoftware";
            this.buttonSearchSoftware.UseVisualStyleBackColor = true;
            this.buttonSearchSoftware.Click += new System.EventHandler(this.buttonSearchSoftware_Click);
            // 
            // buttonAddSoftware
            // 
            this.buttonAddSoftware.Location = new System.Drawing.Point(519, 331);
            this.buttonAddSoftware.Name = "buttonAddSoftware";
            this.buttonAddSoftware.Size = new System.Drawing.Size(97, 23);
            this.buttonAddSoftware.TabIndex = 40;
            this.buttonAddSoftware.Text = "&AddSoftware";
            this.buttonAddSoftware.UseVisualStyleBackColor = true;
            this.buttonAddSoftware.Click += new System.EventHandler(this.buttonAddSoftware_Click);
            // 
            // listViewBook
            // 
            this.listViewBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewBook.Location = new System.Drawing.Point(15, 241);
            this.listViewBook.Name = "listViewBook";
            this.listViewBook.Size = new System.Drawing.Size(332, 78);
            this.listViewBook.TabIndex = 44;
            this.listViewBook.UseCompatibleStateImageBehavior = false;
            this.listViewBook.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Isbn";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 61;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LimitPrice";
            this.columnHeader3.Width = 58;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "YearPublished";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "QOH";
            // 
            // listViewSoftware
            // 
            this.listViewSoftware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.listViewSoftware.Location = new System.Drawing.Point(519, 238);
            this.listViewSoftware.Name = "listViewSoftware";
            this.listViewSoftware.Size = new System.Drawing.Size(200, 78);
            this.listViewSoftware.TabIndex = 45;
            this.listViewSoftware.UseCompatibleStateImageBehavior = false;
            this.listViewSoftware.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "SoftwareId";
            this.columnHeader13.Width = 76;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "SoftwareName";
            this.columnHeader14.Width = 83;
            // 
            // buttonListBook
            // 
            this.buttonListBook.Location = new System.Drawing.Point(12, 212);
            this.buttonListBook.Name = "buttonListBook";
            this.buttonListBook.Size = new System.Drawing.Size(169, 23);
            this.buttonListBook.TabIndex = 46;
            this.buttonListBook.Text = "&ListBookbyAuthorID";
            this.buttonListBook.UseVisualStyleBackColor = true;
            this.buttonListBook.Click += new System.EventHandler(this.buttonListBook_Click);
            // 
            // buttonListSoftware
            // 
            this.buttonListSoftware.Location = new System.Drawing.Point(519, 209);
            this.buttonListSoftware.Name = "buttonListSoftware";
            this.buttonListSoftware.Size = new System.Drawing.Size(161, 23);
            this.buttonListSoftware.TabIndex = 47;
            this.buttonListSoftware.Text = "&ListSoftware";
            this.buttonListSoftware.UseVisualStyleBackColor = true;
            this.buttonListSoftware.Click += new System.EventHandler(this.buttonListSoftware_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(680, 389);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 23);
            this.buttonExit.TabIndex = 50;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(404, 212);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(97, 23);
            this.buttonReset.TabIndex = 51;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(300, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 54;
            this.label16.Text = "Author:";
            // 
            // textBoxAuthorID
            // 
            this.textBoxAuthorID.Location = new System.Drawing.Point(303, 109);
            this.textBoxAuthorID.Name = "textBoxAuthorID";
            this.textBoxAuthorID.Size = new System.Drawing.Size(79, 20);
            this.textBoxAuthorID.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "AuthorId:";
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.Controls.Add(this.buttonAddAuthBook);
            this.groupBoxBook.Controls.Add(this.dateTimePicker);
            this.groupBoxBook.Controls.Add(this.label10);
            this.groupBoxBook.Controls.Add(this.label5);
            this.groupBoxBook.Controls.Add(this.label4);
            this.groupBoxBook.Controls.Add(this.label16);
            this.groupBoxBook.Controls.Add(this.textBoxAuthorID);
            this.groupBoxBook.Controls.Add(this.textBoxISBN);
            this.groupBoxBook.Controls.Add(this.label9);
            this.groupBoxBook.Controls.Add(this.textBoxTitle);
            this.groupBoxBook.Controls.Add(this.label6);
            this.groupBoxBook.Controls.Add(this.textBoxLimitPrice);
            this.groupBoxBook.Controls.Add(this.label7);
            this.groupBoxBook.Controls.Add(this.textBoxYearPublished);
            this.groupBoxBook.Controls.Add(this.label8);
            this.groupBoxBook.Controls.Add(this.textBoxQOH);
            this.groupBoxBook.Controls.Add(this.label17);
            this.groupBoxBook.Controls.Add(this.label12);
            this.groupBoxBook.Controls.Add(this.textBoxPublisherID);
            this.groupBoxBook.Controls.Add(this.label14);
            this.groupBoxBook.Controls.Add(this.textBoxCategoryIdforBook);
            this.groupBoxBook.Controls.Add(this.label18);
            this.groupBoxBook.Location = new System.Drawing.Point(15, 38);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(485, 165);
            this.groupBoxBook.TabIndex = 55;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Product1: Book";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCategoryIdForSoftware);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.textBoxSoftwareId);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.textBoxSoftwareName);
            this.groupBox1.Location = new System.Drawing.Point(519, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 165);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product2: Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "CategoryId:";
            // 
            // textBoxCategoryIdForSoftware
            // 
            this.textBoxCategoryIdForSoftware.Location = new System.Drawing.Point(13, 103);
            this.textBoxCategoryIdForSoftware.Name = "textBoxCategoryIdForSoftware";
            this.textBoxCategoryIdForSoftware.Size = new System.Drawing.Size(79, 20);
            this.textBoxCategoryIdForSoftware.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Software\'s Category:";
            // 
            // buttonAddAuthBook
            // 
            this.buttonAddAuthBook.Location = new System.Drawing.Point(303, 135);
            this.buttonAddAuthBook.Name = "buttonAddAuthBook";
            this.buttonAddAuthBook.Size = new System.Drawing.Size(104, 23);
            this.buttonAddAuthBook.TabIndex = 57;
            this.buttonAddAuthBook.Text = "&SaveAuthorBook";
            this.buttonAddAuthBook.UseVisualStyleBackColor = true;
            this.buttonAddAuthBook.Click += new System.EventHandler(this.buttonAddAuthBook_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(389, 108);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker.TabIndex = 56;
            this.dateTimePicker.Value = new System.DateTime(2017, 4, 16, 0, 0, 0, 0);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxBook);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonListSoftware);
            this.Controls.Add(this.listViewSoftware);
            this.Controls.Add(this.buttonListBook);
            this.Controls.Add(this.listViewBook);
            this.Controls.Add(this.buttonUpdateSoftware);
            this.Controls.Add(this.buttonDeleteSoftware);
            this.Controls.Add(this.buttonSearchSoftware);
            this.Controls.Add(this.buttonAddSoftware);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.groupBoxBook.ResumeLayout(false);
            this.groupBoxBook.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLimitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYearPublished;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxQOH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPublisherID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCategoryIdforBook;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxSoftwareName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxSoftwareId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonUpdateSoftware;
        private System.Windows.Forms.Button buttonDeleteSoftware;
        private System.Windows.Forms.Button buttonSearchSoftware;
        private System.Windows.Forms.Button buttonAddSoftware;
        private System.Windows.Forms.ListView listViewBook;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listViewSoftware;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button buttonListBook;
        private System.Windows.Forms.Button buttonListSoftware;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxAuthorID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCategoryIdForSoftware;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddAuthBook;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}