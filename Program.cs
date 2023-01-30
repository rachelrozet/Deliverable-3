/* Author: Rachel Rozet
 * Date: 1/30/2023
 * Description: To list a series of odd or even numbers between 1 and a specific integer provided by the user, based on the value of the user's input and the series they select
 * */
namespace Deliverable3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the maximum integer for the program
            int max = 0;
            // Define while loop to validate user's data input (check that value is an integer between 1 and 100)
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter an integer between 1 and 100: ");
                    max = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Incorrect data entry. Only integer numbers are allowed. Please enter an integer between 1 and 100: ");
                }
            }

            // Ask the user to select either an Odd or Even integer series

            while (true)
            {
                try
                {
                    Console.WriteLine("Please specify an integer series, either Odd or Even: ");
                    // Alter input to lower case to ensure all data inputs are counted from the user
                    string series = Console.ReadLine().ToLower();

       
                    // Sequence to follow if user selected the ODD series
                    if (series == "odd")
                    {
                        // Write the user's output - selected series and correct odd or even integers between 1 and the integer they selected
                        Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + max + " are:");
                        // Define "for" loop from 1 to the maximum value 
                        for (int i = 1; i <= max; i++)
                        {
                            // Validate if the number is odd
                            if (i % 2 == 1)
                            {
                                // Write the output to the user
                                Console.WriteLine(i);
                            }
                        }
                        Console.WriteLine("Thank you for participating in this program! Have a great rest of your day! :)");
                    }

                    // Sequence to follow if user selected the EVEN series
                    else if (series == "even")
                    {
                        // Write the user's output - selected series and correct odd or even integers between 1 and the integer they selected
                        Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + max +" are:");
                        // Define "for" loop from 1 to the maximum value 
                        for (int i = 1; i <= max; i++)
                        {
                            // Validate if the number is even
                            if (i % 2 == 0)
                            {
                                // Write the output to the user
                                Console.WriteLine(i);
                            }
                        }

                        Console.WriteLine("Thank you for participating in this program! Have a great rest of your day! :)");
                    }

                    else
                    {
                        Console.WriteLine("Incorrect data entry. Please start the program again.");
                    }

                    break;
                }
                catch (Exception ex)
                {
                    
                }
            }

        }
    }
}