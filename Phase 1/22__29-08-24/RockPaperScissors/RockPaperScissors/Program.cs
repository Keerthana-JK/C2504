﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int playerScore = 0;
            int computerScore = 0;
            Random random = new Random();

            try
            {
                // Game loop until either player or computer reaches 10 points
                while (playerScore < 10 && computerScore < 10)
                {
                    string playerChoice = GetPlayerChoice();
                    string computerChoice = GetComputerChoice(random);

                    Console.WriteLine($"Computer chose: {computerChoice}");

                    // Determine the outcome of the round
                    string result = DetermineWinner(playerChoice, computerChoice);

                    // Update scores based on the result
                    if (result == "player")
                    {
                        Console.WriteLine("You win this round!");
                        playerScore++;
                    }
                    else if (result == "computer")
                    {
                        Console.WriteLine("Computer wins this round!");
                        computerScore++;
                    }
                    else if (result == "tie")
                    {
                        Console.WriteLine("It's a tie!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice! Please enter Stone, Paper, or Scissor.");
                    }

                    // Display the current scores
                    DisplayScores(playerScore, computerScore);
                }

                // Announce the final winner
                AnnounceWinner(playerScore, computerScore);
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
            // Function to get the player's choice
            static string GetPlayerChoice()
            {
                Console.WriteLine("Enter your choice (Stone, Paper, Scissor): ");
                return Console.ReadLine().ToLower();
            }

            // Function to get the computer's choice
            static string GetComputerChoice(Random random)
            {
                string[] choices = { "stone", "paper", "scissor" };
                return choices[random.Next(3)];
            }

            // Function to determine the winner of the round
            static string DetermineWinner(string playerChoice, string computerChoice)
            {
                if (playerChoice == computerChoice)
                {
                    return "tie";
                }
                else if ((playerChoice == "stone" && computerChoice == "scissor") ||
                         (playerChoice == "scissor" && computerChoice == "paper") ||
                         (playerChoice == "paper" && computerChoice == "stone"))
                {
                    return "player";
                }
                else if ((computerChoice == "stone" && playerChoice == "scissor") ||
                         (computerChoice == "scissor" && playerChoice == "paper") ||
                         (computerChoice == "paper" && playerChoice == "stone"))
                {
                    return "computer";
                }
                else
                {
                    return "invalid";
                }
            }

            // Function to display the current scores
            static void DisplayScores(int playerScore, int computerScore)
            {
                Console.WriteLine($"Score -> You: {playerScore} | Computer: {computerScore}\n");
            }

            // Function to announce the final winner
            static void AnnounceWinner(int playerScore, int computerScore)
            {
                if (playerScore == 10)
                {
                    Console.WriteLine("Congratulations! You won the game!");
                }
                else
                {
                    Console.WriteLine("Computer won the game! Better luck next time.");
                }
            }

        }
    }

