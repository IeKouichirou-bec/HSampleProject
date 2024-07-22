using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSampleProject.src
{
    internal class Kadai001
    {
        public void Begin()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("***          うるう年判定         ***");
            Console.WriteLine("*************************************");

            while (true)
            {
                Console.WriteLine("整数を入力してください。（終了するときは「0」を入力してください）");
                var userInput = Console.ReadLine();
                var parseValue = checkInputString(userInput);


                switch (parseValue)
                {
                    case 0:
                        Console.WriteLine("プログラムを終了します。");
                        return; //ループとメソッドを終了するために return を使用

                    case -1:
                        Console.WriteLine(string.Format("{0}は整数ではありません。\r\n", userInput));
                        continue; // 再度while
                    default:
                        break;
                }


                if (isUruu(parseValue))
                {
                    Console.WriteLine(string.Format("{0}年はうるう年です。\r\n", userInput));
                }
                else
                {
                    Console.WriteLine(string.Format("{0}年はうるう年ではありません。\r\n", userInput));
                }


                continue; // 再度while
            }

        }

        private int checkInputString(string? input)
        {
            int result = 0;

            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                // 失敗した場合には -1を返す
                return -1;
            }

        }

        private bool isUruu(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
            //if (year % 4 == 0)
            //{
            //    if (year % 100 == 0)
            //    {
            //        if (year % 400 == 0)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //else
            //{
            //    return false;
            //}

        }


    }
}
