namespace ConsoleApp3
{
    internal class Program
    {
        static DateTime date = new DateTime(2022, 10, 10);
        static void Welcome()
        {
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("Добро пожаловать в Заметки");
            Thread.Sleep(3000);
            Console.Clear();
        }
        static void Note1(diary page1, int position)
        {
            Console.Clear();
            Console.WriteLine($"Выбрана дата {date}");
            Console.WriteLine($"{page1.title}");
            Console.WriteLine($"{page1.title_two}");
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
        }
        static void Note2(diary page2, int position)
        {
            Console.Clear();
            Console.WriteLine($"Выбрана дата {date.AddDays(1)}");
            Console.WriteLine($"{page2.title}");
            Console.WriteLine($"{page2.title_two}");
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
        }
        static void Note3(diary page3, int position)
        {
            Console.Clear();
            Console.WriteLine($"Выбрана дата {date.AddDays(2)}");
            Console.WriteLine($"{page3.title}");
            Console.WriteLine($"{page3.title_two}");
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
        }
        static void Note4(diary page4, int position)
        {
            Console.Clear();
            Console.WriteLine($"Выбрана дата {date.AddDays(3)}");
            Console.WriteLine($"{page4.title}");
            Console.WriteLine($"{page4.title_two}");
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
        }
        static void Note5(diary page5, int position)
        {
            Console.Clear();
            Console.WriteLine($"Выбрана дата {date.AddDays(4)}");
            Console.WriteLine($"{page5.title}");
            Console.WriteLine($"{page5.title_two}");
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
        }
        public static void Pages(int page, int position, diary page1, diary page2, diary page3, diary page4, diary page5)
        {
            if (page == 0)
            {
                Note1(page1, position);
            }
            else if (page == 1)
            {
                Note2(page2, position);
            }
            else if (page == 2)
            {
                Note3(page3, position);
            }
            else if (page == 3)
            {
                Note4(page4, position);
            }
            else if (page == 4)
            {
                Note5(page5, position);
            }
        }
        static void Menu()
        {
            diary page1 = new diary()
            {
                title = "  1. Пары",
                description = "Нежка, с 1 по 4",
                title_two = "  2. Важная встреча",
                description_two = "Отдать плойку кенту"
            };
            diary page2 = new diary()
            {
                title = "  1. Пары",
                description = "Нахим, с 1 по 4",
                title_two = "  2. Зайти в магазин",
                description_two = "Купить несколько булок на след. день"
            };
            diary page3 = new diary()
            {
                title = "  1. Пары",
                description = "Нежка, с 2 по 4",
                title_two = "  2. Погулять",
                description_two = "no comments"
            };
            diary page4 = new diary()
            {
                title = "  1. Linux",
                description = "записать образ linux на флешку",
                title_two = "  2. Пары",
                description_two = "нахим, с 3 по 5"
            };
             diary page5 = new diary()
            {
                title = "  1. выполнение практики",
                description = "практика 4 - ежедневник",
                title_two = "  2. погулять",
                description_two = "погулять с подружанькой"
            };
            int position = 1;
            int page = 0;
            Note1(page1, position);
            while (true)
            {
                ConsoleKeyInfo knopka = Console.ReadKey();
                if (knopka.Key == ConsoleKey.RightArrow)
                {
                    page++;
                    if (page == 0)
                    {
                        Note1(page1, position);
                    }
                    else if (page == 1)
                    {
                        Note2(page2, position);
                    }
                    else if (page == 2)
                    {
                        Note3(page3, position);
                    }
                    else if (page == 3)
                    {
                        Note4(page4, position);
                    }
                    else if (page == 4)
                    {
                        Note5(page5, position);
                    }
                    else if (page > 4)
                    {
                        page--;
                    }
                }
                else if (knopka.Key == ConsoleKey.LeftArrow)
                {
                    page--;
                    if (page == 0)
                    {
                        Note1(page1, position);
                    }
                    else if (page == 1)
                    {
                        Note2(page2, position);
                    }
                    else if (page == 2)
                    {
                        Note3(page3, position);
                    }
                    else if (page == 3)
                    {
                        Note4(page4, position);
                    }
                    else if (page == 4)
                    {
                        Note5(page5, position);
                    }
                    else if (page < 0)
                    {
                        page++;
                    }
                }
                else if (knopka.Key == ConsoleKey.DownArrow)
                {
                    if (position < 2)
                    {
                        position++;   
                    }
                    else
                    {
                        position = 2;
                    }
                    Pages(page, position, page1, page2, page3, page4, page5);
                }
                else if (knopka.Key == ConsoleKey.UpArrow)
                {
                    if (position < 0)
                    {
                        position--;  
                    }
                    else 
                    {
                        position = 1;  
                    }
                    Pages(page, position, page1, page2, page3, page4, page5);
                }
                else if (knopka.Key == ConsoleKey.Enter)
                {
                    switch (page)
                    {
                        case 0:
                            {
                                Pages(page, position, page1, page2, page3, page4, page5);
                                if (position == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Пары");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"Описание: {page1.description}");
                                    Console.WriteLine($"Дата: {date}");
                                    Console.WriteLine($"Выполнить до: {date.AddHours(17)}");
                                }
                                else if (position == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Важная встреча");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"Описание: {page1.description_two}");
                                    Console.WriteLine($"Дата: {date}");
                                    Console.WriteLine($"Выполнить до: {date.AddHours(18).AddMinutes(30)}");
                                }
                                break;
                            }
                        case 1:
                            {
                                Pages(page, position, page1, page2, page3, page4, page5);
                                if (position == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Пары");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"Описание: {page2.description}");
                                    Console.WriteLine($"Дата: {date.AddDays(1)}");
                                    Console.WriteLine($"Выполнить до: {date.AddDays(1).AddHours(16)}");
                                }
                                else if (position == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Зайти в магазин");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"Описание: {page2.description_two}");
                                    Console.WriteLine($"Дата: {date.AddDays(1)}");
                                    Console.WriteLine($"Выполнить до: {date.AddDays(1).AddHours(21)}");
                                }
                                break;
                            }
                        case 2:
                            {
                                Pages(page, position, page1, page2, page3, page4, page5);
                                if (position == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Пары");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"Описание: {page3.description}");
                                    Console.WriteLine($"Дата: {date.AddDays(2)}");
                                    Console.WriteLine($"Выполнить до: {date.AddDays(2).AddHours(17)}");
                                }
                                else if (position == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Погулять");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"Описание: {page3.description_two}");
                                    Console.WriteLine($"Дата: {date.AddDays(2)}");
                                    Console.WriteLine($"Выполнить до: {date.AddDays(2).AddHours(20).AddMinutes(30)}");
                                }
                                break;
                            }
                        case 3:
                            {
                                Pages(page, position, page1, page2, page3, page4, page5);
                                if (position == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Linux");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"Описание: {page4.description}");
                                    Console.WriteLine($"Дата: {date.AddDays(3)}");
                                    Console.WriteLine($"Выполнить до: {date.AddDays(3).AddHours(11)}");
                                }
                                else if (position == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Пары");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"Описание: {page4.description_two}");
                                    Console.WriteLine($"Дата: {date.AddDays(3)}");
                                    Console.WriteLine($"Выполнить до: {date.AddDays(3).AddHours(18)}");
                                }
                                break;
                            }
                        case 4:
                            {
                                Pages(page, position, page1, page2, page3, page4, page5);
                                if (position == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("выполнение практики");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"Описание: {page5.description}");
                                    Console.WriteLine($"Дата: {date.AddDays(4)}");
                                    Console.WriteLine($"Выполнить до: {date.AddDays(4).AddHours(14)}");
                                }
                                else if (position == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"погулять");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine($"Описание: {page5.description_two}");
                                    Console.WriteLine($"Дата: {date.AddDays(4)}");
                                    Console.WriteLine($"Выполнить до: {date.AddDays(4).AddHours(23).AddMinutes(30)}");
                                }
                                break;
                            }
                    }
                }
                else if (knopka.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }
        static void Main()
        {
            while (true)
            {
                Welcome();
                Menu();
            }
        }
    }
}