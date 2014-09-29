/* Program Displays Health guidelines for BP, HDL, LDL and BMI.
 * Enter option you want to know the detail for.
 * Program intentionally created in 32 lines.
 * Author-: Awdesh Sharma
 * Date-: 09/28/2014
 */
using System;
using System.Text;

namespace Health_GuideLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please press number to choose Option from below-: \n 1.) Blood Pressure\n2.) HDL\n3.) LDL\n4.)BMI {0}");
            string num = Console.ReadLine();
            switch(num){
                case "1":
                    Console.WriteLine("Less than 120/80,  NORMALormal\n 120–139/80–89 Prehypertension\n 140–159/90–99 Stage 1 Hypertension\n 160 and above/100 and above Stage 2 Hypertension ");
                    break;
                case "2":
                    Console.WriteLine("60 mg/dL and above Best\n 50-59 mg/dL Better\n Below 50 mg/dL (Women) Poor\n Below 40 mg/dL (Men) Poor");
                    break;
                case "3":
                    Console.WriteLine("Less than 100 mg/dL** Optimal\n 100–129 mg/dL Near optimal\n 130–159 mg/dL Borderline high\n 160–189 mg/dL High\n 190 mg/dL and above Very high");
                    break;
                case "4":
                    Console.WriteLine("Below 18.5 Underweight\n 18.5 – 24.9 Normal\n 25.0 – 29.9 Overweight\n 30.0 and above Obese");
                    break;
                default:
                    Console.WriteLine("Please choose one option");
                    break;
            }
        }
    }
}
