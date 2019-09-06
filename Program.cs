using System;

// Sequence for tie 2,1,5,4,6,3,9,8,7

namespace tictactoe
{
    class Program
    {
        static string[,] main = new string[3, 3]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };

        static void Main(string[] args)
        {
            string input;
            bool validNum;
            int userSelection;
            int turn = 1;
            int step = 0;
            bool letsPlay = true;
            bool gameIsOver = false;
            string xOrO = "X";
            string pos1 = main[0, 0];
            string pos2 = main[0, 1];
            string pos3 = main[0, 2];
            string pos4 = main[1, 0];
            string pos5 = main[1, 1];
            string pos6 = main[1, 2];
            string pos7 = main[2, 0];
            string pos8 = main[2, 1];
            string pos9 = main[2, 2];

            bool ValidInt (string userInput)
            {
                validNum = int.TryParse(userInput, out userSelection);
                if (userSelection > 0 && userSelection < 10 && validNum) return true;
                else return false;
            }

            void ChangePlayer()
            {
                if (turn == 1)
                {
                    turn = 2;
                    xOrO = "X";
                }
                else
                {
                    turn = 1;
                    xOrO = "O";
                }
            }

            void IncreaseStep()
            {
                step++;
            }

            void DisplayWinner(int player)
            {
                if (player == 1)
                {
                    DisplayBoard();
                    System.Console.WriteLine("Player 1 (O) Wins");
                    gameIsOver = true;
                    ResetGame();
                }
                else
                {
                    DisplayBoard();
                    System.Console.WriteLine("Player 2 (X) Wins");
                    gameIsOver = true;
                    ResetGame();
                }

            }

            void ResetGame()
            {
                Console.ReadLine();
                gameIsOver = false;
                turn = 1;
                pos1 = "1";
                pos2 = "2";
                pos3 = "3";
                pos4 = "4";
                pos5 = "5";
                pos6 = "6";
                pos7 = "7";
                pos8 = "8";
                pos9 = "9";
                step = 0;
                DisplayBoard();
            }

            void CheckTie()
            {
                if (step > 8)
                {
                    DisplayBoard();
                    System.Console.WriteLine("No winner this time it's a tie press any key to continue");
                    ResetGame();
                    System.Console.WriteLine();
                }
            }

            void CheckWinPlayer1(int pos)
            {
                switch (pos)
                {
                    case 1:
                        if (pos2 == "O" && pos3 == "O" || pos5 == "O" && pos9 == "O" || pos4 == "O" && pos7 == "O") DisplayWinner(1);
                        break;

                    case 2:
                        if (pos1 == "O" && pos3 == "O" || pos5 == "O" && pos8 == "O") DisplayWinner(1);
                        break;

                    case 3:
                        if (pos1 == "O" && pos2 == "O" || pos5 == "O" && pos7 == "O" || pos6 == "O" && pos9 == "O") DisplayWinner(1);
                        break;

                    case 4:
                        if (pos1 == "O" && pos7 == "O" || pos5 == "O" && pos6 == "O") DisplayWinner(1);
                        break;

                    case 5:
                        if (pos4 == "O" && pos6 == "O" || pos1 == "O" && pos9 == "O" || pos3 == "O" && pos7 == "O" || pos2 == "O" && pos8 == "O") DisplayWinner(1);
                        break;

                    case 6:
                        if (pos3 == "O" && pos9 == "O" || pos4 == "O" && pos5 == "O") DisplayWinner(1);
                        break;

                    case 7:
                        if (pos1 == "O" && pos4 == "O" || pos3 == "O" && pos5 == "O" || pos8 == "O" && pos9 == "O") DisplayWinner(1);
                        break;

                    case 8:
                        if (pos2 == "O" && pos5 == "O" || pos7 == "O" && pos9 == "O") DisplayWinner(1);
                        break;

                    case 9:
                        if (pos1 == "O" && pos5 == "O" || pos3 == "O" && pos6 == "O" || pos7 == "O" && pos8 == "O") DisplayWinner(1);
                        break;
                }
            }

            void CheckWinPlayer2(int pos)
            {
                switch (pos)
                {
                    case 1:
                        if (pos2 == "X" && pos3 == "X" || pos5 == "X" && pos9 == "X" || pos4 == "X" && pos7 == "X") DisplayWinner(2);
                        break;

                    case 2:
                        if (pos1 == "X" && pos3 == "X" || pos5 == "X" && pos8 == "X") DisplayWinner(2);
                        break;

                    case 3:
                        if (pos1 == "X" && pos2 == "X" || pos5 == "X" && pos7 == "X" || pos6 == "X" && pos9 == "X") DisplayWinner(2);
                        break;

                    case 4:
                        if (pos1 == "X" && pos7 == "X" || pos5 == "X" && pos6 == "X") DisplayWinner(2);
                        break;

                    case 5:
                        if (pos4 == "X" && pos6 == "X" || pos1 == "X" && pos9 == "X" || pos3 == "X" && pos7 == "X" || pos2 == "X" && pos8 == "X") DisplayWinner(2);
                        break;

                    case 6:
                        if (pos3 == "X" && pos9 == "X" || pos4 == "X" && pos5 == "X") DisplayWinner(2);
                        break;

                    case 7:
                        if (pos1 == "X" && pos4 == "X" || pos3 == "X" && pos5 == "X" || pos8 == "X" && pos9 == "X") DisplayWinner(2);
                        break;

                    case 8:
                        if (pos2 == "X" && pos5 == "X" || pos7 == "X" && pos9 == "X") DisplayWinner(2);
                        break;

                    case 9:
                        if (pos1 == "X" && pos5 == "X" || pos3 == "X" && pos6 == "X" || pos7 == "X" && pos8 == "X") DisplayWinner(2);
                        break;
                }
            }

            while (letsPlay)
            {
                DisplayBoard();
                CheckTie();
                System.Console.WriteLine("Player {0} your turn {1}", turn, xOrO);
                input = Console.ReadLine();

                if (ValidInt(input) && !gameIsOver && step < 9)
                {

                    switch (userSelection)
                    {
                        case 1:
                            if (turn == 1 && pos1 != "O" && pos1 != "X")
                            {
                                pos1 = "O";
                                ChangePlayer();
                                CheckWinPlayer1(userSelection);
                                IncreaseStep();
                            }
                            else if (turn == 2 && pos1 != "O" && pos1 != "X")
                            {
                                pos1 = "X";
                                ChangePlayer();
                                CheckWinPlayer2(userSelection);
                                IncreaseStep();
                            }
                            else
                            {
                                System.Console.WriteLine("Position already taken please select another");
                                Console.ReadLine();
                            }
                            break;

                        case 2:
                            if (turn == 1 && pos2 != "O" && pos2 != "X")
                            {
                                pos2 = "O";
                                ChangePlayer();
                                CheckWinPlayer1(userSelection);
                                IncreaseStep();
                            }
                            else if (turn == 2 && pos2 != "O" && pos2 != "X")
                            {
                                pos2 = "X";
                                ChangePlayer();
                                CheckWinPlayer2(userSelection);
                                IncreaseStep();
                            }
                            else
                            {
                                System.Console.WriteLine("Position already taken please select another");
                                Console.ReadLine();
                            }
                            break;

                        case 3:
                            if (turn == 1 && pos3 != "O" && pos3 != "X")
                            {
                                pos3 = "O";
                                ChangePlayer();
                                CheckWinPlayer1(userSelection);
                                IncreaseStep();
                            }
                            else if (turn == 2 && pos3 != "O" && pos3 != "X")
                            {
                                pos3 = "X";
                                ChangePlayer();
                                CheckWinPlayer2(userSelection);
                                IncreaseStep();
                            }
                            else
                            {
                                System.Console.WriteLine("Position already taken please select another");
                                Console.ReadLine();
                            }
                            break;

                        case 4:
                            if (turn == 1 && pos4 != "O" && pos4 != "X")
                            {
                                pos4 = "O";
                                ChangePlayer();
                                CheckWinPlayer1(userSelection);
                                IncreaseStep();
                            }
                            else if (turn == 2 && pos4 != "O" && pos4 != "X")
                            {
                                pos4 = "X";
                                ChangePlayer();
                                CheckWinPlayer2(userSelection);
                                IncreaseStep();
                            }
                            else
                            {
                                System.Console.WriteLine("Position already taken please select another");
                                Console.ReadLine();
                            }
                            break;

                        case 5:
                            if (turn == 1 && pos5 != "O" && pos5 != "X")
                            {
                                pos5 = "O";
                                ChangePlayer();
                                CheckWinPlayer1(userSelection);
                                IncreaseStep();
                            }
                            else if (turn == 2 && pos5 != "O" && pos5 != "X")
                            {
                                pos5 = "X";
                                ChangePlayer();
                                CheckWinPlayer2(userSelection);
                                IncreaseStep();
                            }
                            else
                            {
                                System.Console.WriteLine("Position already taken please select another");
                                Console.ReadLine();
                            }
                            break;

                        case 6:
                            if (turn == 1 && pos6 != "O" && pos6 != "X")
                            {
                                pos6 = "O";
                                ChangePlayer();
                                CheckWinPlayer1(userSelection);
                                IncreaseStep();
                            }
                            else if (turn == 2 && pos6 != "O" && pos6 != "X")
                            {
                                pos6 = "X";
                                ChangePlayer();
                                CheckWinPlayer2(userSelection);
                                IncreaseStep();
                            }
                            else
                            {
                                System.Console.WriteLine("Position already taken please select another");
                                Console.ReadLine();
                            }
                            break;

                        case 7:
                            if (turn == 1 && pos7 != "O" && pos7 != "X")
                            {
                                pos7 = "O";
                                ChangePlayer();
                                CheckWinPlayer1(userSelection);
                                IncreaseStep();
                            }
                            else if (turn == 2 && pos7 != "O" && pos7 != "X")
                            {
                                pos7 = "X";
                                ChangePlayer();
                                CheckWinPlayer2(userSelection);
                                IncreaseStep();
                            }
                            else
                            {
                                System.Console.WriteLine("Position already taken please select another");
                                Console.ReadLine();
                            }
                            break;

                        case 8:
                            if (turn == 1 && pos8 != "O" && pos8 != "X")
                            {
                                pos8 = "O";
                                ChangePlayer();
                                CheckWinPlayer1(userSelection);
                                IncreaseStep();
                            }
                            else if (turn == 2 && pos8 != "O" && pos8 != "X")
                            {
                                pos8 = "X";
                                ChangePlayer();
                                CheckWinPlayer2(userSelection);
                                IncreaseStep();
                            }
                            else
                            {
                                System.Console.WriteLine("Position already taken please select another");
                                Console.ReadLine();
                            }
                            break;

                        case 9:
                            if (turn == 1 && pos9 != "O" && pos9 != "X")
                            {
                                pos9 = "O";
                                ChangePlayer();
                                CheckWinPlayer1(userSelection);
                                IncreaseStep();
                            }
                            else if (turn == 2 && pos9 != "O" && pos9 != "X")
                            {
                                pos9 = "X";
                                ChangePlayer();
                                CheckWinPlayer2(userSelection);
                                IncreaseStep();
                            }
                            else
                            {
                                System.Console.WriteLine("Position already taken please select another");
                                Console.ReadLine();
                            }
                            break;
                    }
                }

                else if (step >= 9)
                {
                    CheckTie();
                }

                else
                {
                    System.Console.WriteLine("Your input was not valid please try again");
                    Console.ReadKey();
                }
            }

        }
        public static void setFields()
        {

        }
    }
}