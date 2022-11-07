namespace ezhednevnik
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Field a = new Field("  1.Продать гараж", "ЗА 15К РУБЛЕЙ");
            Field b = new Field("  2.Сходить на пары", "К 3 паре на Нахиме");

            var list1 = new List<Field>();
            list1.Add(a);
            list1.Add(b);

            Field qwe = new("  1.Остаться дома", "Ничего не делать");

            var list2 = new List<Field>();
            list2.Add(qwe);

            page first = new page("10.11.23", list1);
            page second = new page("11.12.23", list2);

            var pages = new List<page>();
            pages.Add(first);
            pages.Add(second);

            NoteBook book = new NoteBook(pages);

            page temp = book.Pages.ElementAt(0);


            int i = 0;

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow | key.Key == ConsoleKey.LeftArrow)
                {
                    switch (key.Key)
                    {
                        case ConsoleKey.RightArrow:
                            Console.Clear();
                            i++;
                            if (i > 1)
                            {
                                 i --;
                            }
                            temp = book.Pages.ElementAt(i);
                            Console.WriteLine(temp.Date);
                            foreach (Field n in list1)
                            {
                            Console.WriteLine(n.Name);
                            }
                            Arrow1(list1);
                            break;
                       case ConsoleKey.LeftArrow:
                            Console.Clear();
                            i--;
                            if (i < 0)
                            {
                                i ++;
                            }
                            temp = book.Pages.ElementAt(i);
                            Console.WriteLine(temp.Date);
                           
                            foreach (Field n in list2)
                            {
                                Console.WriteLine(n.Name);
                            }
                            Arrow2(list2);
                            break;
                    }
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Choise();
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }

        public static void Arrow1(List<Field>list1)
        {
            ConsoleKeyInfo key;
            do
            {
                int position = 1;
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if(position < 1 )
                    {
                        position ++;
                    }
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if(position > 1)
                    {
                        position --;
                    }
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
            } while (key.Key == ConsoleKey.UpArrow | key.Key == ConsoleKey.DownArrow);
        }
        public static void Arrow2(List<Field>list2)
        {
            ConsoleKeyInfo key;
            do
            {
                int position = 1;
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position < 1)
                    {
                        position++;
                    }
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position >2)
                    {
                        position--;
                    }
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
            } while (key.Key == ConsoleKey.UpArrow | key.Key == ConsoleKey.DownArrow);
        }
        public static void Choise()
        {

        }
    }   
}