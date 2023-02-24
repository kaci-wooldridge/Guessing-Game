using System;

// Display a message to the user asking them to guess the secret number.
Console.WriteLine("Time to guess a secret number!");
// Display a prompt for the user's guess.
string input = Console.ReadLine();
int parsedInput = int.Parse(input);
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.
Console.WriteLine("You guessed:");
Console.WriteLine(parsedInput);