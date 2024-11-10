using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;


namespace ManagementSystemsProject.DataLayer
{
    internal class FileHandler
    {
       
        public FileHandler() 
        {}

        // "C:\\Users\\{Your windows username}\\source\\repos\\ManagementSystemsProject\\DataLayer\\students.txt";

        public static readonly string filePath = "C:\\Users\\user1\\source\\repos\\ManagementSystemsProject\\DataLayer\\students.txt";

        public void AddStudent(Student student, string Path) 
        {
            FileStream fs = new FileStream(Path, FileMode.OpenOrCreate);
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

        public static List<Student> GetAllStudents()
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
    }
}
