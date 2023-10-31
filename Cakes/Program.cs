namespace Cakes
{
    class undermenue
    {
        string description;
        int cost;
   

    }

    class order
    {

        public void show()
        {
            

            Console.WriteLine("--Кондитерская Cakes from yuour dreams---");
            Console.WriteLine("  Форма");
            Console.WriteLine("  Размер");
            Console.WriteLine("  Вкус");
            Console.WriteLine("  Колличество");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Выход");



        }
        public void underchoice(int pos)
        {
            undermenue undermenue = new undermenue();

                if (pos == 1)
                {

                Console.Clear();
                Console.WriteLine("  Круглая");
                Console.WriteLine("  Квадратная");
                Console.WriteLine("  Прямоугольная");


            }
                else if (pos == 2)

                {
                Console.Clear();
                Console.WriteLine("  Большой");
                Console.WriteLine("  Маленький");
                Console.WriteLine("  Средний");
            }

                else if (pos == 3)

                {
                Console.Clear();
                Console.WriteLine("  Клубничный");
                Console.WriteLine("  Банановый");
                Console.WriteLine("  Ванильный");
            }

                else if (pos == 4)

                {
                Console.Clear();
                Console.WriteLine("  Много");
                Console.WriteLine("  Очень много");
                Console.WriteLine("  Мало");

            }

            else if (pos == 5)

                {
                Console.Clear();
                Console.WriteLine("  Молочная");
                Console.WriteLine("  Шоколадная");
            }

                else if (pos == 6)

                {
                Console.Clear();
                Console.WriteLine("  Цветы");
                Console.WriteLine("  Клубника");

            }


        } 



    }


    internal class Program
    {
        static void Main(string[] args)
        {
            order order = new order();
            order.show();
            int pos = Menue.Show(1, 7);
            
            order.underchoice(pos);


        }

    }
}