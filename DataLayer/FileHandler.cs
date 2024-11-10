using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Data;


namespace ManagementSystemsProject.DataLayer
{
    internal class FileHandler
    {
       
        public FileHandler() 
        {}

        // "C:\\Users\\{Your windows username}\\source\\repos\\ManagementSystemsProject\\DataLayer\\students.txt";

        public static readonly string filePath = "C:\\Users\\user1\\source\\repos\\ManagementSystemsProject\\DataLayer\\students.txt";

        public void AddStudent(Student student) 
        {
            //Error Handling Section
            if (student.Age <= 0)
            {
                MessageBox.Show("Invalid age. Please enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for duplicate StudentID
            if (IsStudentIdDuplicate(student.StudentID))
            {
                MessageBox.Show("A student with this ID already exists. Please use a unique Student ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed to add the student
            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);


            sw.WriteLine(student.StudentID + "," + student.Name + "," + student.Age + "," + student.Course);

            sw.Close();
            fs.Close();




            try
            {
                MessageBox.Show("Added Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }  
        }

        /*public static List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    if (parts.Length == 4)
                    {
                        var student = new Student(int.Parse(parts[0]), parts[1], int.Parse(parts[2]), parts[3]);
                        students.Add(student);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("The students.txt file was not found.");
            }

            return students;
        }*/


        public static void ViewStudent()
        {
            if (File.Exists(filePath))
            {

                DataTable table = new DataTable();

                string[] lines = File.ReadAllLines(filePath); 

                string[] values;

                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split(',');
                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }
                    table.Rows.Add(row);
                }
            }
            else
            {
                throw new FileNotFoundException("The students.txt file was not found.");
            }
        }

        public static void UpdateStudent(Student updatedStudent)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException("The students.txt file was not found.");

            var lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (int.Parse(parts[0]) == updatedStudent.StudentID)
                {
                    // Update line with new student details
                    lines[i] = $"{updatedStudent.StudentID},{updatedStudent.Name},{updatedStudent.Age},{updatedStudent.Course}";
                    break;
                }
            }

            // Write updated data back to the file
            File.WriteAllLines(filePath, lines);
        }

        private bool IsStudentIdDuplicate(int studentId)
        {
            if (!File.Exists(filePath))
            {
                return false; // No file exists yet, so no duplicates are possible
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length > 0 && int.TryParse(parts[0], out int existingId) && existingId == studentId)
                {
                    return true; // Duplicate found
                }
            }

            return false; // No duplicate found
        }
    }
}
