using System;

namespace MyApps
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] win = new int[9];
            for (int i = 0; i < 9; i++)
            {
                win[i] = 0;
            }
            string[] massiv = new string[9];
            massiv[0] = "1";
            massiv[1] = "2";
            massiv[2] = "3";
            massiv[3] = "4";
            massiv[4] = "5";
            massiv[5] = "6";
            massiv[6] = "7";
            massiv[7] = "8";
            massiv[8] = "9";

            for (int z = 0; z < 9; z++)
            {
                int k = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(massiv[k]);
                        Console.Write("   ");
                        k++;
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");

                if ((z % 2) == 0)
                {
                    bool check = false;
                    while (check == false)
                    {
                        Console.WriteLine("Ход крестиков");
                        string turn0 = Console.ReadLine();
                        int turncross = int.Parse(turn0);
                        if ((turncross > 0) && (turncross < 10))
                        {
                            if (win[turncross - 1] == 0)
                            {
                                massiv[turncross - 1] = "X";
                                Console.WriteLine(" ");
                                win[turncross - 1] = 1;
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("   ");
                                Console.WriteLine("Клетка занята, выберите другую");
                                Console.WriteLine("   ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("   ");
                            Console.WriteLine("Введено неверное число, введите число от 1 до 9");
                            Console.WriteLine("   ");
                        }
                    }
                }

                if(((win[0]==1) && (win[1] == 1) && (win[2] == 1)) || ((win[3] == 1) && (win[4] == 1) && (win[5] == 1)) || ((win[6] == 1) && (win[7] == 1) && (win[8] == 1)) || ((win[0] == 1) && (win[3] == 1) && (win[6] == 1)) || ((win[1] == 1) && (win[4] == 1) && (win[7] == 1)) || ((win[2] == 1) && (win[5] == 1) && (win[8] == 1)) || ((win[0] == 1) && (win[4] == 1) && (win[8] == 1)) || ((win[2] == 1) && (win[4] == 1) && (win[6] == 1)))
                {
                    Console.WriteLine("   ");
                    Console.WriteLine("Крестики победили");
                    Console.WriteLine("   ");
                    break;
                }

                if ((z % 2) != 0)
                {
                    bool check = false;
                    while (check == false)
                    {
                        Console.WriteLine("Ход ноликов");
                        string turn1 = Console.ReadLine();
                        int turnzero = int.Parse(turn1);
                        if ((turnzero > 0) && (turnzero < 10))
                        {
                            if (win[turnzero - 1] == 0)
                            {
                                massiv[turnzero - 1] = "O";
                                Console.WriteLine(" ");
                                win[turnzero - 1] = 2;
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("   ");
                                Console.WriteLine("Клетка занята, выберите другую");
                                Console.WriteLine("   ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("   ");
                            Console.WriteLine("Введено неверное число, введите число от 1 до 9");
                            Console.WriteLine("   ");
                        }
                    }
                }

                if (((win[0] == 2) && (win[1] == 2) && (win[2] == 2)) || ((win[3] == 2) && (win[4] == 2) && (win[5] == 2)) || ((win[6] == 2) && (win[7] == 2) && (win[8] == 2)) || ((win[0] == 2) && (win[3] == 2) && (win[6] == 2)) || ((win[1] == 2) && (win[4] == 2) && (win[7] == 2)) || ((win[2] == 2) && (win[5] == 2) && (win[8] == 2)) || ((win[0] == 2) && (win[4] == 2) && (win[8] == 2)) || ((win[2] == 2) && (win[4] == 2) && (win[6] == 2)))
                {
                    Console.WriteLine("   ");
                    Console.WriteLine("Нолики победили");
                    Console.WriteLine("   ");
                    break;
                }
            }


        }
    }
}
