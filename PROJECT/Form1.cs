
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

namespace PROJECT
{
    public partial class Form1 : Form
    {
        StudentPortal portal;
        public void run()
        {
            string name = txtName.Text;
            string course = txtCourse.Text;
            int age = int.Parse(txtAge.Text);
            int id = int.Parse(txtID.Text);

            portal = new StudentPortal(id, name, age, course);
        }
        public Form1()
        {
            InitializeComponent();
            portal = new StudentPortal(0,"NoName",0,"No_Course");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dgvStudents.DataSource = portal.DisplayAll();
            }
            catch(Exception ex)
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
            // Ensure there's a selected row
            if (dgvStudents.CurrentRow != null)
            {
                // Get the index of the selected row
                int rowIndex = dgvStudents.CurrentRow.Index;

                // Retrieve values from the selected row's cells
                txtID.Text = dgvStudents.Rows[rowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvStudents.Rows[rowIndex].Cells[1].Value.ToString();
                txtAge.Text = dgvStudents.Rows[rowIndex].Cells[2].Value.ToString();
                txtCourse.Text = dgvStudents.Rows[rowIndex].Cells[3].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string course = txtCourse.Text;
            int age = int.Parse(txtAge.Text);
            int id = int.Parse(txtID.Text);

            portal = new StudentPortal(id, name, age, course);

            try
            {
                portal.AddNewUser();
                MessageBox.Show($"{txtName.Text} was added succesfully.");
                dgvStudents.DataSource = portal.DisplayAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops. The was a problem");
            }
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
            if (lastClickedRow >= 0 && lastClickedColumn >= 0)
            {
                List<string> myList = handler.read();
                string[] arr = myList[lastClickedRow].Split(',');
                arr[lastClickedColumn] = txtShow.Text;
                myList[lastClickedRow] = string.Join(",", arr);
                handler.ReWriteAll(myList);
                StudentPortal portal = new StudentPortal(0, "", 0, "");
                dgvUpdate.DataSource = portal.DisplayAll();
            }
        }

    }
}
