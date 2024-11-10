
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.DataLayer;
using PROJECT.StudentAdmin;
using System.IO;

namespace PROJECT
{
    public partial class Form1 : Form
    {
        StudentPortal portal;
        public void run()
        {
            string name = txtName.Text;
            string course = cmbCourse.Text;
            int age = int.Parse(txtAge.Text);
            int id = int.Parse(txtID.Text);

            portal = new StudentPortal(name, age, course);
        }

        public Form1()
        {
            InitializeComponent();
            DataHandler handler = new DataHandler();
            List<string> list = handler.read();
            portal = new StudentPortal("NoName", 0, "No_Course");
            txtID.Text = (int.Parse(list[list.Count - 1].Split(',')[0]) + 1).ToString();
            txtID.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCourseComboBox();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStudents.DataSource = portal.DisplayAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentCell != null)
            {
                int rowIndex = dgvStudents.CurrentCell.RowIndex;
                if (rowIndex >= 0)
                {
                    int studentId = int.Parse(dgvStudents.Rows[rowIndex].Cells[0].Value.ToString());
                    portal.removeUser(studentId);
                    dgvStudents.DataSource = portal.DisplayAll();
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                int rowIndex = dgvStudents.CurrentRow.Index;
                txtID.Text = dgvStudents.Rows[rowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvStudents.Rows[rowIndex].Cells[1].Value.ToString();
                txtAge.Text = dgvStudents.Rows[rowIndex].Cells[2].Value.ToString();
                cmbCourse.Text = dgvStudents.Rows[rowIndex].Cells[3].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string course = cmbCourse.Text;
            string ageText = txtAge.Text;
            txtID.Enabled = false;


            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(course) || string.IsNullOrWhiteSpace(ageText))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                int age = int.Parse(ageText);


                portal = new StudentPortal(name, age, course);
                portal.AddNewUser();

                MessageBox.Show($"{txtName.Text} was added successfully.");

                dgvStudents.DataSource = portal.DisplayAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops. There was a problem: " + ex.Message);
            }

            txtName.Clear();
            txtAge.Clear();
            DataHandler handler = new DataHandler();
            List<string> list = handler.read();
            txtID.Text = (int.Parse(list[list.Count - 1].Split(',')[0]) + 1).ToString();
            txtName.Focus();
            cmbCourse.Text = "";
        }


        private void lblRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvUpdate.DataSource = portal.DisplayAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentCell != null)
            {
                int rowIndex = dgvStudents.CurrentCell.RowIndex;
                if (rowIndex >= 0)
                {
                    int studentId = int.Parse(dgvStudents.Rows[rowIndex].Cells[0].Value.ToString());
                    portal.removeUser(studentId);
                    dgvStudents.DataSource = portal.DisplayAll();
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            dgvStudents.DataSource = portal.DisplayAll();
        }

        private int lastClickedRow = -1;
        private int lastClickedColumn = -1;

        private void dgvUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                lastClickedRow = e.RowIndex;
                lastClickedColumn = e.ColumnIndex;
                txtShow.Text = dgvUpdate.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();


            string[] lines = File.ReadAllLines("StudentDetails.txt");

            string idToUpdate = txtShow.Text;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(idToUpdate))
                {
                    MessageBox.Show("Take note that when updating info if you would like to keep it the same re write it as it was do not leave it empty");

                    string Name = Microsoft.VisualBasic.Interaction.InputBox("Please enter updated name:", "Updating student info");
                    string Age = Microsoft.VisualBasic.Interaction.InputBox("Please enter updated age:", "Updating student info");
                    string Course = Microsoft.VisualBasic.Interaction.InputBox("Please enter updated course:", "Updating student info");

                    lines[i] = $"{idToUpdate},{Name},{Age},{Course}";
                    File.WriteAllLines("StudentDetails.txt", lines);
                    MessageBox.Show("Your information has been updated succesfully !");
                    return; 
                }
            }

            MessageBox.Show("ID not found.");

        }



        private void TxtCountStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCountStudent_Click(object sender, EventArgs e)
        {
            int lineCount = File.ReadAllLines("StudentDetails.txt").Length - 1;
            TxtCountStudent.Text = lineCount.ToString();

            

        }

        private void BtnAvgAge_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("StudentDetails.txt");

            int totalAge = 0;
            int studentCount = 0;

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3 && int.TryParse(parts[2], out int age))
                {
                    totalAge += age;
                    studentCount++;
                }
                else
                {
                    // Handle invalid age values, e.g., log an error or skip the line
                    Console.WriteLine("Invalid age value in line: " + line);
                }
            }

            int averageAge = (int)totalAge / studentCount;
            TxtAvgAge.Text = averageAge.ToString();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            string path = "summary.txt";

            FileStream mystream = new FileStream(path, FileMode.Create); 
            StreamWriter sw = new StreamWriter(mystream); 

            sw.WriteLine("Welcome to the summary report");
            sw.WriteLine("==============================");

            sw.WriteLine("Total number of students are:");
            sw.WriteLine($"{TxtCountStudent.Text}"); 

            sw.WriteLine("");

            sw.WriteLine("Average age of students is:");
            sw.WriteLine($"{TxtAvgAge.Text}");

            sw.Close();
            mystream.Close();

            MessageBox.Show("A report has successfully been created named 'summary'");
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PopulateCourseComboBox()
        {
            DataHandler handler = new DataHandler();

            try
            {
                // Get the list of unique courses from the DataHandler
                List<string> courses = handler.GetUniqueCourses();

                // Populate the ComboBox with these courses
                cmbCourse.Items.Clear();
                cmbCourse.Items.AddRange(courses.ToArray());
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
