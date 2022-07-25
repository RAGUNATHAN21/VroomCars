using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello .netcore World");
            employee e = new employee(1, "Ragu");
            Console.WriteLine($"Id is {e.id} Name is {e.name}");
            Console.ReadKey();
        }

        class employee
        {
            public int id { get; set; }
            public string name { get; set; }
            public  employee ( int id,string name)
            {
                this.id = id;
                this.name = name;
            }
        }
    }
}
