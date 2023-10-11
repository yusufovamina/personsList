namespace personsList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ShowPanel = new Panel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            monthCalendar2 = new MonthCalendar();
            comboBoxGender = new ComboBox();
            genderLabel = new Label();
            ageLabel = new Label();
            surnameLabel = new Label();
            label6 = new Label();
            ProductsList = new ListBox();
            SaveButton = new Button();
            EditButton = new Button();
            closeButton = new Button();
            ShowInfoProductPanel = new Panel();
            SaveProductsButton = new Button();
            EditProductsButton = new Button();
            textBox1 = new TextBox();
            label18 = new Label();
            textBox2 = new TextBox();
            label19 = new Label();
            CloseInfoProductButton = new Button();
            SellPanel = new Panel();
            FinishOrderButton = new Button();
            ClearCartButton = new Button();
            DeleteItemFromCart = new Button();
            AddToCart = new Button();
            personsCart_ListBox = new ListBox();
            ProductsPrice = new Label();
            ProductsName = new Label();
            customersSurname = new Label();
            customersName = new Label();
            label12 = new Label();
            label11 = new Label();
            SellButtonPanel = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            products_ListBox = new ListBox();
            persons_sellPanel_Label = new Label();
            Persons_ListBoxPanel = new ListBox();
            productsPanel = new Panel();
            productsListBox1 = new ListBox();
            ShowInfoProductButton = new Button();
            DeleteProductButton = new Button();
            AddProductButton = new Button();
            TextBoxProductsPrice = new TextBox();
            label5 = new Label();
            textBoxProductName = new TextBox();
            label4 = new Label();
            splitContainer1 = new SplitContainer();
            SellingsShowButton = new Button();
            ProductsShowButton = new Button();
            PersonsShowButton = new Button();
            PersonsPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            monthCalendarMain = new MonthCalendar();
            GenderComboBoxMain = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            DeletePersonButton = new Button();
            AddPersonButton = new Button();
            personsListBoxMain = new ListBox();
            label13 = new Label();
            ShowInfoButton = new Button();
            ShowPanel.SuspendLayout();
            ShowInfoProductPanel.SuspendLayout();
            SellPanel.SuspendLayout();
            productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            PersonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ShowPanel
            // 
            ShowPanel.BackColor = Color.MediumSlateBlue;
            ShowPanel.Controls.Add(textBox6);
            ShowPanel.Controls.Add(textBox5);
            ShowPanel.Controls.Add(textBox4);
            ShowPanel.Controls.Add(label7);
            ShowPanel.Controls.Add(monthCalendar2);
            ShowPanel.Controls.Add(comboBoxGender);
            ShowPanel.Controls.Add(genderLabel);
            ShowPanel.Controls.Add(ageLabel);
            ShowPanel.Controls.Add(surnameLabel);
            ShowPanel.Controls.Add(label6);
            ShowPanel.Controls.Add(ProductsList);
            ShowPanel.Controls.Add(SaveButton);
            ShowPanel.Controls.Add(EditButton);
            ShowPanel.Controls.Add(closeButton);
            ShowPanel.Location = new Point(146, 66);
            ShowPanel.Name = "ShowPanel";
            ShowPanel.Size = new Size(614, 393);
            ShowPanel.TabIndex = 17;
            ShowPanel.Visible = false;
            ShowPanel.Paint += ShowPanel_Paint;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(85, 67);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(89, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(85, 35);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(89, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(85, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(89, 23);
            textBox4.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSteelBlue;
            label7.Location = new Point(85, 139);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 10;
            label7.Text = "Select Birthday";
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(7, 163);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 9;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female", "Other." });
            comboBoxGender.Location = new Point(85, 96);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(87, 23);
            comboBoxGender.TabIndex = 8;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.LightSteelBlue;
            genderLabel.Location = new Point(20, 99);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(45, 15);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.LightSteelBlue;
            ageLabel.Location = new Point(20, 67);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(31, 15);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Age:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.BackColor = Color.LightSteelBlue;
            surnameLabel.Location = new Point(20, 38);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(57, 15);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Surname:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSteelBlue;
            label6.Location = new Point(20, 13);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 4;
            label6.Text = "Name:";
            // 
            // ProductsList
            // 
            ProductsList.FormattingEnabled = true;
            ProductsList.ItemHeight = 15;
            ProductsList.Location = new Point(246, 156);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(350, 169);
            ProductsList.TabIndex = 3;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.MediumSpringGreen;
            SaveButton.Location = new Point(512, 334);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(84, 46);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(255, 255, 128);
            EditButton.Location = new Point(512, 108);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(82, 38);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Crimson;
            closeButton.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.ActiveCaptionText;
            closeButton.Location = new Point(576, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(31, 25);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // ShowInfoProductPanel
            // 
            ShowInfoProductPanel.BackColor = Color.CornflowerBlue;
            ShowInfoProductPanel.Controls.Add(SaveProductsButton);
            ShowInfoProductPanel.Controls.Add(EditProductsButton);
            ShowInfoProductPanel.Controls.Add(textBox1);
            ShowInfoProductPanel.Controls.Add(label18);
            ShowInfoProductPanel.Controls.Add(textBox2);
            ShowInfoProductPanel.Controls.Add(label19);
            ShowInfoProductPanel.Controls.Add(CloseInfoProductButton);
            ShowInfoProductPanel.Location = new Point(274, 63);
            ShowInfoProductPanel.Name = "ShowInfoProductPanel";
            ShowInfoProductPanel.Size = new Size(494, 274);
            ShowInfoProductPanel.TabIndex = 8;
            ShowInfoProductPanel.Paint += ShowInfoProductPanel_Paint;
            // 
            // SaveProductsButton
            // 
            SaveProductsButton.Location = new Point(22, 176);
            SaveProductsButton.Name = "SaveProductsButton";
            SaveProductsButton.Size = new Size(99, 44);
            SaveProductsButton.TabIndex = 9;
            SaveProductsButton.Text = "Save";
            SaveProductsButton.UseVisualStyleBackColor = true;
            SaveProductsButton.Click += SaveProductsButton_Click;
            // 
            // EditProductsButton
            // 
            EditProductsButton.Location = new Point(24, 120);
            EditProductsButton.Name = "EditProductsButton";
            EditProductsButton.Size = new Size(97, 40);
            EditProductsButton.TabIndex = 8;
            EditProductsButton.Text = "Edit";
            EditProductsButton.UseVisualStyleBackColor = true;
            EditProductsButton.Click += EditProductsButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 23);
            textBox1.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.LightBlue;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(24, 65);
            label18.Name = "label18";
            label18.Size = new Size(116, 21);
            label18.TabIndex = 6;
            label18.Text = "Product's price:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 23);
            textBox2.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.LightBlue;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(20, 31);
            label19.Name = "label19";
            label19.Size = new Size(121, 21);
            label19.TabIndex = 4;
            label19.Text = "Product's name:";
            // 
            // CloseInfoProductButton
            // 
            CloseInfoProductButton.BackColor = Color.Crimson;
            CloseInfoProductButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CloseInfoProductButton.Location = new Point(455, 3);
            CloseInfoProductButton.Name = "CloseInfoProductButton";
            CloseInfoProductButton.Size = new Size(36, 27);
            CloseInfoProductButton.TabIndex = 0;
            CloseInfoProductButton.Text = "X";
            CloseInfoProductButton.UseVisualStyleBackColor = false;
            CloseInfoProductButton.Click += button1_Click;
            // 
            // SellPanel
            // 
            SellPanel.BackColor = Color.CornflowerBlue;
            SellPanel.Controls.Add(FinishOrderButton);
            SellPanel.Controls.Add(ClearCartButton);
            SellPanel.Controls.Add(DeleteItemFromCart);
            SellPanel.Controls.Add(AddToCart);
            SellPanel.Controls.Add(personsCart_ListBox);
            SellPanel.Controls.Add(ProductsPrice);
            SellPanel.Controls.Add(ProductsName);
            SellPanel.Controls.Add(customersSurname);
            SellPanel.Controls.Add(customersName);
            SellPanel.Controls.Add(label12);
            SellPanel.Controls.Add(label11);
            SellPanel.Controls.Add(SellButtonPanel);
            SellPanel.Controls.Add(label10);
            SellPanel.Controls.Add(label9);
            SellPanel.Controls.Add(label8);
            SellPanel.Controls.Add(products_ListBox);
            SellPanel.Controls.Add(persons_sellPanel_Label);
            SellPanel.Controls.Add(Persons_ListBoxPanel);
            SellPanel.Dock = DockStyle.Fill;
            SellPanel.Location = new Point(0, 0);
            SellPanel.Name = "SellPanel";
            SellPanel.Size = new Size(821, 507);
            SellPanel.TabIndex = 19;
            // 
            // FinishOrderButton
            // 
            FinishOrderButton.BackColor = Color.PaleGreen;
            FinishOrderButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FinishOrderButton.ForeColor = SystemColors.ControlText;
            FinishOrderButton.Location = new Point(708, 448);
            FinishOrderButton.Name = "FinishOrderButton";
            FinishOrderButton.Size = new Size(95, 32);
            FinishOrderButton.TabIndex = 19;
            FinishOrderButton.Text = "Finish order";
            FinishOrderButton.UseVisualStyleBackColor = false;
            // 
            // ClearCartButton
            // 
            ClearCartButton.BackColor = Color.OrangeRed;
            ClearCartButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClearCartButton.ForeColor = SystemColors.ControlLightLight;
            ClearCartButton.Location = new Point(704, 372);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(100, 34);
            ClearCartButton.TabIndex = 18;
            ClearCartButton.Text = "Clear all cart";
            ClearCartButton.UseVisualStyleBackColor = false;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // DeleteItemFromCart
            // 
            DeleteItemFromCart.BackColor = Color.Crimson;
            DeleteItemFromCart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteItemFromCart.ForeColor = SystemColors.ControlLightLight;
            DeleteItemFromCart.Location = new Point(704, 326);
            DeleteItemFromCart.Name = "DeleteItemFromCart";
            DeleteItemFromCart.Size = new Size(99, 34);
            DeleteItemFromCart.TabIndex = 17;
            DeleteItemFromCart.Text = "Delete";
            DeleteItemFromCart.UseVisualStyleBackColor = false;
            DeleteItemFromCart.Click += DeleteItemFromCart_Click;
            // 
            // AddToCart
            // 
            AddToCart.BackColor = Color.Orange;
            AddToCart.Location = new Point(708, 189);
            AddToCart.Name = "AddToCart";
            AddToCart.Size = new Size(95, 43);
            AddToCart.TabIndex = 16;
            AddToCart.Text = "Add to cart";
            AddToCart.UseVisualStyleBackColor = false;
            AddToCart.Click += AddToCart_Click;
            // 
            // personsCart_ListBox
            // 
            personsCart_ListBox.FormattingEnabled = true;
            personsCart_ListBox.ItemHeight = 15;
            personsCart_ListBox.Location = new Point(343, 326);
            personsCart_ListBox.Name = "personsCart_ListBox";
            personsCart_ListBox.Size = new Size(335, 154);
            personsCart_ListBox.TabIndex = 15;
            // 
            // ProductsPrice
            // 
            ProductsPrice.AutoSize = true;
            ProductsPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductsPrice.Location = new Point(392, 288);
            ProductsPrice.Name = "ProductsPrice";
            ProductsPrice.Size = new Size(16, 21);
            ProductsPrice.TabIndex = 13;
            ProductsPrice.Text = "-";
            // 
            // ProductsName
            // 
            ProductsName.AutoSize = true;
            ProductsName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductsName.Location = new Point(399, 264);
            ProductsName.Name = "ProductsName";
            ProductsName.Size = new Size(16, 21);
            ProductsName.TabIndex = 12;
            ProductsName.Text = "-";
            // 
            // customersSurname
            // 
            customersSurname.AutoSize = true;
            customersSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customersSurname.Location = new Point(89, 290);
            customersSurname.Name = "customersSurname";
            customersSurname.Size = new Size(16, 21);
            customersSurname.TabIndex = 11;
            customersSurname.Text = "-";
            // 
            // customersName
            // 
            customersName.AutoSize = true;
            customersName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customersName.Location = new Point(75, 266);
            customersName.Name = "customersName";
            customersName.Size = new Size(16, 21);
            customersName.TabIndex = 10;
            customersName.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.PowderBlue;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(343, 288);
            label12.Name = "label12";
            label12.Size = new Size(43, 19);
            label12.TabIndex = 9;
            label12.Text = "Price:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.PowderBlue;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(344, 264);
            label11.Name = "label11";
            label11.Size = new Size(49, 19);
            label11.TabIndex = 8;
            label11.Text = "Name:";
            // 
            // SellButtonPanel
            // 
            SellButtonPanel.BackColor = Color.MediumVioletRed;
            SellButtonPanel.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SellButtonPanel.ForeColor = SystemColors.ControlLightLight;
            SellButtonPanel.Location = new Point(18, 379);
            SellButtonPanel.Name = "SellButtonPanel";
            SellButtonPanel.Size = new Size(109, 39);
            SellButtonPanel.TabIndex = 7;
            SellButtonPanel.Text = "Sell";
            SellButtonPanel.UseVisualStyleBackColor = false;
            SellButtonPanel.Click += SellButtonPanel_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.PowderBlue;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(18, 290);
            label10.Name = "label10";
            label10.Size = new Size(65, 19);
            label10.TabIndex = 6;
            label10.Text = "Surname:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.PowderBlue;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(18, 266);
            label9.Name = "label9";
            label9.Size = new Size(49, 19);
            label9.TabIndex = 5;
            label9.Text = "Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.PowderBlue;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(344, 22);
            label8.Name = "label8";
            label8.Size = new Size(63, 19);
            label8.TabIndex = 4;
            label8.Text = "Products";
            // 
            // products_ListBox
            // 
            products_ListBox.FormattingEnabled = true;
            products_ListBox.ItemHeight = 15;
            products_ListBox.Location = new Point(344, 55);
            products_ListBox.Name = "products_ListBox";
            products_ListBox.Size = new Size(334, 184);
            products_ListBox.TabIndex = 3;
            products_ListBox.SelectedIndexChanged += products_ListBox_SelectedIndexChanged;
            // 
            // persons_sellPanel_Label
            // 
            persons_sellPanel_Label.AutoSize = true;
            persons_sellPanel_Label.BackColor = Color.PowderBlue;
            persons_sellPanel_Label.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            persons_sellPanel_Label.Location = new Point(10, 25);
            persons_sellPanel_Label.Name = "persons_sellPanel_Label";
            persons_sellPanel_Label.Size = new Size(57, 19);
            persons_sellPanel_Label.TabIndex = 2;
            persons_sellPanel_Label.Text = "Persons";
            // 
            // Persons_ListBoxPanel
            // 
            Persons_ListBoxPanel.FormattingEnabled = true;
            Persons_ListBoxPanel.ItemHeight = 15;
            Persons_ListBoxPanel.Location = new Point(10, 57);
            Persons_ListBoxPanel.Name = "Persons_ListBoxPanel";
            Persons_ListBoxPanel.Size = new Size(306, 184);
            Persons_ListBoxPanel.TabIndex = 1;
            Persons_ListBoxPanel.SelectedIndexChanged += Persons_ListBoxPanel_SelectedIndexChanged;
            // 
            // productsPanel
            // 
            productsPanel.BackColor = Color.BlueViolet;
            productsPanel.Controls.Add(ShowInfoProductPanel);
            productsPanel.Controls.Add(productsListBox1);
            productsPanel.Controls.Add(ShowInfoProductButton);
            productsPanel.Controls.Add(DeleteProductButton);
            productsPanel.Controls.Add(AddProductButton);
            productsPanel.Controls.Add(TextBoxProductsPrice);
            productsPanel.Controls.Add(label5);
            productsPanel.Controls.Add(textBoxProductName);
            productsPanel.Controls.Add(label4);
            productsPanel.Location = new Point(0, 0);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(820, 507);
            productsPanel.TabIndex = 21;
            productsPanel.Paint += productsPanel_Paint;
            // 
            // productsListBox1
            // 
            productsListBox1.FormattingEnabled = true;
            productsListBox1.ItemHeight = 15;
            productsListBox1.Location = new Point(22, 116);
            productsListBox1.Name = "productsListBox1";
            productsListBox1.Size = new Size(739, 244);
            productsListBox1.TabIndex = 4;
            productsListBox1.SelectedIndexChanged += productsListBox1_SelectedIndexChanged;
            // 
            // ShowInfoProductButton
            // 
            ShowInfoProductButton.Location = new Point(26, 448);
            ShowInfoProductButton.Name = "ShowInfoProductButton";
            ShowInfoProductButton.Size = new Size(112, 47);
            ShowInfoProductButton.TabIndex = 7;
            ShowInfoProductButton.Text = "Show info";
            ShowInfoProductButton.UseVisualStyleBackColor = true;
            ShowInfoProductButton.Click += ShowInfoProductButton_Click;
            // 
            // DeleteProductButton
            // 
            DeleteProductButton.Location = new Point(662, 448);
            DeleteProductButton.Name = "DeleteProductButton";
            DeleteProductButton.Size = new Size(102, 47);
            DeleteProductButton.TabIndex = 6;
            DeleteProductButton.Text = "Delete";
            DeleteProductButton.UseVisualStyleBackColor = true;
            DeleteProductButton.Click += DeleteProductButton_Click;
            // 
            // AddProductButton
            // 
            AddProductButton.Location = new Point(649, 55);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(108, 41);
            AddProductButton.TabIndex = 5;
            AddProductButton.Text = "Add";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // TextBoxProductsPrice
            // 
            TextBoxProductsPrice.Location = new Point(155, 58);
            TextBoxProductsPrice.Name = "TextBoxProductsPrice";
            TextBoxProductsPrice.Size = new Size(91, 23);
            TextBoxProductsPrice.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightBlue;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 57);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 2;
            label5.Text = "Product's price:";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(156, 25);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(91, 23);
            textBoxProductName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightBlue;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 23);
            label4.Name = "label4";
            label4.Size = new Size(121, 21);
            label4.TabIndex = 0;
            label4.Text = "Product's name:";
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.DarkTurquoise;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Indigo;
            splitContainer1.Panel1.Controls.Add(SellingsShowButton);
            splitContainer1.Panel1.Controls.Add(ProductsShowButton);
            splitContainer1.Panel1.Controls.Add(PersonsShowButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SellPanel);
            splitContainer1.Panel2.Controls.Add(productsPanel);
            splitContainer1.Panel2.Controls.Add(PersonsPanel);
            splitContainer1.Size = new Size(944, 507);
            splitContainer1.SplitterDistance = 119;
            splitContainer1.TabIndex = 20;
            // 
            // SellingsShowButton
            // 
            SellingsShowButton.Location = new Point(9, 100);
            SellingsShowButton.Name = "SellingsShowButton";
            SellingsShowButton.Size = new Size(94, 29);
            SellingsShowButton.TabIndex = 2;
            SellingsShowButton.Text = "Sell";
            SellingsShowButton.UseVisualStyleBackColor = true;
            SellingsShowButton.Click += SellingsShowButton_Click;
            // 
            // ProductsShowButton
            // 
            ProductsShowButton.Location = new Point(7, 61);
            ProductsShowButton.Name = "ProductsShowButton";
            ProductsShowButton.Size = new Size(95, 28);
            ProductsShowButton.TabIndex = 1;
            ProductsShowButton.Text = "Products";
            ProductsShowButton.UseVisualStyleBackColor = true;
            ProductsShowButton.Click += ProductsShowButton_Click;
            // 
            // PersonsShowButton
            // 
            PersonsShowButton.Location = new Point(7, 22);
            PersonsShowButton.Name = "PersonsShowButton";
            PersonsShowButton.Size = new Size(95, 28);
            PersonsShowButton.TabIndex = 0;
            PersonsShowButton.Text = "Persons";
            PersonsShowButton.UseVisualStyleBackColor = true;
            PersonsShowButton.Click += PersonsShowButton_Click;
            // 
            // PersonsPanel
            // 
            PersonsPanel.BackColor = Color.DarkOrchid;
            PersonsPanel.Controls.Add(label3);
            PersonsPanel.Controls.Add(label2);
            PersonsPanel.Controls.Add(label1);
            PersonsPanel.Controls.Add(ShowPanel);
            PersonsPanel.Controls.Add(monthCalendarMain);
            PersonsPanel.Controls.Add(GenderComboBoxMain);
            PersonsPanel.Controls.Add(label14);
            PersonsPanel.Controls.Add(label15);
            PersonsPanel.Controls.Add(label16);
            PersonsPanel.Controls.Add(label17);
            PersonsPanel.Controls.Add(textBox7);
            PersonsPanel.Controls.Add(textBox8);
            PersonsPanel.Controls.Add(textBox9);
            PersonsPanel.Controls.Add(DeletePersonButton);
            PersonsPanel.Controls.Add(AddPersonButton);
            PersonsPanel.Controls.Add(personsListBoxMain);
            PersonsPanel.Controls.Add(label13);
            PersonsPanel.Controls.Add(ShowInfoButton);
            PersonsPanel.Location = new Point(0, 0);
            PersonsPanel.Name = "PersonsPanel";
            PersonsPanel.Size = new Size(820, 507);
            PersonsPanel.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 100);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 36;
            label3.Text = "Gender:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 71);
            label2.Name = "label2";
            label2.Size = new Size(37, 19);
            label2.TabIndex = 35;
            label2.Text = "Age:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 34;
            label1.Text = "Name:";
            // 
            // monthCalendarMain
            // 
            monthCalendarMain.Location = new Point(24, 181);
            monthCalendarMain.Name = "monthCalendarMain";
            monthCalendarMain.TabIndex = 30;
            // 
            // GenderComboBoxMain
            // 
            GenderComboBoxMain.Cursor = Cursors.Hand;
            GenderComboBoxMain.FormattingEnabled = true;
            GenderComboBoxMain.Items.AddRange(new object[] { "Male", "Female", "Other." });
            GenderComboBoxMain.Location = new Point(103, 104);
            GenderComboBoxMain.Margin = new Padding(3, 2, 3, 2);
            GenderComboBoxMain.Name = "GenderComboBoxMain";
            GenderComboBoxMain.Size = new Size(133, 23);
            GenderComboBoxMain.TabIndex = 29;
            GenderComboBoxMain.Text = "Select";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(192, 192, 255);
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(-185, 2);
            label14.Name = "label14";
            label14.Size = new Size(54, 19);
            label14.TabIndex = 28;
            label14.Text = "Gender";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(192, 192, 255);
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(-185, -24);
            label15.Name = "label15";
            label15.Size = new Size(37, 19);
            label15.TabIndex = 27;
            label15.Text = "Age:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(192, 192, 255);
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(24, 46);
            label16.Name = "label16";
            label16.Size = new Size(65, 19);
            label16.TabIndex = 26;
            label16.Text = "Surname:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(192, 192, 255);
            label17.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(-185, -70);
            label17.Name = "label17";
            label17.Size = new Size(49, 19);
            label17.TabIndex = 25;
            label17.Text = "Name:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(103, 74);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(53, 23);
            textBox7.TabIndex = 24;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(103, 46);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 23);
            textBox8.TabIndex = 23;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(103, 18);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 23);
            textBox9.TabIndex = 22;
            // 
            // DeletePersonButton
            // 
            DeletePersonButton.BackColor = Color.IndianRed;
            DeletePersonButton.Cursor = Cursors.Hand;
            DeletePersonButton.Location = new Point(640, 397);
            DeletePersonButton.Margin = new Padding(3, 2, 3, 2);
            DeletePersonButton.Name = "DeletePersonButton";
            DeletePersonButton.Size = new Size(97, 30);
            DeletePersonButton.TabIndex = 21;
            DeletePersonButton.Text = "Delete person";
            DeletePersonButton.UseVisualStyleBackColor = false;
            DeletePersonButton.Click += DeletePersonButton_Click;
            // 
            // AddPersonButton
            // 
            AddPersonButton.BackColor = Color.Chartreuse;
            AddPersonButton.Cursor = Cursors.Hand;
            AddPersonButton.Location = new Point(634, 74);
            AddPersonButton.Margin = new Padding(3, 2, 3, 2);
            AddPersonButton.Name = "AddPersonButton";
            AddPersonButton.Size = new Size(102, 29);
            AddPersonButton.TabIndex = 20;
            AddPersonButton.Text = "Add person";
            AddPersonButton.UseVisualStyleBackColor = false;
            AddPersonButton.Click += AddPersonButton_Click;
            // 
            // personsListBoxMain
            // 
            personsListBoxMain.BackColor = Color.WhiteSmoke;
            personsListBoxMain.FormattingEnabled = true;
            personsListBoxMain.ItemHeight = 15;
            personsListBoxMain.Location = new Point(274, 153);
            personsListBoxMain.Margin = new Padding(3, 2, 3, 2);
            personsListBoxMain.Name = "personsListBoxMain";
            personsListBoxMain.Size = new Size(463, 214);
            personsListBoxMain.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 192, 255);
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(75, 153);
            label13.Name = "label13";
            label13.Size = new Size(132, 19);
            label13.TabIndex = 32;
            label13.Text = "Select your Birthday";
            // 
            // ShowInfoButton
            // 
            ShowInfoButton.BackColor = Color.Plum;
            ShowInfoButton.Location = new Point(36, 397);
            ShowInfoButton.Name = "ShowInfoButton";
            ShowInfoButton.Size = new Size(120, 36);
            ShowInfoButton.TabIndex = 31;
            ShowInfoButton.Text = "Show Info";
            ShowInfoButton.UseVisualStyleBackColor = false;
            ShowInfoButton.Click += ShowInfoButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(944, 507);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ShowPanel.ResumeLayout(false);
            ShowPanel.PerformLayout();
            ShowInfoProductPanel.ResumeLayout(false);
            ShowInfoProductPanel.PerformLayout();
            SellPanel.ResumeLayout(false);
            SellPanel.PerformLayout();
            productsPanel.ResumeLayout(false);
            productsPanel.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            PersonsPanel.ResumeLayout(false);
            PersonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel ShowPanel;
        private ListBox ProductsList;
        private Button SaveButton;
        private Button EditButton;
        private Button closeButton;
        private Label genderLabel;
        private Label ageLabel;
        private Label surnameLabel;
        private Label label6;
        private Label label7;
        private MonthCalendar monthCalendar2;
        private ComboBox comboBoxGender;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Panel SellPanel;
        private ListBox Persons_ListBoxPanel;
        private ListBox products_ListBox;
        private Label persons_sellPanel_Label;
        private Label label8;
        private Label label12;
        private Label label11;
        private Button SellButtonPanel;
        private Label label10;
        private Label label9;
        private SplitContainer splitContainer1;
        private Button SellingsShowButton;
        private Button ProductsShowButton;
        private Button PersonsShowButton;
        private Panel PersonsPanel;
        private Label label13;
        private Button ShowInfoButton;
        private MonthCalendar monthCalendarMain;
        private ComboBox GenderComboBoxMain;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button DeletePersonButton;
        private Button AddPersonButton;
        private ListBox personsListBoxMain;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label customersName;
        private Label customersSurname;
        private Label ProductsName;
        private Label ProductsPrice;
        private Panel productsPanel;
        private Label label4;
        private Button ShowInfoProductButton;
        private Button DeleteProductButton;
        private Button AddProductButton;
        private ListBox productsListBox1;
        private TextBox TextBoxProductsPrice;
        private Label label5;
        private TextBox textBoxProductName;
        private Panel ShowInfoProductPanel;
        private Button CloseInfoProductButton;
        private TextBox textBox1;
        private Label label18;
        private TextBox textBox2;
        private Label label19;
        private Button EditProductsButton;
        private Button SaveProductsButton;
        private ListBox personsCart_ListBox;
        private Button DeleteItemFromCart;
        private Button AddToCart;
        private Button FinishOrderButton;
        private Button ClearCartButton;
    }
}