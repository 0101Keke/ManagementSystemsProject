using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManagementSystemsProject.DataLayer
{
    public class ReportSummary
    {
        private readonly string filepath;

        public ReportSummary(string filepath)
        {
            this.filepath = filepath;
        }

        public int TotalStudents()
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    throw new FileNotFoundException("The student file was not found.");
                }

                var lines = File.ReadAllLines(filepath);
                return lines.Length;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch(Exception ex) 
            { 
                return 0; 
            }
        }

        public double AvgAge()
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    throw new FileNotFoundException("The student file was not found.");
                }

                string ages = File.ReadAllLines(filepath).Select(line =>
                {
                    var parts = line.Split(',');
                    if (parts.Length < 3 || !int.TryParse(parts[2], out int age))
                    {
                        throw new FormatException("Invalid data format for age.")
                    }
                    return age;
                }).ToList();

                return ages.Any() ? ages.Average() : 0;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("An error occured while calculating the average age: " + ex.Message);
                return 0; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured while calculating the average age: " + ex.Message);
                return 0;
            }
        }
    }

}
