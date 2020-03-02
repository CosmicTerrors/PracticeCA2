using System;

namespace PracticeCA2
{
    class Program
    {
        static double[] totalGradeBand = new double[6];
        static char[] gradeBands = new char[] { 'F', 'E', 'D', 'C', 'B', 'A' };
        static double[] gradeTotal = new double[6];
        static void Main(string[] args)
        {
            double counter = 0;
            char band = 'a';
            string input;
            double studentMark = 0;
            do
            {
                try
                {
                    Console.Write("Please input student mark: ");
                    input = Console.ReadLine();
                    if (input == "-999")
                    {
                        break;
                    }
                    studentMark = isDataValid(input);
                    band = getGradeBand(studentMark);
                    counter++;
                    Console.WriteLine("\nMark {0} Grade {1}\n", studentMark, band);
                }
                catch (Exception myError)
                {
                    Console.WriteLine(myError.Message);
                }
            } while (studentMark != -999);
            Console.WriteLine("\n{0, -10}{1,-20}\n", "Grade", "Number of Bands");
            for (int i = 0; i < totalGradeBand.Length; i++)
            {
                Console.WriteLine("{0, -10} {1, -20}", gradeBands[i] ,totalGradeBand[i]);
                double studentAverage = doAverage();
                Console.WriteLine("\nThe Average Mark for Grade {0} is {1}", gradeBands[i], studentAverage);
            }
        }

        static double isDataValid(string input)
        {
            if (input == "" || input == null)
            {
                throw new Exception("Data must not be Empty");
            }
            double studentMarks;
            studentMarks = double.Parse(input);
            if (studentMarks == -999)
            {
                return studentMarks;
            }
            else if ((studentMarks < 0 || studentMarks > 100))
            {
                throw new Exception("Data must be a positive number between 0 to 100");
            }
            else
            {
                return studentMarks;
            }
        }

        static double doAverage()
        {
            double average;
            
            return average;
        }

        static char getGradeBand(double studentMark)
        {
            char gradeBand = '.';
            if (studentMark > 79)
            {
                gradeBand = gradeBands[5];
                totalGradeBand[5]++;
                return gradeBand;
            }
            else if (studentMark > 70)
            {
                gradeBand = gradeBands[4];
                totalGradeBand[4]++;
                return gradeBand;
            }
            else if (studentMark > 60)
            {
                gradeBand = gradeBands[3];
                totalGradeBand[3]++;
                return gradeBand;
            }
            else if (studentMark > 50)
            {
                gradeBand = gradeBands[2];
                totalGradeBand[2]++;
                return gradeBand;
            }
            else if (studentMark > 40)
            {
                gradeBand = gradeBands[1];
                totalGradeBand[1]++;
                return gradeBand;
            }
            else
            {
                gradeBand = gradeBands[0];
                totalGradeBand[0]++;
                return gradeBand;
            }
        }
    }
    
}
