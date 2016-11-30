using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shakespeare_Sonnet18
{
    public class program
    {
        static void Main(string[] args)
        {

            StreamReader reader = new StreamReader("Shakespeare.txt");
            string line;
            using (reader)
            {
                int lineNumber = 0;
                line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    line.ToUpper();

                    string uppercase = line.ToUpper();
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                    Console.ReadKey();
                }
                reader.ReadLine();
            }
            Console.WriteLine(reader.ReadToEnd());

        }
    }
}