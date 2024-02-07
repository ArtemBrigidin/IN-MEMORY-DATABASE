using ConsoleApp2.Tables;

namespace ConsoleApp2.Interfaces
{
    internal class Menu : IMenu
    {
        public void GetMenu()
        {
            List<BrentTable> brentTable = new List<BrentTable>();
            List<GoldTable> goldTable = new List<GoldTable>();
            List<RtsTable> rtsTable = new List<RtsTable>();

            int choice = -1;
            while (choice != 0)
            {
                Console.Clear();
                Console.WriteLine("1. Добавить данные в таблицу Brent");
                Console.WriteLine("2. Добавить данные в таблицу Gold");
                Console.WriteLine("3. Добавить данные в таблицу RTS");
                Console.WriteLine("4. Изменить данные в таблице Brent");
                Console.WriteLine("5. Изменить данные в таблице Gold");
                Console.WriteLine("6. Изменить данные в таблице RTS");
                Console.WriteLine("7. Удалить строку в таблице Brent");
                Console.WriteLine("8. Удалить строку в таблице Gold");
                Console.WriteLine("9. Удалить строку в таблице RTS");
                Console.WriteLine("10. Вывести данные из таблицы Brent");
                Console.WriteLine("11. Вывести данные из таблицы Gold");
                Console.WriteLine("12. Вывести данные из таблицы RTS");
                Console.WriteLine("0. Выйти");
                Console.Write(">> ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Tables.BrentTable.Add(brentTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Tables.GoldTable.Add(goldTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Tables.RtsTable.Add(rtsTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Tables.BrentTable.EditData(brentTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Tables.GoldTable.EditData(goldTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Tables.RtsTable.EditData(rtsTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Tables.BrentTable.DeleteData(brentTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Tables.GoldTable.DeleteData(goldTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Tables.RtsTable.DeleteData(rtsTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        Tables.BrentTable.GetData(brentTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                        Tables.GoldTable.GetData(goldTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 12:
                        Console.Clear();
                        Tables.RtsTable.GetData(rtsTable);
                        Console.WriteLine("Для продолжения нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
