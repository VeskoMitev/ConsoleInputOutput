
namespace ConsoleInputOutput
{
    using System;
    using System.Linq;
    class ArrayMatcher
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split('\\');

            string command = inputData[2];
            string result = "";
            if (command == "join")
            {
                var txtEntitites = inputData[0].OrderBy(x => x).Where(e => inputData[1].IndexOf(e) >= 0);
                result = new string(txtEntitites.ToArray());
            }
            else if (command == "right exclude")
            {
                var txtEntitites = inputData[0].OrderBy(x => x).Where(e => inputData[1].IndexOf(e) == -1);
                result = new string(txtEntitites.ToArray());
            }
            else if (command == "left exclude")
            {
                var txtEntitites = inputData[1].OrderBy(x => x).Where(e => inputData[0].IndexOf(e) == -1);
                result = new string(txtEntitites.ToArray());
            }
            Console.WriteLine(result);
        }
    }
}
