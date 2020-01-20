using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            throw new NotImplementedException();
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            throw new NotImplementedException();
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            throw new NotImplementedException();
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            if (pos[1] == "O" && pos[2] == "O" && pos[3] == "O")
            {
                return ChallengeSet07.TicTacToeResult.O;
            }
            else if (pos[4] == "O" && pos[5] == "O" && pos[6] == "O")
            {
                return ChallengeSet07.TicTacToeResult.O;
            }
            else if (pos[7] == "O" && pos[8] == "O" && pos[9] == "O")
            {
                return ChallengeSet07.TicTacToeResult.O;
            }

            else if (pos[1] == "O" && pos[5] == "O" && pos[9] == "O") // Diagonal -----------------------------------------
            {
                return ChallengeSet07.TicTacToeResult.O;
            }
            else if (pos[7] == "O" && pos[5] == "O" && pos[3] == "O")
            {
                return ChallengeSet07.TicTacToeResult.O;
            }

            else if (pos[1] == "O" && pos[4] == "O" && pos[7] == "O")// Coloumns ------------------------------------------
            {
                return ChallengeSet07.TicTacToeResult.O;
            }
            else if (pos[2] == "O" && pos[5] == "O" && pos[8] == "O")
            {
                return ChallengeSet07.TicTacToeResult.O;
            }
            else if (pos[3] == "O" && pos[6] == "O" && pos[9] == "O")
            {
                return ChallengeSet07.TicTacToeResult.O;
            }

            if (pos[1] == "X" && pos[2] == "X" && pos[3] == "X") // Horizontal ----------------------------------------
            {
                return ChallengeSet07.TicTacToeResult.X;
            }
            else if (pos[4] == "X" && pos[5] == "X" && pos[6] == "X")
            {
                return ChallengeSet07.TicTacToeResult.X;
            }
            else if (pos[7] == "X" && pos[8] == "X" && pos[9] == "X")
            {
                return ChallengeSet07.TicTacToeResult.X;
            }

            else if (pos[1] == "X" && pos[5] == "X" && pos[9] == "X") // Diagonal -----------------------------------------
            {
                return ChallengeSet07.TicTacToeResult.X;
            }
            else if (pos[7] == "X" && pos[5] == "X" && pos[3] == "X")
            {
                return ChallengeSet07.TicTacToeResult.X;
            }

            else if (pos[1] == "X" && pos[4] == "X" && pos[7] == "X") // Coloumns ------------------------------------------
            {
                return ChallengeSet07.TicTacToeResult.X;
            }
            else if (pos[2] == "X" && pos[5] == "X" && pos[8] == "X")
            {
                return ChallengeSet07.TicTacToeResult.X;
            }
            else if (pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
            {
                return ChallengeSet07.TicTacToeResult.X;
            }
            else // No winner ----------------------------------------------
            {
                return ChallengeSet07.TicTacToeResult.Draw;
            }
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
