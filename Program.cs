using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hienthihinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice,choice1,n;
            Console.WriteLine("Menu");
            Console.WriteLine("1.In hình chữ nhật");
            Console.WriteLine("2.In tam giác vuông");
            Console.WriteLine("3.In tam giác cân");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Mời nhập số tương úng với hình muốn hiển thị:");
            choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
            
                Console.WriteLine("In hình chữ nhật");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                    break;

                case 2:
                { 
                    Console.WriteLine("In hình tam giác vuông.");
                    Console.WriteLine("1.Vuông phía trên bên trái");
                    Console.WriteLine("2.Vuông phía trên bên phải");
                    Console.WriteLine("3.Vuông phía dưới bên trái");
                    Console.WriteLine("4.Vuông phía dưới bên phải");
                    Console.WriteLine("Mời nhập số tương ứng với hình muốn hiển thị.");
                    choice1 = int.Parse(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:

                                Console.WriteLine("Tam giác vuông phía trên bên trái.");
                                for (int i = 5; i > 0; i--)
                                {
                                    for (int j = 0; j < i; j++)
                                    {
                                        Console.Write(" * ");
                                    }
                                    Console.WriteLine();
                                }
                                break;
                            case 2:

                                Console.WriteLine("Tam giác vuông phía trên bên phải.");
                                for (int i = 5; i >= 1; i--)
                                {
                                    for (int j = 1; j <= 5; j++)
                                    {
                                        if (j <= (5 - i))
                                        {
                                            Console.Write("   ");
                                        }
                                        else
                                        {
                                            Console.Write(" * ");
                                        }
                                    }
                                    Console.WriteLine();
                                }
                                break;

                            case 3:

                                Console.WriteLine("Tam giác vuông phía dưới bên trái.");
                                for (int i = 1; i < 6; i++)
                                {
                                    for (int j = 0; j < i; j++)
                                    {
                                        Console.Write(" * ");
                                    }
                                    Console.WriteLine();
                                }
                                break;


                            case 4:

                                Console.WriteLine("Tam giác vuông phía dưới bên phải.");
                                for (int i = 1; i <= 5; i++)
                                {
                                    for (int j = 1; j <= 5; j++)
                                    {
                                        if (j <= (5 - i))
                                        {
                                            Console.Write("   ");
                                        }
                                        else
                                        {
                                            Console.Write(" * ");
                                        }
                                    }
                                    Console.WriteLine();
                                }
                                break;
                            default:
                                Console.WriteLine("Không hợp lệ");
                                break;
                        }
                }
                        break;

                    case 3:
                    {
                        Console.WriteLine("In tam giác cân có chiều cao là :");
                        n=int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                           for (int j = 0; j < 2 * n - 1; j++)
                           {
                               if (j >= n - i - 1 && j <= n + i - 1)
                               {
                                    Console.Write("*");
                               }
                               else
                               {
                                   Console.Write(" ");
                               }
                           }
                            Console.WriteLine();
                        }
                    }
                    break;
                    case 4:
                        {
                        Console.WriteLine("Exit");
                        }
                    break;
                    default : Console.WriteLine("Không hợp lệ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
                    
                    //123*
                    //12***
                    //1*****
                    //*******
                    