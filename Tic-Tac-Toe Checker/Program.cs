namespace Tic_Tac_Toe_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[,] { { 2, 1, 2 }, { 2, 1, 1 }, { 1, 2, 1 } };
            Console.WriteLine(IsSolved(board));
        }

        public static int IsSolved(int[,] board)
        {
            //-1 if the board is not yet finished AND no one has won yet (there are empty spots),
            //1 if "X" won,
            //2 if "O" won,
            //0 if it's a cat's game(i.e.a draw).      
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] ==  board[i, 1]  && board[i, 1] == board[i, 2])
                {
                    switch (board[i, 0])
                    {
                        case 2: return 2;
                        case 1: return 1;
                    }
                }      
                else if (board[0, i] == board[1, i] && board[2, i] == board[1, i])
                {
                    switch (board[0, i])
                    {
                        case 2: return 2;
                        case 1: return 1;
                    }
                }
                else if (board[0, 0] == board[1, 1] && board[2, 2] == board[1, 1])
                {
                    switch (board[0, 0])
                    {
                        case 2: return 2;
                        case 1: return 1;
                    }
                }
                else if (board[0, 2] == board[1, 1] && board[2, 0] == board[1, 1])
                    switch (board[0, 2])
                    {
                        case 2: return 2;
                        case 1: return 1;
                    }
 
            }
            foreach (var item in board)
            {
                if (item == 0)
                {
                    return -1;
                };
            }
            return 0;
        }
    }
}
