using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp8;

namespace ConsoleApp8
{
    public static class trianglesolver
    {
        public static void  Analyze()
        {
            
            try
            {
                int inputnumber;

                Console.WriteLine("\nPress 1 To Enter triangle dimenstions");
                Console.WriteLine("Press 2 For Exit");

                inputnumber = int.Parse(Console.ReadLine());



                switch (inputnumber)
                {
                    case 1:

                        Console.WriteLine("\n\n");
                        Console.WriteLine("Enter the Value of the 3 sides of your Triangle :");

                        int firstSide = int.Parse((Console.ReadLine()));
                        int secondSide = int.Parse((Console.ReadLine()));
                        int thirdSide = int.Parse((Console.ReadLine()));
                        int expectedResult = firstSide + secondSide + thirdSide;
                        if ( (firstSide == secondSide && secondSide == thirdSide))
                        {

                            Console.WriteLine("Form a Triangle ");
                            Console.WriteLine("Type Equilateral");
                             expectedResult=int.Parse((Console.ReadLine()));


                        }
                        else if (((firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)))
                        {
                            Console.WriteLine("Form a Triangle ");
                            Console.WriteLine("Type Isosceles");
                        }

                        else if (firstSide != secondSide && secondSide != thirdSide && thirdSide != firstSide)
                            {

                            Console.WriteLine("Form a Triangle ");
                            Console.WriteLine("Type scalene");
                        }
                        else if (firstSide >= (secondSide + thirdSide) && thirdSide >= (secondSide + firstSide) && secondSide >= (firstSide + thirdSide))
                        
                            Console.WriteLine("Not Form a Triangle");

                            Console.ReadKey();
                            Analyze();
                            break;

                        
                    case 2:
                        System.Environment.Exit(0);
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Please Enter a Valid input");


            }

            finally
            {
                Analyze();

            }
        }
    }
}


        

    
    

