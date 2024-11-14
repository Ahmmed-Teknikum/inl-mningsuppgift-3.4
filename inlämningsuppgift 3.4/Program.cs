using System;
using System.ComponentModel.Design;


namespace inlämning_._uppgift_._3_._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter är din musik?");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många sekunder är din musik");
            int sek = int.Parse(Console.ReadLine());

            if ((min <= 2 && sek <= 45) || (min >= 4 && sek >= 20)) 
            {
                Console.WriteLine("Din låt får inte spelas");
            }
            else
            {
                Console.WriteLine("Din låt får spelas");
            }

            
            
            
                
            

        }
    }
}