using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesar Roncancio
//CISS201
//Agile Development
//9/20/2020

namespace dropbox04
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array that holds 15 students BMI scores
            double[] scores = new double[15];
            //Loop to prompt users to enter scores
            for(int count =0; count < scores.Length; count++)
            {
                Console.WriteLine("Enter a BMI score:");
                scores[count] = double.Parse(Console.ReadLine());
            }
            //variables to hold BMI values and Weight Status
            double underWeight = 0;
            double normalWeight = 0;
            double Overweight = 0;
            double Obese = 0;
            //Loop to check each score and assign the Weight Status
            for (int count = 0; count < scores.Length; count++)
            {
                if (scores[count] >= 30)
                    Obese++;
                else if (scores[count] >= 25)
                    Overweight++;
                else if (scores[count] >= 18.5)
                    normalWeight++;
                else
                    underWeight++;
            }
            //Display results
            Console.WriteLine("Number of Obese students: {0}", Obese);
            Console.WriteLine("Number of Overweight students: {0}", Overweight);
            Console.WriteLine("Number of Normal Weight students: {0}", normalWeight);
            Console.WriteLine("Number of Under Weight students: {0}", underWeight);
            Console.ReadKey();
        }
    }
}
