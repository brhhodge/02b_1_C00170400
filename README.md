# 02b_1_C00170400
CMPS 358 programming assignment 1

Create a C# console project in Visual Studio Code and name it “02b_1_your-clid”. When the project
runs correctly, clean the project, zip the project folder and upload it in Moodle.
A shipping company uses the following math function to calculate the cost in dollars of shipping a
package based on its weight in kilograms. The package must be less than 50 kilograms to be
shipped.


3.5, if 0 < w <= 1
c(w) = 5.5, if 1 < w <= 3
8.5, if 3 < w <= 10
13.5 if 10 < w 14.


Write a C# console program that, in the method main, prompts the user to enter the weight of the
package. If it is possible to ship the package, the program then calculates the shipping cost of the
package according to the above formulas and displays that shipping cost with an appropriate text
label. If it is not possible to ship the package, the program displays “Cannot ship package.” If the
user enters a weight of zero or less, the program should display “Data error".
