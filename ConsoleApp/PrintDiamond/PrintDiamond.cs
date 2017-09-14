using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyMinutes.ConsoleApp
{
    class RunMain
    {
        static void Main(string[] args)
        {
            PrintDiamond pd = new PrintDiamond();
            pd.StaticDiamon();

            return;
        }
    }

    public class PrintDiamond
    {
        public PrintDiamond()
        {
            return;
        }

        public void StaticDiamon()
        {
            int width = 11;
            int height = 11;
            int midPoint = (width / 2) + 1;
            int startPrintIndex;
            int endPrintIndex;
            int reverse = 1;
            for (int o = 1; o <= height; o++)
            {
                if (o <= midPoint)
                {
                    startPrintIndex = midPoint - (o - 1);
                    endPrintIndex = midPoint + (o - 1);
                }
                else
                {
                    startPrintIndex = reverse + 1;
                    endPrintIndex = width - reverse;
                    reverse++;
                }

                for (int cursor = 1; cursor <= width; cursor++)
                {
                    if (startPrintIndex <= cursor && cursor <= endPrintIndex)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine();
            }

            return;
        }
    }
}
