using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using static Cakes.Underorder;

namespace Cakes
{
    internal class Underorder
    {
        public string description;
        public int costing;

        public Underorder(string desc, int cost)
        {
            description = desc;
            costing = cost;

        }



    }




    internal class Program
    {
        DateTime dateTime = new DateTime();
        static List<Underorder> UnderorderList = new List<Underorder>();
        static List<Underorder> UnderorderList2 = new List<Underorder>();
        static List<Underorder> UnderorderList3 = new List<Underorder>();
        static List<Underorder> UnderorderList4 = new List<Underorder>();
        static List<Underorder> UnderorderList5 = new List<Underorder>();
        static List<Underorder> UnderorderList6 = new List<Underorder>();

        class order
        {
            string choice;
            int money;
            public void show()
            {


                Console.WriteLine("--Кондитерская Cakes from yuour dreams---");
                Console.WriteLine("  Форма");
                Console.WriteLine("  Размер");
                Console.WriteLine("  Вкус");
                Console.WriteLine("  Колличество");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Конец заказа");



            }
            public void underchoice(int position)
            {
                
                Console.Clear();
                Console.WriteLine();

                if (position == 1)
                {

                    foreach (Underorder pos in UnderorderList)
                    {

                        Console.WriteLine("  " + pos.description + " " + pos.costing);

                     





                    }
                    
                    int i = Menue.Show(1, 4);
                    Console.Clear();
                    choice = choice + " " + UnderorderList[i-1].description;
                    money = money + UnderorderList[i - 1].costing;
                    Console.WriteLine("\n  Нажмите enter для продолжения");
                }
                else if(position == 2)
                {
                    foreach (Underorder pos in UnderorderList2)
                    {

                        Console.WriteLine("  " + pos.description + " " + pos.costing);




                    }
                    int i = Menue.Show(1, 3);
                    Console.Clear();
                    choice = choice + " " + UnderorderList2[i - 1].description;
                    money = money + UnderorderList2[i - 1].costing;
                    Console.WriteLine("\n  Нажмите enter для продолжения");
                }
                else if (position == 3)
                {
                    foreach (Underorder pos in UnderorderList3)
                    {

                        Console.WriteLine("  " + pos.description + " " + pos.costing);
                        



                    }
                    int i = Menue.Show(1, 3);
                    Console.Clear();
                    choice = choice + " " + UnderorderList3[i - 1].description;
                    money = money + UnderorderList3[i - 1].costing;
                    Console.WriteLine("\n  Нажмите enter для продолжения");

                }

                else if (position == 4)
                {
                    foreach (Underorder pos in UnderorderList4)
                    {

                        Console.WriteLine("  " + pos.description + " " + pos.costing);




                    }
                    int i = Menue.Show(1, 3);
                    Console.Clear();
                    choice = choice + " " + UnderorderList4[i - 1].description;
                    money = money + UnderorderList4[i - 1].costing;
                    Console.WriteLine("\n  Нажмите enter для продолжения"); 
                }

                else if (position == 5)
                {
                    foreach (Underorder pos in UnderorderList5)
                    {

                        Console.WriteLine("  " + pos.description + " " + pos.costing);




                    }
                    int i = Menue.Show(1, 3);
                    Console.Clear();
                    choice = choice + " " + UnderorderList5[i - 1].description;
                    money = money + UnderorderList5[i - 1].costing;
                    Console.WriteLine("\n  Нажмите enter для продолжения");

                }

                else if (position == 6)
                {
                    foreach (Underorder pos in UnderorderList6)
                    {

                        Console.WriteLine("  " + pos.description + " " + pos.costing);




                    }
                    int i = Menue.Show(1, 3);
                    Console.Clear();
                    choice = choice + " " + UnderorderList6[i - 1].description;
                    money = money + UnderorderList6[i - 1].costing;
                    Console.WriteLine("\n  Нажмите enter для продолжения");
                }

          





            }
             public void fileAdd()
            {
                string txt = "\n Закакз от " +DateTime.Now + "\n Заказ: " + choice + "\n Цена:"+ Convert.ToString(money);
                string path = "H:\\П50-4-22\\Программирование\\C#\\Homework\\Cakes\\Cakes.txt";

                if (File.Exists(path)) {
                    File.AppendAllText(path, txt);

                }
                else {
                    File.Create(path);
                     File.AppendAllText(path, txt);
                }
               
            }


        }

        static void Main(string[] args)
        {


            Underorder circle = new Underorder("Круглый", 500);
            UnderorderList.Add(circle);
            Underorder square = new Underorder("Квадратный", 450);
            UnderorderList.Add(square);
            Underorder triangle = new Underorder("Треугольный", 400);
            UnderorderList.Add(triangle);
            Underorder rectangular = new Underorder("Прямоуглольный", 400);
            UnderorderList.Add(rectangular);

            Underorder big = new Underorder("Большой", 200);
            UnderorderList2.Add(big);
            Underorder small = new Underorder("Маленький", 100);
            UnderorderList2.Add(small);
            Underorder normal = new Underorder("Нормальный", 150);
            UnderorderList2.Add(normal);

            Underorder strawberry = new Underorder("Клубничный", 200);
            UnderorderList3.Add(strawberry);
            Underorder banana = new Underorder("Банановый", 100);
            UnderorderList3.Add(banana);
            Underorder vanile = new Underorder("Ванильный", 150);
            UnderorderList3.Add(vanile);

            Underorder one = new Underorder("Один", 100);
            UnderorderList4.Add(one);
            Underorder two = new Underorder("Два", 200);
            UnderorderList4.Add(two);
            Underorder three = new Underorder("Три", 300);
            UnderorderList4.Add(three);

            Underorder vanileg = new Underorder("Ванильная", 100);
            UnderorderList5.Add(vanileg);
            Underorder chocolateg = new Underorder("Шоколадная", 200);
            UnderorderList5.Add(chocolateg);
            Underorder none = new Underorder("Нет", 0);
            UnderorderList5.Add(none);

            Underorder floowers = new Underorder("Цветы", 100);
            UnderorderList6.Add(floowers);
            Underorder chocolates = new Underorder("Шоколадки", 200);
            UnderorderList6.Add(chocolates);
            Underorder posipka = new Underorder("Посыпка", 100);
            UnderorderList6.Add(posipka);

            order order = new order();
            while (true)
            {
                Console.Clear();
              
                order.show();
                int position = Menue.Show(1, 7);


                order.underchoice(position);
                if (position == 7)
                {
                    Console.Clear();
                    Console.WriteLine("Заказ готов");
                    break;
                }

                Menue.Show(1, 4);
              
            }
            order.fileAdd();





            //Underorder circle = new Underorder();
            //circle.desc = "";

            //Underorder.Add(desc);





        }

    }
}