using System;
using System.Linq;

namespace _05._02._2023_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "\nNazim Mamedov", "Ulvi Namazov", "Murad Bagirov" };
            string option;

            do
            {
                Console.WriteLine("1. Butun telebelere bax");
                Console.WriteLine("2. Yeni telebe elave et");
                Console.WriteLine("3. Telebeler uzre axtaris et");
                Console.WriteLine("4. Telebelerin adlarina bax");
                Console.WriteLine("5. Siyahida adin olub olmadiğina bax");
                Console.WriteLine("0. Menudan cix ");

                Console.WriteLine("\nSecim edin!");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }

                        break;
                    case "2":
                        Console.WriteLine("Elave etmek Istediyiniz telebeni Adi ve Soyadi daxil edin:");
                        string std = Console.ReadLine();

                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = std;

                        break;
                    case "3":
                        Console.WriteLine("Axtaris deyeri daxil edin:");
                        string searchPerson = Console.ReadLine();
                        bool isExist = false;

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].ToLower().Contains(searchPerson) || students[i].ToUpper().Contains(searchPerson))
                            {

                                isExist = true;
                                Console.WriteLine(students[i]);
                            }
                        }

                        if (isExist == false)
                        {
                            Console.WriteLine("Bele bir shexs yoxdur!");
                        }
                            

                        break;
                    case "4":
                        Console.WriteLine("Telebelerin Adi\n");

                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i].Split(' ')[0]);
                        }
                        
                        break;

                        
                    case "5":
                        Console.WriteLine("Axtardiginiz Telebenin hansisa bir herifini qeyd edin:\n");
                        string fullname = Console.ReadLine();
                        bool fullnamestd = false;

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].Contains(fullname))
                            {
                                Console.WriteLine("var");
                                fullnamestd = true;
                                break;
                            }

                        }
                        if (fullnamestd == false)
                        {
                            Console.WriteLine("yoxdur");
                        }


                        break;
                    case "0":
                        Console.WriteLine("Menudan cixdiz!\n");
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir yeniden daxil edin!\n");
                        break;
                }


            } while (option != "0");


        }
    }
}
