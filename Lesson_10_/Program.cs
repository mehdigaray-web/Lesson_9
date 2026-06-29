//1
//public abstract class Device
//{
//    public string Name;
//    public string Characteristics;

//    public Device(string name, string characteristics)
//    {
//        Name = name;
//        Characteristics = characteristics;
//    }

//    public void Show()
//    {
//        Console.WriteLine($"Device: {Name}");
//    }

//    public void Desc()
//    {
//        Console.WriteLine($"Characteristics: {Characteristics}");
//    }

//    public abstract void Sound();
//}

//public class Kettle : Device
//{
//    public Kettle(string name, string characteristics) : base(name, characteristics) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound: Whoosh (water boiling) and whistle!");
//    }
//}

//public class Microwave : Device
//{
//    public Microwave(string name, string characteristics) : base(name, characteristics) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound: Bzzzz... Ding!");
//    }
//}

//public class Car : Device
//{
//    public Car(string name, string characteristics) : base(name, characteristics) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound: Vroom-vroom! Beep-beep!");
//    }
//}

//public class Steamboat : Device
//{
//    public Steamboat(string name, string characteristics) : base(name, characteristics) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound: Tuuuu-tuuuu!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("--- TASK 1: DEVICES ---");

//        Device myKettle = new Kettle("Tefal", "Electric, 2 Liters, 2000W");
//        myKettle.Show();
//        myKettle.Desc();
//        myKettle.Sound();

//        Console.WriteLine();

//        Device myCar = new Car("Toyota Camry", "Sedan, 2.5L Engine, Automatic");
//        myCar.Show();
//        myCar.Desc();
//        myCar.Sound();

//        Console.WriteLine("\nPress Enter to exit...");
//        Console.ReadLine();
//    }
//}


//2

//public abstract class MusicalInstrument
//{
//    public string Name;
//    public string Characteristics;
//    public string HistoryText;

//    public MusicalInstrument(string name, string characteristics, string historyText)
//    {
//        Name = name;
//        Characteristics = characteristics;
//        HistoryText = historyText;
//    }

//    public void Show()
//    {
//        Console.WriteLine($"Instrument: {Name}");
//    }

//    public void Desc()
//    {
//        Console.WriteLine($"Description: {Characteristics}");
//    }

//    public void History()
//    {
//        Console.WriteLine($"History: {HistoryText}");
//    }

//    public abstract void Sound();
//}

//public class Violin : MusicalInstrument
//{
//    public Violin(string name, string characteristics, string historyText) : base(name, characteristics, historyText) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound: Smooth and high-pitched string vibration.");
//    }
//}

//public class Trombone : MusicalInstrument
//{
//    public Trombone(string name, string characteristics, string historyText) : base(name, characteristics, historyText) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound: Loud and low brass honk.");
//    }
//}

//public class Ukulele : MusicalInstrument
//{
//    public Ukulele(string name, string characteristics, string historyText) : base(name, characteristics, historyText) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound: Light strumming of a small string instrument.");
//    }
//}

//public class Cello : MusicalInstrument
//{
//    public Cello(string name, string characteristics, string historyText) : base(name, characteristics, historyText) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound: Deep, rich, and low string resonance.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("--- TASK 2: MUSICAL INSTRUMENTS ---");

//        MusicalInstrument myViolin = new Violin("Stradivarius Model", "Acoustic, 4 strings", "Invented in Italy in the 16th century.");
//        myViolin.Show();
//        myViolin.Desc();
//        myViolin.History();
//        myViolin.Sound();

//        Console.WriteLine();

//        MusicalInstrument myTrombone = new Trombone("Yamaha Standard", "Brass, slide action", "Evolved from the sackbut in the 15th century.");
//        myTrombone.Show();
//        myTrombone.Desc();
//        myTrombone.History();
//        myTrombone.Sound();

//        Console.WriteLine("\nPress Enter to exit...");
//        Console.ReadLine();
//    }
//}

//3

//public abstract class Worker
//{
//    public abstract void Print();
//}

//public class President : Worker
//{
//    public override void Print()
//    {
//        Console.WriteLine("Position: President. Duties: Company management, making key decisions.");
//    }
//}

//public class Security : Worker
//{
//    public override void Print()
//    {
//        Console.WriteLine("Position: Security Guard. Duties: Ensuring safety of staff and property.");
//    }
//}

//public class Manager : Worker
//{
//    public override void Print()
//    {
//        Console.WriteLine("Position: Manager. Duties: Process organization, working with clients and staff.");
//    }
//}

//public class Engineer : Worker
//{
//    public override void Print()
//    {
//        Console.WriteLine("Position: Engineer. Duties: Development, design, and technical support.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("--- TASK 3: WORKERS ---");

//        Worker manager = new Manager();
//        manager.Print();

//        Worker engineer = new Engineer();
//        engineer.Print();

//        Worker president = new President();
//        president.Print();

//        Worker security = new Security();
//        security.Print();

//        Console.WriteLine("\nPress Enter to exit...");
//        Console.ReadLine();
//    }
//}