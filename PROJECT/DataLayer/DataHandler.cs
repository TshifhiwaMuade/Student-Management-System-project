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


        private void makeEmpty()
        {
            List<string> lines = File.ReadAllLines("StudentDetails.txt").ToList();
            lines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToList();
            ReWriteAll(lines);
        }


        public List<string> read()
        {
            makeEmpty();
            myList = File.ReadAllLines("StudentDetails.txt").ToList();
            return myList;
        }

        public void AddToFile(string OneLine, bool justDeleted)
        {
            if (!justDeleted)
            {
                File.AppendAllText("StudentDetails.txt", Environment.NewLine + OneLine);
            }
            else
            {
                File.AppendAllText("StudentDetails.txt", OneLine);
            }

        }

        public void ReWriteAll(List<string> list)
        {
            File.WriteAllLines("StudentDetails.txt", list);
        }

        public void createSummary(string lines)
        {
            File.WriteAllText("Summary.txt", lines);
        }

        private readonly string filePath = "StudentDetails.txt";

        public List<string> Read()
        {
            // Existing read method to read all data
            List<string> lines = new List<string>();

            if (File.Exists(filePath))
            {
                lines.AddRange(File.ReadAllLines(filePath));
            }
            else
            {
                throw new FileNotFoundException("The StudentDetails.txt file was not found.");
            }

            return lines;
        }

        public List<string> GetUniqueCourses()
        {
            // A HashSet with a case-insensitive comparer to store unique course names
            HashSet<string> courses = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // Read each line and extract the fourth column as the course name
            foreach (string line in Read())
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 4)
                {
                    string course = parts[3].Trim();
                    courses.Add(course); // HashSet will prevent duplicates, ignoring case
                }
            }

            return new List<string>(courses);
        }

    }
}
