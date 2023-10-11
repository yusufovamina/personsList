using System;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace personsList
{
    public partial class Form1 : Form
    {
        private string dataFilePath = "data.dat";
        private List<Person> personsList = new List<Person>();
        private List<Product> productsList = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            ShowPanel.Hide(); EditButton_Click(sender, e);
        }



        private void monthCalendar2_Set()
        {
            int index = personsListBoxMain.SelectedIndex;
            if (index != -1)
            {
                monthCalendar2.SetDate(personsList[index].Birthday);
            }
        }
        private void genderComboBox_Set()
        {
            int index = personsListBoxMain.SelectedIndex;
            if (index != -1)
            {
                switch (personsList[index].Gender)
                {
                    case "Male":
                        comboBoxGender.SelectedIndex = 0;
                        break;
                    case "Female":
                        comboBoxGender.SelectedIndex = 1;
                        break;
                    case "Other.":
                        comboBoxGender.SelectedIndex = 2;
                        break;
                }
            }
        }


        private void textBox4_SetText()
        {

            int ind = personsListBoxMain.SelectedIndex;
            if (ind != -1)
            {

                textBox4.Text = personsList[ind].Name;
                textBox4.ForeColor = Color.Gray;

            }
            textBox4.ForeColor = Color.Black;

        }

        private void textBox5_SetText()
        {

            int ind = personsListBoxMain.SelectedIndex;
            if (ind != -1)
            {
                textBox5.Text = personsList[ind].Surname;
                textBox5.ForeColor = Color.Gray;
            }
            textBox5.ForeColor = Color.Black;
        }

        private void textBox6_SetText()
        {

            int ind = personsListBoxMain.SelectedIndex;
            if (ind != -1)
            {
                textBox6.Text = personsList[ind].Age.ToString();
                textBox6.ForeColor = Color.Gray;

            }
            textBox6.ForeColor = Color.Black;
        }


        private void LoadData()
        {
            try
            {
                using (FileStream fileStream = new FileStream(dataFilePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    personsList = (List<Person>)formatter.Deserialize(fileStream);
                    productsList = (List<Product>)formatter.Deserialize(fileStream);
                    UpdateListBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void SaveData()
        {
            try
            {
                using (FileStream fileStream = new FileStream(dataFilePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, personsList);
                    formatter.Serialize(fileStream, productsList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
        private void UpdateListBoxes()
        {
            personsListBoxMain.Items.Clear();
            Persons_ListBoxPanel.Items.Clear();

            foreach (Person person in personsList)
            {
                personsListBoxMain.Items.Add(person);
                Persons_ListBoxPanel.Items.Add(person);
            }

            productsListBox1.Items.Clear();
            products_ListBox.Items.Clear();

            foreach (Product product in productsList)
            {
                productsListBox1.Items.Add(product);
                products_ListBox.Items.Add(product);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPanel.Hide(); SellPanel.Hide(); EditButton_Click(sender, e);
            ShowInfoProductPanel.Hide(); EditProductsButton_Click(sender, e);
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = !textBox4.Enabled;
            textBox5.Enabled = !textBox5.Enabled;
            textBox6.Enabled = !textBox6.Enabled;
            comboBoxGender.Enabled = !comboBoxGender.Enabled;
            monthCalendar2.Enabled = !monthCalendar2.Enabled;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = personsListBoxMain.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < personsListBoxMain.Items.Count)
            {
                personsListBoxMain.Items.RemoveAt(selectedIndex);
                personsList.RemoveAt(selectedIndex);
                Person p2 = new Person(textBox4.Text, textBox5.Text, comboBoxGender.SelectedItem.ToString(), Convert.ToInt32(textBox6.Text), monthCalendar2.SelectionStart);
                personsList.Insert(selectedIndex, p2);
                personsListBoxMain.Items.Insert(selectedIndex, p2);
            }
            else
            {
                MessageBox.Show("No item selected or invalid selection.");
            }
            ShowPanel.Hide();
            EditButton_Click(sender, e);
        }



        private void Sell_Click(object sender, EventArgs e)
        {
            SellPanel.Show();
        }

        private void CloseButton2_Click(object sender, EventArgs e)
        {
            SellPanel.Hide();
        }




        private void PersonsShowButton_Click(object sender, EventArgs e)
        {
            productsPanel.Hide();
            SellPanel.Hide();
            PersonsPanel.Show();
        }



        private void SellingsShowButton_Click(object sender, EventArgs e)
        {
            PersonsPanel.Hide();
            productsPanel.Hide();
            SellPanel.Show();
        }



        private void AddPersonButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                !string.IsNullOrWhiteSpace(textBox7.Text) && !personsListBoxMain.Items.Contains(textBox9.Text) &&
                !personsListBoxMain.Items.Contains(textBox8.Text) && (GenderComboBoxMain.SelectedItem != null))
            {

                Person p1 = new Person(textBox9.Text, textBox8.Text, GenderComboBoxMain.SelectedItem.ToString(), Convert.ToInt32(textBox7.Text), monthCalendarMain.SelectionStart);
                personsList.Add(p1);
                personsListBoxMain.Items.Add(p1); Persons_ListBoxPanel.Items.Add(p1);

                textBox9.Clear(); textBox8.Clear(); textBox7.Clear();
                GenderComboBoxMain.SelectedIndex = -1;
                monthCalendarMain.SetDate(DateTime.Now);
                SaveData();
            }
            else
            {
                MessageBox.Show("All of the fields must be filled!");
            }
        }

        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            if (personsListBoxMain.SelectedIndex != -1)
            {
                int selectedIndex = personsListBoxMain.SelectedIndex;
                personsListBoxMain.Items.RemoveAt(selectedIndex);
                personsList.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Element was not selected!");
            }
        }

        private void ShowInfoButton_Click_1(object sender, EventArgs e)
        {
            if (textBox4.Enabled)
            {
                EditButton_Click(sender, e);
            }
            if (personsListBoxMain.SelectedIndex != -1)
            {
                ShowPanel.Show();
            }
            else
            {
                MessageBox.Show("Choose item to see infotmation!");
            }
        }


        private void BillsList_Set()
        {
            int ind = personsListBoxMain.SelectedIndex;
            if (ind != -1 && personsList[ind].Bills.Count != 0)
            {
                for (int i = 0; i < personsList[ind].Bills.Count; i++)
                {
                    ProductsList.Text = personsList[ind].Bills[i].ToString();

                }

            }
        }
        private void ShowPanel_Paint(object sender, PaintEventArgs e)
        {
            int index = personsListBoxMain.SelectedIndex;
            if (index != -1)
            {
                if (personsList[index].Bills != null) { BillsList_Set(); }
                if (!textBox4.Enabled)
                {
                    textBox4_SetText();
                    textBox5_SetText();
                    textBox6_SetText();
                    genderComboBox_Set();
                    monthCalendar2_Set();

                }
            }
            else
            {
                textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
                comboBoxGender.SelectedIndex = -1;
                monthCalendar2.SetDate(DateTime.Now);
            }
        }


        private void Persons_ListBoxPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Persons_ListBoxPanel.SelectedIndex;
            customersName.Text = personsList[index].Name;
            customersSurname.Text = personsList[index].Surname;
            personsCart_ListBox.Items.Clear();
            if (index != -1 && personsList[index].Cart != null)
            {
                for (int i = 0; i < personsList[index].Cart.Count; i++)
                {
                    personsCart_ListBox.Items.Add(personsList[i].Cart);
                }
            }
        }

        private void products_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = products_ListBox.SelectedIndex;
            ProductsName.Text = productsList[index].Name;
            ProductsPrice.Text = productsList[index].Price.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ProductsShowButton_Click(object sender, EventArgs e)
        {
            PersonsPanel.Hide();
            SellPanel.Hide();
            productsPanel.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxProductName.Text) && !string.IsNullOrWhiteSpace(TextBoxProductsPrice.Text) &&
                !productsListBox1.Items.Contains(textBoxProductName.Text) && !productsListBox1.Items.Contains(TextBoxProductsPrice.Text))
            {

                Product product = new Product(textBoxProductName.Text, Convert.ToDouble(TextBoxProductsPrice.Text));
                productsList.Add(product);
                productsListBox1.Items.Add(product);
                products_ListBox.Items.Add(product);
                SaveData();
                textBoxProductName.Clear(); TextBoxProductsPrice.Clear();
            }
            else
            {
                MessageBox.Show("All of the fields must be filled!");
            }
        }

        private void productsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowInfoProductButton_Click(object sender, EventArgs e)
        {

            ShowInfoProductPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowInfoProductPanel.Hide();
        }

        private void textBox2_SetText()
        {
            int ind = productsListBox1.SelectedIndex;
            if (ind != -1)
            {

                textBox2.Text = productsList[ind].Name;
                textBox2.ForeColor = Color.Gray;

            }
            textBox2.ForeColor = Color.Black;

        }
        private void textBox1_SetText()
        {
            int ind = productsListBox1.SelectedIndex;
            if (ind != -1)
            {

                textBox1.Text = productsList[ind].Price.ToString();
                textBox1.ForeColor = Color.Gray;

            }
            textBox1.ForeColor = Color.Black;

        }

        private void ShowInfoProductPanel_Paint(object sender, PaintEventArgs e)
        {
            int index = productsListBox1.SelectedIndex;
            if (index != -1)
            {
                if (!textBox2.Enabled && !textBox1.Enabled)
                {
                    textBox2_SetText();
                    textBox1_SetText();

                }
            }
            else
            {
                textBox2.Clear(); textBox1.Clear();
            }
        }

        private void EditProductsButton_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = !textBox2.Enabled;
            textBox1.Enabled = !textBox1.Enabled;



        }

        private void SaveProductsButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = productsListBox1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < productsListBox1.Items.Count)
            {
                productsListBox1.Items.RemoveAt(selectedIndex);
                products_ListBox.Items.RemoveAt(selectedIndex);
                productsList.RemoveAt(selectedIndex);
                Product product2 = new Product(textBox2.Text, Convert.ToDouble(textBox1.Text));
                productsList.Insert(selectedIndex, product2);
                products_ListBox.Items.Insert(selectedIndex, product2);
                productsListBox1.Items.Insert(selectedIndex, product2);
            }
            else
            {
                MessageBox.Show("No item selected or invalid selection.");
            }
            ShowInfoProductPanel.Hide();
            EditButton_Click(sender, e);
        }

        private void productsPanel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (productsListBox1.SelectedIndex != -1)
            {
                int selectedIndex = productsListBox1.SelectedIndex;
                productsListBox1.Items.RemoveAt(selectedIndex);
                productsList.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Element was not selected!");
            }
        }

        private void SellButtonPanel_Click(object sender, EventArgs e)
        {
            int pers_ind = Persons_ListBoxPanel.SelectedIndex;
            int product_ind = products_ListBox.SelectedIndex;

            if (pers_ind != -1 && product_ind != -1)
            {
                if (pers_ind < personsList.Count && product_ind < productsList.Count)
                {
                    Person p3 = personsList[pers_ind];
                    Product product = productsList[product_ind];
                    p3.Cart.Add(product);
                    MessageBox.Show("Successful operation");
                }
                else
                {
                    MessageBox.Show("Invalid selection");
                }
            }
            else
            {
                MessageBox.Show("Please select a person and a product");
            }
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            int pers_ind = Persons_ListBoxPanel.SelectedIndex;
            int product_ind = products_ListBox.SelectedIndex;
            if (pers_ind != -1 && product_ind != -1)
            {
                personsCart_ListBox.Items.Add(productsList[product_ind]);
                personsList[pers_ind].Cart.Add(productsList[product_ind]);
            }

        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            int pers_ind = Persons_ListBoxPanel.SelectedIndex;
            personsCart_ListBox.Items.Clear();
            personsList[pers_ind].Cart.Clear();
        }

        private void DeleteItemFromCart_Click(object sender, EventArgs e)
        {
            int pers_ind = Persons_ListBoxPanel.SelectedIndex;
            int bill_ind=personsCart_ListBox.SelectedIndex;
            personsCart_ListBox.Items.RemoveAt(bill_ind);
            personsList[pers_ind].Cart.RemoveAt(bill_ind);
        }
    }
}