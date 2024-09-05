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
                Console.WriteLine("В автобусе нет пассажиров");
            }
        }
    }

    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }

    class Car
    {
        private double Fuel;
        public int Mileage;
        private string color;
        private TurnDirection turn;
        public static int MinPrice = 100_000;
        public static int MaxPrice;
        public int Price;

        static Car()
        {
            Console.WriteLine("Вызван статический конструктор класса Car");
            MaxPrice = 1_000_000;
        }

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }

        public virtual void Move()
        {
            Console.WriteLine("Вызван метод Move класса Car");
            Mileage++;
            Fuel -= 0.5;
        }

        private void Turn(TurnDirection direction)
        {
            turn = direction;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }

        public string GetColor()
        {
            return color;
        }

        public void ChangeColor(string newColor)
        {
            if (color != newColor)
                color = newColor;
        }

        public bool IsTurningLeft()
        {
            return turn == TurnDirection.Left;
        }

        public bool IsTurningRight()
        {
            return turn == TurnDirection.Right;
        }
    }

    enum FuelType
    {
        Gas = 0,
        Electricity
    }

    class HybridCar : Car
    {
        public FuelType FuelType;
        public double Gas;
        public double Electricity;

        public HybridCar()
        {
            Electricity = 50;
            Gas = 50;
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("Вызван метод Move класса HybridCar");
            Mileage++;

            switch (FuelType)
            {
                case FuelType.Gas:
                    Gas -= 0.5;
                    break;
                case FuelType.Electricity:
                    Electricity -= 0.5;
                    break;
            }
        }

        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }

    class Circle
    {
        public double radius;

        public double Area()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double Length()
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }

    class Triangle
    {
        public int a;
        public int b;
        public int c;

        public double Area()
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public double Perimeter()
        {
            double per = (a + b + c);
            return per;
        }
    }

    class Square
    {
        public int side;

        public double Area()
        {
            double area = Math.Pow(side, 2);
            return area;
        }

        public double Perimeter()
        {
            int per = side * 4;
            return per;
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

    class TrafficLight
    {
        private string color;

        private void ChangeColor(string newcolor)
        {
            if (color != newcolor)
                color = newcolor;
        }

        public string GetColor()
        {
            return color;
        }
    }

    class User
    {
        private string _login;
        private string _email;
        private int age;

        public string Login
        {
            get { return _login; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Login must be at least 3 symbols long.");
                }
                _login = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Email must contain '@'.");
                }
                _email = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Age must be at least 18.");
                }
                else
                {
                    age = value;
                }
            }
        }

        public User(string login, string email, int age)
        {
            Login = login;
            Email = email;
            Age = age;
        }

    }

    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager : Employee
    {
        public string ProjectName;
    }

    class Developer : Employee
    {
        private string ProgrammingLanguage;
    }

    class Food { }

    class Vegetable : Food { }

    class Fruit : Food { }

    class Apple : Fruit { }

    class Banana : Fruit { }

    class Pear : Fruit { }

    class Potato : Vegetable { }

    class Carrot : Vegetable { }

    class Obj
    {
        private string name;
        private string description;
        public static int MaxValue;
        public static string Parent;
        public static int DaysInWeek;

        static Obj() 
        {
            MaxValue = 2000;
            Parent = "System.Object";
            DaysInWeek = 7;

        }

        public Obj()
        {
            Console.WriteLine("Вызван конструктор без параметров");
        }

        public Obj(string name, string description) : this()
        {
            this.name = name;
            this.description = description;
        }
    }

    class ObjectData
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public ObjectData(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
        public void DisplayData()
        {
            Console.WriteLine($"The data states that {name} owned by {owner} with length of {length} has the count of {count}");
        }
    }

    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }

        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;        

        public DerivedClass(string name, string description): base(name) 
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }

        private int counter;
        public override int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value >= 0)
                {
                    counter = value;
                }
            }
        }
    }

    class Citizen
    {
        public virtual double Age
        {
            get;
            set;
        }

        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }

    class CivilServant : Citizen
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class President : CivilServant
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 35)
                {
                    Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Вызван метод класса A");
        }
    }

    class B : A
    {
        public override void Display()
        {
            Console.WriteLine("Вызван метод класса B");
        }
    }

    class C : B
    {
        public new void Display()
        {
            Console.WriteLine("Вызван метод класса C");
        }
    }

    class AA
    {
        public virtual void Display()
        {
            Console.WriteLine("AA");
        }
    }

    class BB : AA
    {
        public new void Display()
        {
            Console.WriteLine("BB");
        }
    }

    class CC : AA
    {
        public override void Display()
        {
            Console.WriteLine("CC");
        }
    }

    class DD : BB
    {
        public new void Display()
        {
            Console.WriteLine("DD");
        }
    }

    class EE : CC
    {
        public new void Display()
        {
            Console.WriteLine("EE");
        }
    }

    class ObjOverload
    {
        public int Value;

        public static ObjOverload operator +(ObjOverload a, ObjOverload b)
        {
            return new ObjOverload
            {
                Value = a.Value + b.Value
            };
        }
        public static ObjOverload operator -(ObjOverload a, ObjOverload b)
        {
            return new ObjOverload
            {
                Value = a.Value - b.Value
            };
        }
    }

    class Book
    {
        public string Name;
        public string Author;
    }

    class BookCollection
    {
        private Book[] collection;
        public BookCollection(Book[] collection)
        {
            this.collection = collection;
        }
        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }
    }

    class IndexingClass
    {
        private int[] array;
        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }

    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class MotherBoard:ComputerPart
    {
        public override void Work() {}
    }

    class Processor : ComputerPart
    {
        public override void Work() {}
    }

    class GraphicCard : ComputerPart
    {
        public override void Work() {}
    }

    class Helper 
    {
        public static void Swap (ref int x, ref int y) 
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }

    static class StringExtensions
    {
        public static char GetLastChar(this string source)
        {
            return source[source.Length - 1];
        }
    }

    static class IntExtensions
    {
        public static int GetNegative(this int number)
        {
            if (number > 0)
            {
                return -number;
            }
            else
            {
                return number;
            }
        }
        public static int GetPositive(this int number)
        {
            if (number < 0)
            {
                return -number;
            }
            else
            {
                return number;
            }
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

            User user = null; 
            while (user == null)
            {
                try
                {
                    Console.Write("Enter Login (at least 3 characters): ");
                    string login = Console.ReadLine();
                    Console.Write("Enter Email (must contain '@'): ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Age (at least 18): ");
                    int age = int.Parse(Console.ReadLine());
                    user = new User(login, email, age);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please try again.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid age format. Please enter a number.");
                    Console.WriteLine("Please try again.");
                }
            }
            Console.WriteLine($"Login: {user.Login}, Email: {user.Email}, Age: {user.Age}");

            Car car = new HybridCar();
            car.Move();

            var obj = new Obj("Объект", "Нет описания");
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter name of the owner:");
            string owner = Console.ReadLine();
            Console.WriteLine("Enter objects length:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter objects count:");
            int count = int.Parse(Console.ReadLine());
            var ObjectData = new ObjectData(name, owner, length, count);
            ObjectData.DisplayData();

            Car ExtraCar = new Car();
            HybridCar hybridCar = new HybridCar();
            ExtraCar.Move();         
            hybridCar.Move();       
            ((Car)hybridCar).Move(); 
            Console.WriteLine(Car.MinPrice);
            Console.WriteLine(Car.MaxPrice);

            DerivedClass Object = new DerivedClass("name","description");
            Object.Display();

            A a = new A();
            B b = new B();
            C c = new C();
            a.Display();    // метод класса A
            b.Display();    // метод класса B
            ((A)b).Display();   // метод класса B
            c.Display();    // метод класса C
            ((A)c).Display();   // метод класса B
            ((B)c).Display();	// метод класса B

            var array = new Book[]
            {
                new Book
                {
                    Name = "Мастер и Маргарита",
                    Author = "М.А. Булгаков"
                },
                new Book
                {
                    Name = "Отцы и дети",
                    Author = "И.С. Тургенев"
                }
            };
            BookCollection collection = new BookCollection(array);
            Book book = collection[1];

            int num1 = 3;
            int num2 = 58;
            Helper.Swap(ref num1, ref num2);
            Console.WriteLine(num1); //58
            Console.WriteLine(num2); //3

            Console.WriteLine("Extension method results");
            string str = "Hello";
            Console.WriteLine(str.GetLastChar());
            Console.WriteLine("Строка".GetLastChar());
            
            Console.WriteLine("7.5.9 Extension results");
            int num3 = 7;
            int num4 = -13;
            int num5 = 0;            
            Console.WriteLine(num3.GetNegative()); //-7
            Console.WriteLine(num3.GetPositive()); //7
            Console.WriteLine(num4.GetNegative()); //-13
            Console.WriteLine(num4.GetPositive()); //13
            Console.WriteLine(num5.GetNegative()); //0
            Console.WriteLine(num5.GetPositive()); //0

            Console.ReadKey();
        }
    }
}
