using System;
using System.Reflection;
using System.Windows.Forms;

namespace personsList
{
    public partial class Form1 : Form
    {
        private List<Person> personsList = new List<Person>();
        private List<Product> productsList = new List<Product>();
        public Form1()
        {
            InitializeComponent();
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
            PersonsPanel.BringToFront();
        }



        private void SellingsShowButton_Click(object sender, EventArgs e)
        {

            SellPanel.BringToFront();
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

        private void PersonsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowPanel_Paint(object sender, PaintEventArgs e)
        {
            int index = personsListBoxMain.SelectedIndex;
            if (index != -1)
            {
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
            customersName.Text = personsList[index].Name; customersSurname.Text = personsList[index].Surname;
        }

        private void products_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Persons_ListBoxPanel.SelectedIndex;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ProductsShowButton_Click(object sender, EventArgs e)
        {
            productsPanel.BringToFront();
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
            textBox2.ForeColor = Color.Black;

        }

        private void ShowInfoProductPanel_Paint(object sender, PaintEventArgs e)
        {
            int index = productsListBox1.SelectedIndex;
            if (index != -1)
            {
                if (!textBox2.Enabled)
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
                productsList.RemoveAt(selectedIndex);
                Product product2 = new Product(textBox2.Text, Convert.ToDouble(textBox1.Text));
                productsList.Insert(selectedIndex, product2);
                productsListBox1.Items.Insert(selectedIndex, product2);
            }
            else
            {
                MessageBox.Show("No item selected or invalid selection.");
            }
            ShowPanel.Hide();
            EditButton_Click(sender, e);
        }

        private void productsPanel_Paint(object sender, PaintEventArgs e)
        {
           
           
        }
    }
}