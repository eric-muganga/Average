/*
 * create a program for a teacher. He needs a program written in c# that calculates the average score of his students.
 * So he wants to be able to enter each score individually and then get the final average score once he enters -1.
So the tool should check if the entry is a number and should add that to the sum. 
Finally once he is done entering scores, the program should write onto the console what the average score is.
The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.

*/

Console.WriteLine("Hello, World! welcome to My Simple average calculator");
Console.WriteLine("Enter numbers only be between 0 and 20");

string input = "0";
int counter = 0;
int currentNumber = 0;
int Total = 0;
double average = 0;

while (input != "-1")
{
    Console.WriteLine($"Current number of Inputs {counter}");
    Console.WriteLine("Enter -1 if you want to get average of the Inputs");
    Console.WriteLine($"Current total is {Total}");
    input = Console.ReadLine();
    if (input == "-1")
    {
        Console.WriteLine("-----------------------------------------------------------");
        average = (double)Total / (double)counter;
        Console.WriteLine($"The average is of your student is {average}");
    }
    if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21){
        Total += currentNumber;
        counter++;
    }
    else
    {
        if(input != "-1") 
        {
            Console.WriteLine("Enter a number only between 0 and 20");
            continue;
        }
    }
}
