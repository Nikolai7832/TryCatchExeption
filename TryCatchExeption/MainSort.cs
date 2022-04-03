using Exceptions;
namespace TryCatchException
{
    class MainSort
    {
        static string[] names = new string[5] { "Семенов", "Сидоров", "Попов", "Иванов", "Козлов" };

        static void Main(string[] args)
        {
             
            Console.WriteLine("Введите 1 для сортировки А-Я, 2 для сортировки Я-А:");

            var str = Console.ReadLine();

            if (!TryCatchExceptions.Catcher(str)) { Main(args); }

            var a = Int32.Parse(str);

            if (a == 1)
            {
                Array.Sort(names);
                foreach (string name in names)
                    Console.WriteLine(name);
            }

            if (a == 2)
            {
                string [] revNames = new string [names.Length];

                Array.Sort(names);

                for (int i  = names.Length -  1; i >= 0; i --)
                {
                    revNames[revNames.Length - 1 - i] = names[i];
                }

                foreach (string name in revNames)
                    Console.WriteLine(name);
            }
            Console.Read();

        }

    }
}

