using System.Diagnostics;
using System;

namespace cakes
{
    internal class Program
    {
        static int give_me_money_baby(int i, List<string[]> argument, List<int[]> cost)
        {
            int index = argument[i].Count();
            function.print(index, argument[i], cost[i]);
            int second_index = function.arrow_menu(index);
            int price = cost[i][second_index];
            return price;
        }
        /*Боль сама по себе очень важна, за обучением ученика будет следить, но это происходит в такое время, когда работы и боли много.
        Если говорить до мельчайших деталей, никто не должен заниматься никакой работой, кроме как для того, чтобы получить от нее какой-нибудь хороший результат.
        
         **София Алексеевна 
         
         а нафига именно латинский? Можно же было на клингонском написать))
         */
        static void Main(string[] args)
        {
            File.Create("C:\\Users\\1\\Desktop\\text.txt");
            Console.CursorVisible = false;
            int price = 0;
            cake cake = new cake();
            List<int[]> cost = new List<int[]>();
            cost.Add(new int[] { 913984, 300, 500, 700 });
            cost.Add(new int[] { 300, 400, 500, 19874 });
            cost.Add(new int[] { 200, 9999, 500, 450000, 500, 300, 1200, 400, 1 });
            cost.Add(new int[] { 100, 300, 500, 700 });
            cost.Add(new int[] { 200, 300, 200, 11700, 19000 });
            cost.Add(new int[] { 15, 9999, 1500});
            List<string[]> argument = new List<string[]>();
            argument.Add(new string[] { "Чтоб в карман поместился", "Большой", "Средний", "Маленький" });
            argument.Add(new string[] { "Круг", "Квадрат", "Сердечко", "Вялая нога деда"});
            argument.Add(new string[] { "Клубника", "кошачий лоток", "Черника", "Ушная сера шрека", "Молочный шоколад", "чёрный шоколад", "белый шоколад", "кокос", "тухлые носки" });
            argument.Add(new string[] { "1", "2", "3", "58" });
            argument.Add(new string[] { "Шоколад", "Крем", "Бизе", "Волосы с бороды", "Полеэтилен" });
            argument.Add(new string[] { "Фигурка осла", "Бабкин ковёр", "Посыпка из гвоздей" });
            while (true)
            {
                Console.WriteLine("Пранк фирма \"Подставной торт\". Рады вас обслужить!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Выберите параметр торта:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("->1. Размер");
                Console.WriteLine("  2. Форма");
                Console.WriteLine("  3. Вкус");
                Console.WriteLine("  4. Количесвто коржей");
                Console.WriteLine("  5. Глазурь");
                Console.WriteLine("  6. Декор");
                Console.WriteLine("  7. Выход");
                Console.ResetColor();
                int index = 7;
                int second_index;
                ConsoleKey key = ConsoleKey.Q;
                int position = 2;
                while (key != ConsoleKey.Enter)
                {

                    key = Console.ReadKey().Key;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("  ");
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            if (position > 2) position--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (position < index+1) position++;
                            break;
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    Console.ResetColor();
                }
                switch (position)
                {
                    case 2:
                        price += give_me_money_baby(position - 2, argument, cost);
                        break;
                    case 3:
                        price += give_me_money_baby(position - 2, argument, cost);
                        break;
                    case 4:
                        price += give_me_money_baby(position - 2, argument, cost);
                        break;
                    case 5:
                        price += give_me_money_baby(position - 2, argument, cost);
                        break;
                    case 6:
                        price += give_me_money_baby(position - 2, argument, cost);
                        break;
                    case 7:
                        price += give_me_money_baby(position - 2, argument, cost);
                        break;
                    case 8:
                        Console.WriteLine("Сохранить заказ?");
                        Console.WriteLine("1. Да");
                        Console.WriteLine("2. Нет");
                        int question = Convert.ToInt32(Console.ReadLine());
                        switch (question)
                        {
                            case 1:

                                break;
                            case 2:

                                break;
                        }
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}