namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            char[][] board = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                board[i] = new char[cols];
                for (int j = 0; j < cols; j++)
                {
                    board[i][j] = char.Parse(Console.ReadLine());
                }
            }
            string word = Console.ReadLine();
            bool result = Exist(board, word);
            Console.WriteLine(result);

        }
        public static bool Exist(char[][] board, string word)
        {
            int rows = board.Length;
            int cols = board[0].Length;

            for (int row = 0; row < rows; ++row)
            {
                for (int col = 0; col < cols; ++col)
                {
                    if (Backtrack(board, word, row, col, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool Backtrack(char[][] board, string word, int row, int col, int index)
        {
            if (index == word.Length)
            {
                return true;
            }
            if (IsOutOfBoundOrMismatch(board, word, row, col, index))
            {
                return false;
            }

            char temp = board[row][col];
            board[row][col] = '\0';

            bool result = Backtrack(board, word, row + 1, col, index + 1) ||
                          Backtrack(board, word, row - 1, col, index + 1) ||
                          Backtrack(board, word, row, col + 1, index + 1) ||
                          Backtrack(board, word, row, col - 1, index + 1);

            board[row][col] = temp;
            return result;
        }

        public static bool IsOutOfBoundOrMismatch(char[][] board, string word, int row, int col, int index)
        {
            int rows = board.Length;
            int cols = board[0].Length;
            return row < 0 || row >= rows || col < 0 || col >= cols || board[row][col] != word[index];
        }
    }
}
