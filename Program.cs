//Brian Hodge
//C00170400
//CMPS 358
//assignment 02b_1

using System;

namespace _02b_1_C00170400
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter package weight: ");
            double weight = Double.Parse(Console.ReadLine());

            if (weight >= 50){
                Console.WriteLine("Cannot ship package. The package weight cannot exceed 50 kilograms.");
            }
            else if (weight <= 0) {
                Console.WriteLine("Data Error.");
            }
            else {
                Console.WriteLine($"The shipping cost for a package weighing {weight} kilograms is: ${shipCost(weight)}");
            }
        }

        static double shipCost(double w) {

            double shippingPrice = 0;

            if (w > 0) {
                if (w <= 1) {
                    shippingPrice = 3.50;
                } 
                else if (w > 1) {
                    if (w <= 3) {
                        shippingPrice = 5.50;
                    }
                    else if (w > 3) {
                        if (w <= 10) {
                            shippingPrice = 8.50;
                        }
                        else if (w < 50) {
                            shippingPrice = 13.50;
                        } 
                    } 
                }

            } return shippingPrice;
        }
    }
}
