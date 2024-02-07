namespace ConsoleApp2.Tables
{
    internal class GoldTable
    {
        public int Id { get; set; }
        string? Name { get; set; }
        int Price { get; set; }
        DateTime Date { get; set; }
        private DateTime ChangetIn { get; set; }

        static internal void Add(List<GoldTable> goldList)
        {
            Console.Write("Введите название >> ");
            var name = Console.ReadLine();
            Console.Write("Введите цену >> ");
            var price = Convert.ToInt32(Console.ReadLine());
            goldList.Add(new GoldTable { Id = goldList.Count+1, Name = name, Price = price, Date = DateTime.Now });
        }

        static internal void GetData(List<GoldTable> goldList)
        {
            Console.WriteLine("\n\t\t\tДАННЫЕ ИЗ ТАБЛИЦЫ Gold\n");
            foreach (GoldTable gold in goldList)
            {
                Console.WriteLine($"| ID = {gold.Id} |\t| Название = {gold.Name} |\t| Цена = {gold.Price} |\t| Дата добавления = {gold.Date} |\t| Дата изменения = {gold.ChangetIn} ");
            }
        }
        
        static internal void EditData(List<GoldTable> goldList)
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
                    goldList[id].Name = newName;
                    goldList[id].Price = newPrice;
                    break;
                case 2:
                    Console.Write("Введите новое название >>");
                    newName = Console.ReadLine();
                    goldList[id].Name = newName;
                    break;
                case 3:
                    Console.Write("Введите новую цену >>");
                    newPrice = Convert.ToInt32(Console.ReadLine());
                    goldList[id].Price = newPrice;
                    break;
                default:
                    break;
            }
            goldList[id].ChangetIn = DateTime.Now;
            Console.WriteLine("Данные обновленны");
        }
        
        static internal void DeleteData(List<GoldTable> goldList)
        {
            Console.Write("Введите ID строки которую хотите удалить из списка >> ");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                goldList.RemoveAt(id - 1);
                Console.WriteLine($"Строка с индексом [{id}] успешно удалена");
            }
            catch
            {
                Console.WriteLine($"Строка по индексу [{id}] не найдена");
            }
        }
    }
}
