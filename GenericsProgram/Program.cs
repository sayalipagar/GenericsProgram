namespace GenericsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect program  \n 1.CreateArray\n 2.UsingGenericMethod");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CreateArrray create = new CreateArrray();
                        create.createinpiut();
                        break;
                    case 2:
                        UsingGeneric generic= new UsingGeneric();
                        generic.usingGeneric();
                        break;
                }
            }
        }
    }
}

