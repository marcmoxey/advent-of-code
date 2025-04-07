using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Text.RegularExpressions;

namespace FileUtils
{
    public static class FileUtils
    {
        // Reads a file and splits each line into two separate lists
        public static (List<int> list1, List<int> list2) SplitFileIntoTwoLists(string filePath)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();

            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException($"File not found: {filePath}");

                foreach (var line in File.ReadLines(filePath))
                {
                    // Split by whitespace (space or tab)
                    var parts = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2)
                    {
                        list1.Add(int.Parse(parts[0]));
                        list2.Add(int.Parse(parts[1]));
                    }
                }

                return (list1, list2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing file: {ex.Message}");
                throw;
            }
        }


        public static string ReadFile(string filePath)
        {

            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException($"File not found: {filePath}");

                string lines = File.ReadAllText(filePath);
                return lines; 
          
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                throw;
            }


        }
    }
}


