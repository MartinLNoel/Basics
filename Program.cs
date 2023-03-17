using System;

class program
{

    public int SumOfAllNumbersDivisibleBy3Or5(int number)
    {
        //A variable that is used to add all the numbers that are divisble by 3 or 5
        int sum = 0;
        //Creates a for loop with the variable countUp that goes up until 1 below the given function parameter
        for (int countUp = 1; countUp < number; countUp++)
        {
            //An if statement that check whether the countUp variable is divisible by 3 or 5
            if (countUp % 3 == 0 || countUp % 5 == 0)
            {
                //if true, it adds the countUp variable to the sum variable
                sum += countUp;
            }
        }
        //returns the variable sum
        return sum;
    }

    //The main Function that calls the other function with the number that I want to calculate.
    public static void Main(string[] args)
    {
        program p = new program();
        Console.WriteLine(p.SumOfAllNumbersDivisibleBy3Or5(10));
    }
}