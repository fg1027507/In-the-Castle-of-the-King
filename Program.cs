/* 
In the Castle of the King!
Created by Finn Gilbert
Made on September 23, 2025
Demonstrates random numbers and while loops in C#!
*/

// Sets the random numbers for the program.
using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32.SafeHandles;
string keepPlaying = "Yes";
int score = 0;
while (keepPlaying != "No")
{
    Random rand1 = new Random();
    Random rand2 = new Random();
    Random rand3 = new Random();
    Random rand4 = new Random();
    Random rand5 = new Random();
    int door1 = rand1.Next(1, 4);
    int door2 = rand2.Next(1, 4);
    int door3 = rand3.Next(1, 4);
    int door4 = rand4.Next(1, 4);
    int door5 = rand5.Next(1, 4);
    if (door1 != 1 || door1 != 3)
    {
        while (door1 != 1 || door1 != 3)
        {
            door1 = rand1.Next(1, 4);
            break;
        }
    }
    if (door3 != 1 || door3 != 3)
    {
        while (door3 != 1 || door3 != 3)
        {
            door3 = rand3.Next(1, 4);
            break;
        }
    }
    if (door5 != 1 || door5 != 3)
    {
        while (door5 != 1 || door5 != 3)
        {
            door5 = rand5.Next(1, 4);
            break;
        }
    }

    /*
    for debugging or if you want a cheet guide?
    Console.WriteLine(door1);
    Console.WriteLine(door2);
    Console.WriteLine(door3);
    Console.WriteLine(door4);
    Console.WriteLine(door5);
    */
    
    bool programRun = true;
    // Greets the users, welcomes them to the program, and tells the user what to do.
    Console.WriteLine("Welcome to In The Castle of the King!");
    Console.WriteLine("You are searching for the King. Beware of dragons!");
    
        // Tells the user what the door options and asks them to pick and option.
        Console.WriteLine("Choose a door (1, 2, 3, 4, or 5)");
        Console.Write(">> ");
        int doorChosen = Convert.ToInt32(Console.ReadLine());
        // finds out if what to do when the door is selected
        if (doorChosen == 1)
        {
        if (door1 == 1)
        {
            // tells the user they lost and asks if they want to keep playing
            Console.WriteLine("You got eaten by the dragon! This is the end of your story!");
            score++;
            Console.WriteLine($"It took you {score} tries!");
            Console.WriteLine("Do you still want to play? (Yes or No)");
            Console.Write(">> ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "No")
            {
                break;
            }
        }
        else if (door1 == 2)
        {
            // tells the user to keep guessing
            Console.WriteLine("You found tureasure! Chose another door!");
            score++;
        }
        else if (door1 == 3)
        {
            // tells the user they won and asks if they want to keep playing
            Console.WriteLine("You found the king! You won the kings favor and are showered with gifts and praise!");
            score++;
            Console.WriteLine($"It took you {score} tries!");
            Console.WriteLine("Do you still want to play? (Yes or No)");
            Console.Write(">> ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "No")
            {
                break;
            }
            // sets score to 0 when the king is found
            else
            {
                score = 0;
            }
        }
        }
        if (doorChosen == 2)
        {
        if (door2 == 1)
        {
            // tells the user they lost and asks if they want to keep playing
            Console.WriteLine("You got eaten by the dragon! This is the end of your story!");
            score++;
            Console.WriteLine($"It took you {score} tries!");
            Console.WriteLine("Do you still want to play? (Yes or No)");
            Console.Write(">> ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "No")
            {
                break;
            }
        }
        else if (door2 == 2)
        {
            // tells the user to keep guessing
            Console.WriteLine("You found tureasure! Chose another door!");
            score++;
        }
        else if (door2 == 3)
        {
            // tells the user they won and asks if they want to keep playing
            Console.WriteLine("You found the king! You won the kings favor and are showered with gifts and praise!");
            score++;
            Console.WriteLine($"It took you {score} tries!");
            Console.WriteLine("Do you still want to play? (Yes or No)");
            Console.Write(">> ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "No")
            {
                break;
            }
            // sets score to 0 when the king is found
            else
            {
                score = 0;
            }
        }
        }
        if (doorChosen == 3)
        {
        if (door3 == 1)
        {
            // tells the user they lost and asks if they want to keep playing
            Console.WriteLine("You got eaten by the dragon! This is the end of your story!");
            score++;
            Console.WriteLine($"It took you {score} tries!");
            Console.WriteLine("Do you still want to play? (Yes or No)");
            Console.Write(">> ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "No")
            {
                break;
            }
        }
        else if (door3 == 2)
        {
            // tells the user to keep guessing
            Console.WriteLine("You found tureasure! Chose another door!");
            score++;
        }
        else if (door3 == 3)
        {
            // tells the user they won and asks if they want to keep playing
            Console.WriteLine("You found the king! You won the kings favor and are showered with gifts and praise!");
            score++;
            Console.WriteLine($"It took you {score} tries!");
            Console.WriteLine("Do you still want to play? (Yes or No)");
            Console.Write(">> ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "No")
            {
                break;
            }
            // sets score to 0 when the king is found
            else
            {
                score = 0;
            }
        }
        }
        if (doorChosen == 4)
        {
        if (door4 == 1)
        {
            // tells the user they lost and asks if they want to keep playing
            Console.WriteLine("Do you still want to play? (Yes or No)");
            score++;
            Console.WriteLine($"It took you {score} tries!");
            Console.Write(">> ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "No")
            {
                break;
            }
        }
        else if (door4 == 2)
        {
            // tells the user to keep guessing
            Console.WriteLine("You found tureasure! Chose another door!");
            score++;
        }
        else if (door4 == 3)
        {
            // tells the user they won and asks if they want to keep playing
            Console.WriteLine("You found the king! You won the kings favor and are showered with gifts and praise!");
            score++;
            Console.WriteLine($"It took you {score} tries!");
            Console.WriteLine("Do you still want to play? (Yes or No)");
            Console.Write(">> ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "No")
            {
                break;
            }
            // sets score to 0 when the king is found
            else
            {
                score = 0;
            }
        }
        }
        if (doorChosen == 5)
        {
        if (door5 == 1)
        {
            // tells the user they lost and asks if they want to keep playing
            Console.WriteLine("You got eaten by the dragon! This is the end of your story!");
            score++;
            Console.WriteLine($"It took you {score} tries!");
            Console.WriteLine("Do you still want to play? (Yes or No)");
            Console.Write(">> ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "No")
            {
                break;
            }
        }
        else if (door5 == 2)
        {
            // tells the user to keep guessing
            Console.WriteLine("You found tureasure! Chose another door!");
            score++;
        }
        else if (door5 == 3)
        {
            // tells the user they won and asks if they want to keep playing
            Console.WriteLine("You found the king! You won the kings favor and are showered with gifts and praise!");
            score++;
            Console.WriteLine($"It took you {score} tries!");
            Console.WriteLine("Do you still want to play? (Yes or No)");
            Console.Write(">> ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "No")
            {
                break;
            }
            // sets score to 0 when the king is found
            else
            {
                score = 0;
            }
        }
        }
      }
