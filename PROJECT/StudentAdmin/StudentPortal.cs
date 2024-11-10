using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.DataLayer;

namespace PROJECT.StudentAdmin
{
    class StudentPortal
    {
        DataHandler handler = new DataHandler();
        private int Id { get; set; }
        private string Name { get; set; }
        private int Age { get; set; }
        private string course { get; set; }

        private bool justDeleted = false;
        public StudentPortal(string name, int age, string course)
        {
            List<string> list = handler.read();
            this.Id = int.Parse(list[list.Count - 1].Split(',')[0]) + 1;
            this.Name = name;
            this.Age = age;
            this.course = course;
        }


        public string[] Search()
        {
            string[] arr = null;
            foreach (string line in handler.read())
            {
                arr = line.Split(',');
                if (arr[0] == this.Id.ToString())
                {
                    return arr;
                }
            }
            return null;
        }

        public void AddNewUser()
        {
            string add = $"{this.Id},{this.Name},{this.Age},{this.course}";

            handler.AddToFile(add, justDeleted);

            justDeleted = false;
        }

        public void Update(string[] newArr)
        {
            List<string> myList = handler.read();

            for (int i = 0; i < myList.Count; i++)
            {
                string[] arr = myList[i].Split(',');
                if (arr[0] == newArr[0])
                {
                    myList[i] = string.Join(",", newArr);
                    break;
                }
            }

            handler.ReWriteAll(myList);
        }

        public DataTable DisplayAll()
        {            
            List<string> myList = handler.read();
            DataTable dataTable = new DataTable();

            string[] headers = myList[0].Split(',');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }

            for (int i = 1; i < myList.Count; i++)
            {
                string[] row = myList[i].Split(',');
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        public void removeUser(int ID)
        {
            List<string> myList = handler.read();

            for (int i = 0; i < myList.Count; i++)
            {
                string[] arr = myList[i].Split(',');
                if (arr[0] == ID.ToString())
                {
                    myList.RemoveAt(i);
                    break;
                }
            }
            justDeleted = true;
            handler.ReWriteAll(myList);
        }

    }
}
