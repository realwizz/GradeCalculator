using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            string moduleID;
            string moduleTitle;
            int moduleCredits;
            int moduleMark;
            int averageMark;
            int bestAverage;
            char overallGrade;

            //Read in data
            Console.WriteLine("Input the module ID");
            moduleID = Console.ReadLine();

            Console.WriteLine("Input the module title");
            moduleTitle = Console.ReadLine();

            Console.WriteLine("Input the module credits");
            moduleCredits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the module mark");
            moduleMark = Convert.ToInt32(Console.ReadLine());

            averageMark = (moduleID / moduleCredits);


            for (int i >= 70; i <= averageMark;)    
            {
                overallGrade = "A"
            }

            for (int i >= 60; i <= averageMark;)    
            {
                overallGrade = "B"
            }

            for (int i >= 50; i <= averageMark;)    
            {
                overallGrade = "C"
            }

            for (int i >= 45; i <= averageMark;)    
            {
                overallGrade = "D"
            }

            for (int i >= 40; i <= averageMark;)    
            {
                overallGrade = "E"
            }
            for (int i < 40; i <= averageMark;)    
            {
                overallGrade = "F"
            }

            Console.WriteLine("Your Average Mark is " + averageMark + ", and your Overall Grade is " + overallGrade);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
