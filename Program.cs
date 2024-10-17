using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Program
    {
        struct Module
        {
            public string moduleID;
            public string moduleTitle;
            public int moduleCredits;
            public double mark;

            public Module(string moduleid, string moduletitle, int modulecredits, double Mark)
            {
                moduleID = moduleid;
                moduleTitle = moduletitle;
                moduleCredits = modulecredits;
                mark = Mark;
            }
        }
        static void Main(string[] args)
        {
            const int numnberOfModules = 6;
            Module[] modules = new Module[numnberOfModules];

            //Input module data
            for (int i = 0; i < numnberOfModules; i++)
            {
                Console.WriteLine("Enter module details:");
                Console.Write("Module ID: ");
                string moduleid = Console.ReadLine();

                Console.Write("Module Title: ");
                string moduletitle = Console.ReadLine();

                Console.Write("Credits (20): ");
                int modulecredits = 20; //Fixed credits

                Console.Write("Mark: ");
                double mark = double.Parse(Console.ReadLine());

                modules[i] = new Module(moduleid, moduletitle, modulecredits, mark);
                Console.WriteLine();
            }

            double weightedAverage = CalculateWeightedAverage(modules);
            double bestAverage = CalculateBestAverage(modules);

            Console.WriteLine($"Weighted Average Mark: {weightedAverage:F2} - Classification: {GetClassification(weightedAverage)}\n"); //Used "\n" to create new line in oputput message
            Console.WriteLine($"Best Average Mark (after removing worst grade: {bestAverage:F2} - Classification: {GetClassification(bestAverage)}");
        }

        static double CalculateWeightedAverage(Module[] modules)
        {
            double totalWeightedMarks = 0;
            int totalCredits = 0;

            foreach (var module in modules)
            {
                totalWeightedMarks += module.mark * module.moduleCredits;
                totalCredits += module.moduleCredits;
            }

            return totalCredits > 0 ? totalWeightedMarks / totalCredits : 0;
        }

        static double CalculateBestAverage(Module[] modules)
        {
            double minMark = double.MaxValue;
            double totalMarks = 0;
            int count = modules.Length;

            foreach (var module in modules)
            {
                totalMarks += module.mark;
                if (module.mark < minMark)
                {
                    minMark = module.mark;
                }
            }

            //Subtract the lowest mark and average the rest
            return (totalMarks - minMark) / (count - 1);
        }
        static string GetClassification(double average)
        {
            if (average >= 70)
                return "First Class";
            else if (average >= 60)
                return "Second Class Upper";
            else if (average >= 50)
                return "Second Class Lower";
            else if (average >= 40)
                return "Third Class";
            else
                return "Fail";
        }
    }
}
            
