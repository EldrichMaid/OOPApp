namespace OOPApp
{
    class Human
        {
            // Поля класса
            public string name;
            public int age;

            // Метод класса
            public void Greetings()
            {
                Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
            }
        // Конструктор 1
        public Human()
        {
            name = "Неизвестно";
            age = 20;
        }
        // Конструктор 2
        public Human(string n)
        {
            name = n;
            age = 20;
        }
        // Конструктор 3
        public Human(string n, int a)
        {
            name = n;
            age = a;
        }
    }

    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Черный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }
    }

    class Rectangle
    {
        public int a;
        public int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int equal)
        {
            a = equal;
            b = equal;
        }

        public Rectangle(int diffone, int difftwo)
        {
            a = diffone;
            b = difftwo;
        }

        public int Square()
        {
            int SquareVal = a * b;
            Console.WriteLine("Для прямоугольника со сторонами {0} и {1} площадь равняется {2}", a, b,SquareVal);
            return SquareVal;
        }

       
    }

    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }

    class Bus
    {
        public int? Load;

        public Bus(int? load)
        {
            Load = load;
        }

        public void PrintStatus()
        {
            if (Load.HasValue && Load > 0)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("В автобусе не пассажиров");
            }
        }
    }

    class Car
    {
        public double Fuel;

        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }

        public void Move()
        {
            Mileage++;
            Fuel -= 0.5;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }
    }

    struct Animal
        {
            // Поля структуры
            public string type;
            public string name;
            public int age;

            // Метод структуры
            public void Info()
            {
                Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
            }
        }

    internal class Program
    {
        static Department GetCurrentDepartment()
        {
            Department department = new Department();
            department.Company = new Company();
            department.Company.Type = "Банк";
            department.Company.Name = "Сбербанк";
            department.City = new City();
            department.City.Name = "Санкт-Петербург";
            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
            return department;
        }

        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();
            human.name = "Иван";
            human.age = 28;
            human.Greetings();
            human = new Human("Ivan");
            human.Greetings();
            human = new Human("Иван", 28);
            human.Greetings();

            Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4 };
            animal.Info();

            var department = GetCurrentDepartment();
            
            Bus bus = new Bus(20);
            bus.PrintStatus();


            Console.ReadKey();
        }
    }
}
