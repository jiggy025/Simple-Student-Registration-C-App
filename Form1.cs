using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.Models;

namespace StudentRegistrationApplicatiom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            // Get inputs
            string lastname = textBox_Lastname.Text.Trim();
            string firstname = textBox_Firstname.Text.Trim();
            string middlename = textBox_Middlename.Text.Trim();
            string gender = radioButton_Male.Checked ? "Male" : radioButton_Female.Checked ? "Female" : "";

            string day = cbDay.SelectedItem.ToString();
            string month = cbMonth.SelectedItem.ToString();
            string year = cbYear.SelectedItem.ToString();

            // Basic validation
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(gender)
                || day == "-Day-" || month == "-Month-" || year == "-Year-")
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            // Parse date of birth
            DateTime dob = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

            // Create Student object
            Student.Models.Student student = new Student.Models.Student(firstname, middlename, lastname, gender, dob);

            // Add to ListBox
            listBox_Students.Items.Add(student);

            // Optional: clear inputs
            textBox_Lastname.Clear();
            textBox_Firstname.Clear();
            textBox_Middlename.Clear();
            radioButton_Male.Checked = false;
            radioButton_Female.Checked = false;
            cbDay.SelectedIndex = 0;
            cbMonth.SelectedIndex = 0;
            cbYear.SelectedIndex = 0;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                cbDay.Items.Add(i.ToString());
            }

            cbDay.Items.Insert(0, "-Day-");
            cbDay.SelectedIndex = 0;

            for (int i = 1; i <= 12; i++)
            {
                cbMonth.Items.Add(i.ToString());
            }

            cbMonth.Items.Insert(0, "-Month-");
            cbMonth.SelectedIndex = 0;

            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                cbYear.Items.Add(i.ToString());
            }

            cbYear.Items.Insert(0, "-Year-");
            cbYear.SelectedIndex = 0;
        }
    }
}

