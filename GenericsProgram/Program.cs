namespace GenericsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect program  \n 1.CreateArray");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CreateArrray create = new CreateArrray();
                        create.createinpiut();
                        break;
                }
            }
        }
    }
}

