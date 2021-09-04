using System;

namespace BMI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           double weight, height, bmi, reduceweight;
            /* Input */
            Console.Write("weight(kg):");
            double.TryParse(Console.ReadLine(), out weight); // trasfer string input to double
            Console.Write("height(cm):");
            double.TryParse(Console.ReadLine(), out height);

            /* Process */
            bmi = weight / Math.Pow((height*0.01), 2); //bmi = weight(kg)/height(m)^2
            /* Output */
            Console.WriteLine("BMI: "+bmi);

            if(bmi<= 18.5)
            {
                Console.WriteLine("Skinny");
            }
            else if (bmi<=25)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi<=30)
            {
                reduceweight = 24.9 * Math.Pow((height * 0.01), 2);
                Console.WriteLine("Fat you need to reduce weight to : {0} ", reduceweight);
            }
            else if (bmi>=30)
            {
                reduceweight = 24.9 * Math.Pow((height * 0.01), 2);
                Console.WriteLine("Very Fat you need to reduce weight to : {0} ", reduceweight);
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
            Console.ReadKey();
        }
    }
}
