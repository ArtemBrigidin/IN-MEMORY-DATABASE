namespace ConsoleApp2.Tables
{
    internal class BrentTable
    {
        public int Id { get; set; }
        string? Name { get; set; }
        int Price { get; set; }
        DateTime Date { get; set; }
        DateTime ChangetIn { get; set; }

        static internal void Add(List<BrentTable> brentList)
        {
            Console.Write("Введите название >> ");
            var name = Console.ReadLine();
            Console.Write("Введите цену >> ");
            var price = Convert.ToInt32(Console.ReadLine());
            brentList.Add(new BrentTable { Id = brentList.Count + 1, Name = name, Price = price, Date = DateTime.Now, ChangetIn = DateTime.Now });
        }

        static internal void GetData(List<BrentTable> brentList)
        {
            Console.WriteLine("\n\t\t\tДАННЫЕ ИЗ ТАБЛИЦЫ Brent\n");
            foreach (BrentTable brent in brentList)
            {
                Console.WriteLine($"| ID = {brent.Id} |\t| Название = {brent.Name} |\t| Цена = {brent.Price} |\t| Дата добавления = {brent.Date} |\t| Дата изменения = {brent.ChangetIn} ");
            }
        }

        static internal void EditData(List<BrentTable> brentList)
        {
            Console.Write("Введите ID строки которую хотите изменить >> ");
            int id = Convert.ToInt32(Console.ReadLine());
            id -= 1;
            string? newName;
            int newPrice;
            Console.WriteLine("Желаете всё поменять (Название, Цену)?");
            Console.WriteLine("1. Всё");
            Console.WriteLine("2. Только название");
            Console.WriteLine("3. Только цену");
            Console.WriteLine(">>");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Введите новое название >>");
                    newName = Console.ReadLine();
                    Console.Write("Введите новую цену >>");
                    newPrice = Convert.ToInt32(Console.ReadLine());
                    brentList[id].Name = newName;
                    brentList[id].Price = newPrice;
                    break;
                case 2:
                    Console.Write("Введите новое название >>");
                    newName = Console.ReadLine();
                    brentList[id].Name = newName;
                    break;
                case 3:
                    Console.Write("Введите новую цену >>");
                    newPrice = Convert.ToInt32(Console.ReadLine());
                    brentList[id].Price = newPrice;
                    break;
                default:
                    break;
            }
            brentList[id].ChangetIn = DateTime.Now;
            Console.WriteLine("Данные обновленны");
        }

        static internal void DeleteData(List<BrentTable> brentList)
        {
            Console.Write("Введите ID строки которую хотите удалить из списка >> ");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                brentList.RemoveAt(id - 1);
                Console.WriteLine($"Строка с индексом [{id}] успешно удалена");
            }
            catch
            {
                Console.WriteLine($"Строка по индексу [{id}] не найдена");
            }
        }
    }
}
