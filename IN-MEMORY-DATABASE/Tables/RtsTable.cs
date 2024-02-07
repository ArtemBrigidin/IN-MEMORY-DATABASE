namespace ConsoleApp2.Tables
{
    internal class RtsTable
    {
        int Id { get; set; }
        string? Name { get; set; }
        int Price { get; set; }
        DateTime Date { get; set; }
        private DateTime ChangetIn { get; set; }

        static internal void Add(List<RtsTable> rtsList)
        {
            Console.Write("Введите название >> ");
            var name = Console.ReadLine();
            Console.Write("Введите цену >> ");
            var price = Convert.ToInt32(Console.ReadLine());
            rtsList.Add(new RtsTable { Id = rtsList.Count+1, Name = name, Price = price, Date = DateTime.Now });
        }

        static internal void GetData(List<RtsTable> rtsList)
        {
            Console.WriteLine("\n\t\t\tДАННЫЕ ИЗ ТАБЛИЦЫ RTS\n");
            foreach (RtsTable rts in rtsList)
            {
                Console.WriteLine($"| ID = {rts.Id} |\t| Название = {rts.Name} |\t| Цена = {rts.Price} |\t| Дата добавления = {rts.Date} |\t| Дата изменения = {rts.ChangetIn} ");
            }
        }
        
        static internal void EditData(List<RtsTable> rtsList)
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
                    rtsList[id].Name = newName;
                    rtsList[id].Price = newPrice;
                    break;
                case 2:
                    Console.Write("Введите новое название >>");
                    newName = Console.ReadLine();
                    rtsList[id].Name = newName;
                    break;
                case 3:
                    Console.Write("Введите новую цену >>");
                    newPrice = Convert.ToInt32(Console.ReadLine());
                    rtsList[id].Price = newPrice;
                    break;
                default:
                    break;
            }
            rtsList[id].ChangetIn = DateTime.Now;
            Console.WriteLine("Данные обновленны");
        }
        
        static internal void DeleteData(List<RtsTable> rtsList)
        {
            Console.Write("Введите ID строки которую хотите удалить из списка >> ");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                rtsList.RemoveAt(id - 1);
                Console.WriteLine($"Строка с индексом [{id}] успешно удалена");
            }
            catch
            {
                Console.WriteLine($"Строка по индексу [{id}] не найдена");
            }
        }
    }
}
