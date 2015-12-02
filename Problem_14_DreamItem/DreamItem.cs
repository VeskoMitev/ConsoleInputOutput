namespace ConsoleInputOutput
{
    using System.Globalization;
    using System.Threading;
    using System;
    class DreamItem
    {
        static void Main(string[] args)
        {
            CultureInfo ci = new CultureInfo("en-US", true);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;

            string[] inputData = Console.ReadLine().Split('\\');

            string month = inputData[0];
            decimal moneyPerHour =  Decimal.Parse(inputData[1]);
            byte hoursPerDay = byte.Parse(inputData[2]);
            decimal itemPrice = Decimal.Parse(inputData[3]);

            byte workingDays=0;
            switch (month )
            {
                case "Jan":
                case "Mar":
                case "March":
                case "May":
                case "July":
                case "Aug":
                case "Oct":
                case "Dec":
                    workingDays = 21;
                    break;
                case "Apr": 
                case "June":
                case "Sept":
                case "Nov":
                    workingDays = 20;
                    break;
                case "Feb":
                    workingDays = 18;
                    break;

            }

            decimal salary = workingDays*moneyPerHour*hoursPerDay;

            if (salary > 700) salary *= 1.1m;

           decimal leftMoney =  salary-itemPrice;
            if (leftMoney >= 0)
            {
                Console.WriteLine("Money left = {0:F2} leva.",leftMoney);  
            }
            else
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.",Math.Abs(leftMoney)); 
            }

        }
    }
}
