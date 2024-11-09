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

       public List<string> makeEmpty()
        {
            myList = File.ReadAllLines("StudentDetails.txt")
                         .Where(line => !string.IsNullOrWhiteSpace(line))
                         .ToList();
                         
            ReWriteAll(myList);
            return myList;
        }


        public List<string> read()
        {
            myList = makeEmpty();
            return myList;
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
