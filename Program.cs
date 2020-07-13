using System;
using static System.Console;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string player;
            
            
            bool repeat = true;
            int pick;
            int playerScore = 0;
            int cpuScore = 0;

            WriteLine("Rock Paper Scissors! ");
            WriteLine("By: John Watkins");
            WriteLine("Version: 0.1");

            while (repeat)
            {
            while (playerScore < 3 && cpuScore < 3)
            {
                Write("\nChoose Rock, Paper, or Scissors >>> ");
                player = ReadLine();
                player = player.ToLower();


                Random round = new Random();
                pick = round.Next(1, 4);
                switch (pick)
                {
                    case 1:
                        WriteLine("You: {0} / CPU: {1}", playerScore, cpuScore);
                        WriteLine("CPU chose Rock");
                        if (player == "rock")
                        {
                            WriteLine("<== DRAW ==>");
                        }
                        else if (player == "paper")
                        {
                            WriteLine("<== Player WINS!!! ==>");
                            ++playerScore;
                        }
                        else if (player == "scissors")
                        {
                            WriteLine("<== CPU WINS!!! ==>");
                            ++cpuScore;
                        }
                        break;
                    case 2:
                        WriteLine("You: {0} / CPU: {1}", playerScore, cpuScore);
                        WriteLine("CPU chose Paper");
                        if (player == "paper")
                        {
                            WriteLine("<== DRAW ==>");
                        }
                        else if (player == "rock")
                        {
                            WriteLine("<== CPU WINS!!! ==>");
                            ++cpuScore;
                        }
                        else if (player == "scissors")
                        {
                            WriteLine("<== Player WINS!!! ==>");
                            ++playerScore;
                        }
                        break;
                    case 3:
                        WriteLine("You: {0} / CPU: {1}", playerScore, cpuScore);
                        WriteLine("CPU chose Scissors");
                        if (player == "scissors")
                        {
                            WriteLine("<== DRAW ==>");
                        }
                        else if (player == "rock")
                        {
                            WriteLine("<== Player WINS!!! ==>");
                            ++playerScore;
                        }
                        else if (player == "paper")
                        {
                            WriteLine("<== CPU WINS!!! ==>");
                            ++cpuScore;
                        }
                        break;
                    default:
                        WriteLine("Invalid Entry!");
                        break;
                }

                if (playerScore == 3)
                {
                    WriteLine("<== You WIN!!! ==>");
                }
                else if (cpuScore == 3)
                {
                    WriteLine("<== CPU WINS!!! ==>");
                }
                else
                {
                }

            }

                    WriteLine("Would you like to continue???");
                    Write("Enter 'Yes / No: ");
                    string replay = ReadLine();
                    replay = replay.ToLower();

                    if (replay == "yes")
                    {
                        repeat = true;
                    }
                    else if (replay == "no")
                    { 
                        repeat = false;
                    }
                    else { }



                

            }
        }
    }
}
