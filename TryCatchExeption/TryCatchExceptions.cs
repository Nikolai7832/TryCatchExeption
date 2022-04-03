namespace Exceptions
{ 
    public class TryCatchExceptions : ArgumentException
    {

        public TryCatchExceptions()
        { }
        public TryCatchExceptions(string message) : base(message)
        { }
        public static bool Catcher(string str)

        {

            var ex = new Exception[5];
            ex[0] = new TryCatchExceptions("Строка больше 1-го символа");
            ex[1] = new TryCatchExceptions("Введена буква");
            ex[2] = new TryCatchExceptions("Введена неправильная цифра");
            ex[3] = new ArgumentNullException();
            ex[4] = new Exception("Исключение успешно вызвано!");

            try
            {
                if (str == "") { throw ex[3]; }

                else if (str.Length > 1) { throw ex[0]; }

                else if (Char.IsLetter(str, 0)) { throw ex[1]; }

                else if (Int32.Parse(str) != 1 && Int32.Parse(str) != 2) { throw ex[2]; }

                else if (!Int32.TryParse(str, out int a)) { throw ex[4]; }
                return true;

            }
            catch (Exception e) when (e.Message == "Строка больше 1-го символа") { Console.WriteLine(e.Message); return false; }

            catch (Exception e) when (e.Message == "Введена буква") { Console.WriteLine(e.Message); return false; }

            catch (Exception e) when (e.Message == "Введена неправильная цифра") { Console.WriteLine(e.Message); return false; }

            catch (Exception e) when (e is ArgumentNullException) { Console.WriteLine("Строка пуста"); return false; }

            catch (Exception) { Console.WriteLine(ex[4].Message); return false; }

        }
        public static void Catcher()
        {

            var ex = new Exception[5];
            ex[0] = new TryCatchExceptions("Строка больше 1-го символа");
            ex[1] = new TryCatchExceptions("Введена буква");
            ex[2] = new TryCatchExceptions("Введена неправильная цифра");
            ex[3] = new ArgumentNullException();
            ex[4] = new Exception("Исключение успешно вызвано!");

            for (int i = 0; i < ex.Length; i++)
            {

                try
                {
                    throw ex[i];
                }
                catch (Exception e) when (e.Message == "Строка больше 1-го символа") { Console.WriteLine(e.Message); }

                catch (Exception e) when (e.Message == "Введена буква") { Console.WriteLine(e.Message); }

                catch (Exception e) when (e.Message == "Введена неправильная цифра") { Console.WriteLine(e.Message); }

                catch (Exception e) when (e is ArgumentNullException) { Console.WriteLine("Строка пуста"); }

                catch (Exception) { Console.WriteLine(ex[4].Message); }
            }
        }


    }
}
