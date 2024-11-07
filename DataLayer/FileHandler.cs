using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace ManagementSystemsProject.DataLayer
{
    internal class FileHandler
    {
       
        public FileHandler() 
        {}

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
    }
}
