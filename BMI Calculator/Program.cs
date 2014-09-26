/* 
 * Program to calculate BMI.
 * Author-: Awdesh Sharma.
 */
using System;
namespace BmiCalculator
{
    /// <summary>
    /// Class which integrated methods to calculate BMI.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Client code to which asks weight and height from user and calculate BMI accordingly.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program();
            float height = p.GetUserHeight();
            float bmi = (p.GetUserWeight() / (height * height)) * 703;
            if ( bmi > 18.5 && bmi < 25)
            {
                Console.WriteLine("Congratulations, your BMI is good.Keep Working out!!\n your BMI is -: {0}", bmi);
            }
            else
            {
                // Patient needs help. We dont shock him by telling his BMI.
                Console.WriteLine("We need to talk......about your Health");
            }
        }
        /// <summary>
        /// Method asks user for their weight.
        /// </summary>
        /// <returns>(int)weight of user.</returns>
        private float GetUserWeight()
        {
            Console.WriteLine("Enter your Weight in lbs-:");
            return Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Method asks user for their height.
        /// </summary>
        /// <returns>(int)height of user.</returns>
        private float GetUserHeight()
        {
            Console.WriteLine("Welcome to BMI calculator \n===================\n  Enter your height in inches-:");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}