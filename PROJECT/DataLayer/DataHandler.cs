using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT.DataLayer
{
    public class DataHandler
    {
        List<string> myList = new List<string>();
        public DataHandler()
        {
            // Empty handler
        }

        public List<string> read()
        {
            myList = File.ReadAllLines("StudentDetails.txt").ToList();
            return myList;
        }

        public void CountStudents()
        {
            int lineCount = File.ReadAllLines("StudentDetails.txt").Length - 1;
           // return lineCount.ToString();
          // TxtCountStudent.Text = lineCount.ToString();
          
        }

        public void AddToFile(string OneLine)
        {
            File.AppendAllText("StudentDetails.txt", Environment.NewLine + OneLine);
        }

        public void ReWriteAll(List<string> list)
        {
            File.WriteAllLines("StudentDetails.txt", list);
        }
    }
}
