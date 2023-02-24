using System;

// Display a message to the user asking them to guess the secret number.
// Console.WriteLine("Time to guess a secret number!");
// Display a prompt for the user's guess.
// string input = Console.ReadLine();
// int parsedInput = int.Parse(input);
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.

// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
int secretNum = 42;
// No longer display the user's guess. They know what they guessed, right?
// Compare the user's guess with the secret number. Display a success message if the guess is correct, 
// otherwise display a failure message.
// if (parsedInput == secretNum)
// {
//     Console.WriteLine("Correct!");
// }
// else
// {
//     Console.WriteLine("FAIL");
// }

// Give the user four chances to guess the number.
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Time to guess a secret number!");
    string input = Console.ReadLine();
    int parsedInput = int.Parse(input);

    if (parsedInput == secretNum)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine("FAIL");
    }
}

// Continue to display the success or failure messages as in phase 2