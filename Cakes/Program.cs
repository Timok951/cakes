using static Cakes.Underorder;

namespace Cakes
{
    internal class Underorder
    {
        public string description;
        public int costing;

        public Underorder(string desc, int cost) {
            description=desc;
            costing = cost;

    }
       
   

    }

    


    internal class Program
    {
        static List<Underorder> UnderorderList = new List<Underorder>();

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
            public void underchoice()
            {
                Console.Clear();
                Console.WriteLine();
                foreach (Underorder pos in UnderorderList)
                {
                    Console.WriteLine("  " + pos.description +" "+pos.costing);

                }



            }



        }

        static void Main(string[] args)
        {


            Underorder circle = new Underorder("Круглый", 500);
            UnderorderList.Add(circle);
            Underorder  square = new Underorder("Квадратный", 450);
            UnderorderList.Add(square);
            Underorder triangle = new Underorder("Треугольный", 400);
            UnderorderList.Add(triangle);
            Underorder rectangular = new Underorder("Прямоуглольный", 400);           
            UnderorderList.Add(rectangular);

            
            Console.Clear();
            order order = new order();
            order.show();
            Menue.Show(1, 7);
            order.underchoice();
            Menue.Show(1, 4);




            //Underorder circle = new Underorder();
            //circle.desc = "";

            //Underorder.Add(desc);





        }

    }
}