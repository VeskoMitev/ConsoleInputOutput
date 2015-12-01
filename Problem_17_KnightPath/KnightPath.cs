namespace ConsoleInputOutput
{
    using System;
    class KnightPath
    {
        static bool Move(bool[,] board, string command,ref int cy,ref int cx ,bool first)
        {
            switch (command)
            {
                case "left":
                    if (first == true && cx + 2 < board.GetLength(1))
                    {
                        cx += 2;
                        return true;
                    }

                    if (first == false && cx + 1 < board.GetLength(1))
                    {
                        cx += 1;
                        return true;
                    }
                    
                    break;
                case "right":
                    if (first == true && cx - 2 >= 0)
                    {
                        cx -= 2;
                        return true;
                    }
                    if (first == false && cx - 1 >= 0)
                    {
                        cx -= 1;
                        return true;
                    }
                    break;
                case "up":
                    if (first == true && cy - 2 >= 0)
                    {
                        cy -= 2;
                        return true;
                    }
                    if (first == false && cy - 1 >= 0)
                    {
                        cy -= 1;
                        return true;
                    }
                    break;
                case "down":
                    if (first == true && cy + 2 < board.GetLength(0))
                    {
                        cy += 2;
                        return true;
                    }
                    if (first == false && cy + 1 < board.GetLength(0))
                    {
                        cy += 1;
                        return true;
                    }
                    break;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string inputData = "";
            int currentX = 0;
            int currentY = 0;
            bool[,] board = new bool[8 ,8];
            board[currentY, currentX] = true;
            int[] boInts = new int[8];

          
            while (inputData !="stop")
            {
                inputData = Console.ReadLine();
                string[] command = inputData.Split(' ');
                int tmpX = currentX;
                int tmpY = currentY;
                bool firstMove = Move(board, command[0], ref tmpY, ref tmpX, true);
                bool secontMove = false;
                if (firstMove)
                    secontMove = Move(board, command[1], ref tmpY, ref tmpX, false);
                if (firstMove && secontMove)
                {
                    currentX = tmpX;
                    currentY = tmpY;
                    board[currentY, currentX] ^= true;
                } 
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    boInts[i] += (board[i, j]) ? (int) Math.Pow(2, j) : 0;
                }  
            }
            int a = 0;
            foreach (int cell in boInts )
            {
                if (cell != 0)
                {
                    Console.WriteLine(cell);
                    a++;
                }
            }
            if(a==0) Console.WriteLine("[Board is empty]");
        }
    }
}
