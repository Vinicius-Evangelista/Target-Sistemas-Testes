using System;

namespace TargetSistemas
{
    class MonthAmount
    {
        public string state;

        public decimal total;

        public MonthAmount(string state_, string total_)
        {
            state = state_;
            total = decimal.Parse(total_, System.Globalization.NumberStyles.AllowDecimalPoint | System.Globalization.NumberStyles.AllowThousands, new System.Globalization.CultureInfo("pt-BR"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<MonthAmount> monthAmounts = new List<MonthAmount>();
            monthAmounts.Add(new MonthAmount("SP", "67.836,43"));
            monthAmounts.Add(new MonthAmount("RJ", "36.678,66"));
            monthAmounts.Add(new MonthAmount("MG", "29.229,88"));
            monthAmounts.Add(new MonthAmount("ES", "27.165,48"));
            monthAmounts.Add(new MonthAmount("Outros", "19.849,53"));

            decimal monthAmount = monthAmounts.Sum(m => m.total);

            foreach (MonthAmount month in monthAmounts)
            {
                string percentage = ((month.total / monthAmount) * 100).ToString("00.000");
                Console.WriteLine(@$"State: {month.state}
Month Amout: {String.Format(new System.Globalization.CultureInfo("pt-BR"), "{0:C}", month.total)}
Percentage : {percentage}%
                ");
            }

            string formattedAmount = monthAmount.ToString("N", new System.Globalization.CultureInfo("pt-BR"));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Total: R${formattedAmount} \n");
            Console.ResetColor();

            Console.Write("\nPress 'Enter' to exit the process...");


            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }
    }
}