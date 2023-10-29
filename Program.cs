using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    class Money
    {
        char type;
        private int first;
        private int second;

        public int First
        {
            get { return first; }
            set { first = value; }
        }

        public int Second
        {
            get { return second; }
            set { second = value; }
        }

        public Money(char type, int x, int y)
        {
            this.type = type;
            First = x;
            Second = y;
        }

        public string getCount()
        {
            return type + First.ToString() + '.' + Second.ToString();
        }
    }
    class Product
    {
        Money cost;
        string name { get; }
        string article { get; }

        public void Show()
        {
            Console.WriteLine($"{name}|{cost.getCount()}|{article}");
        }

        public Product(double cost, string name, string article)
        {
            this.cost = new Money('$', (int)cost, (int)((cost - (int)cost) * 10));
            this.name = name;
            this.article = article;
        }

        public void addCost(double addCost)
        {
            double currentCost = cost.First + cost.Second / 10.0;
            double newCost = currentCost + addCost;
            cost.First = (int)newCost;
            cost.Second = (int)((newCost - (int)newCost) * 10);
        }

        public void decimalCost(double decreaseAmount)
        {
            double currentCost = cost.First + cost.Second / 10.0;
            double newCost = currentCost - decreaseAmount;

            if (newCost < 0)
            {
                cost.First = 0;
                cost.Second = 0;
            }
            else
            {
                cost.First = (int)newCost;
                cost.Second = (int)((newCost - (int)newCost) * 10);
            }
        }
    }


    class Device
    {
        protected string name;
        protected string description;

        public Device(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void Sound()
        {
            Console.WriteLine("Звук устройства: звук " + name);
        }

        public void Show()
        {
            Console.WriteLine("Название устройства: " + name);
        }

        public void Desc()
        {
            Console.WriteLine("Описание устройства: " + description);
        }
    }
    class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description)
        {
        }
    }
    class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description)
        {
        }
    }
    class Car : Device
    {
        public Car(string name, string description) : base(name, description)
        {
        }
    }
    class Ship : Device
    {
        public Ship(string name, string description) : base(name, description)
        {
        }
    }


    class MusicalInstrument
    {
        protected string name;
        protected string description;
        protected string history;

        public MusicalInstrument(string name, string description, string history)
        {
            this.name = name;
            this.description = description;
            this.history = history;
        }

        public void Sound()
        {
            Console.WriteLine("Звук музыкального инструмента: " + description);
        }

        public void Show()
        {
            Console.WriteLine("Название музыкального инструмента: " + name);
        }

        public void Desc()
        {
            Console.WriteLine("Описание музыкального инструмента: " + description);
        }

        public void History()
        {
            Console.WriteLine("История создания музыкального инструмента: " + history);
        }
    }
    class Violin : MusicalInstrument
    {
        public Violin(string name, string description, string history) : base(name, description, history)
        {
        }
    }
    class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description, string history) : base(name, description, history)
        {
        }
    }
    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description, string history) : base(name, description, history)
        {
        }
    }
    class Cello : MusicalInstrument
    {
        public Cello(string name, string description, string history) : base(name, description, history)
        {
        }
    }


    abstract class Worker
    {
        public abstract void Print();
    }
    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Должность: Президент");
            Console.WriteLine("Обязанности: Управление компанией");
            Console.WriteLine("Зарплата: Высокая");
        }
    }
    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Должность: Охранник");
            Console.WriteLine("Обязанности: Обеспечение безопасности на объекте");
            Console.WriteLine("Зарплата: Средняя");
        }
    }
    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Должность: Менеджер");
            Console.WriteLine("Обязанности: Управление проектами и персоналом");
            Console.WriteLine("Зарплата: Средняя");
        }
    }
    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Должность: Инженер");
            Console.WriteLine("Обязанности: Разработка и инженерное проектирование");
            Console.WriteLine("Зарплата: Средняя");
        }
    }
    class Program
    {
        static void Q1()
        {
            Product product = new Product(50.4, "Огурец", "000321");
            product.Show();
            product.addCost(5.4);
            product.Show();
            product.decimalCost(10.45);
            product.Show();
        }
        static void Q2()
        {
            Kettle kettle = new Kettle("Чайник", "Для кипячения воды");
            Microwave microwave = new Microwave("Микроволновка", "Для разогрева пищи");
            Car car = new Car("Автомобиль", "Для перевозки людей и грузов");
            Ship ship = new Ship("Пароход", "Для плавания по водным маршрутам");

            kettle.Show();
            kettle.Desc();
            kettle.Sound();

            microwave.Show();
            microwave.Desc();
            microwave.Sound();

            car.Show();
            car.Desc();
            car.Sound();

            ship.Show();
            ship.Desc();
            ship.Sound();
        }
        static void Q3()
        {
            Violin violin = new Violin("Скрипка", "Для исполнения классической музыки", "Скрипка была разработана в XVI веке");
            Trombone trombone = new Trombone("Тромбон", "Для создания бархатного звука", "Тромбон был разработан в XV веке");
            Ukulele ukulele = new Ukulele("Укулеле", "Для исполнения музыки на Гавайях", "Укулеле было разработано в XIX веке");
            Cello cello = new Cello("Виолончель", "Для исполнения симфонической музыки", "Виолончель была разработана в XVI веке");

            violin.Show();
            violin.Desc();
            violin.Sound();
            violin.History();

            trombone.Show();
            trombone.Desc();
            trombone.Sound();
            trombone.History();

            ukulele.Show();
            ukulele.Desc();
            ukulele.Sound();
            ukulele.History();

            cello.Show();
            cello.Desc();
            cello.Sound();
            cello.History();
        }
        static void Q4()
        {
            President president = new President();
            Security security = new Security();
            Manager manager = new Manager();
            Engineer engineer = new Engineer();

            Console.WriteLine("Информация о работниках:");
            Console.WriteLine("------------------------");

            president.Print();
            Console.WriteLine();

            security.Print();
            Console.WriteLine();

            manager.Print();
            Console.WriteLine();

            engineer.Print();
        }
        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3();
            //Q4();
        }
    }

}
