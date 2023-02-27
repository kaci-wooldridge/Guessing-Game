using System;

// Display a message to the user asking them to guess the secret number.
// Console.WriteLine("Time to guess a secret number!");
// Display a prompt for the user's guess.
// string input = Console.ReadLine();
// int parsedInput = int.Parse(input);
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.

// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
// int secretNum = 42;
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
// Continue to display the success or failure messages as in phase 2

// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, 
// the prommpt should say something like Your guess (2)>.

// End the loop early if the user guesses the correct number.

// Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
// The prompt should display the number of guesses the user has left.
Random rnd = new Random();
int secretNum = rnd.Next(0, 100);

int diffFun (string choice)
{
    int x = 0;
    if(choice == "easy")
    {
        x = 8;
    }
    else if(choice == "medium")
    {
        x = 6;
    }
    else if(choice == "hard")
    {
        x = 4;
    }
    else if(choice == "cheater")
    {
        x = 100;
    }
    else
    {
    }
    return x;
}

Console.WriteLine("Welcome to Guessing Game");
Console.WriteLine("Choose a difficulty");
Console.WriteLine("Easy, Medium, Hard, or Cheater?");
string diffChoice = Console.ReadLine().ToLower();
int x = diffFun(diffChoice);

for (int i = 0; i < x; i++)
{
    Console.WriteLine("Time to guess a secret number!");
    string input = Console.ReadLine();
    int parsedInput = int.Parse(input);

    if (parsedInput > secretNum)
    {
        Console.WriteLine("Your guess: " + parsedInput);
        Console.WriteLine("Too high!");
        int remaining = x - i - 1;
        Console.WriteLine("guesses remaining: " + remaining);
        Console.WriteLine("_ _ _ _ _ _ _ _ _ _");
    }
    else if (parsedInput < secretNum)
    {
        Console.WriteLine("Your guess: " + parsedInput);
        Console.WriteLine("Too low!");
        int remaining = x - i - 1;
        Console.WriteLine("guesses remaining: " + remaining);
        Console.WriteLine("_ _ _ _ _ _ _ _ _ _");
    }
    else
    {
        Console.WriteLine("Your guess: " + parsedInput);
        Console.WriteLine("Lucky guess!");
        break;
    }
}