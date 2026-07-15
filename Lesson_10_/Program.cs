// Main 

Device[] devices = new Device[]
{
    new Kettle("AquaBoil 3000", "Philips", 2, 2200),
    new Car("Model S", "Tesla", 250, "Electric")
};

for (int i = 0; i < devices.Length; i++)
{
    devices[i].Show();
    devices[i].Desc();
    devices[i].Sound();
    Console.WriteLine();
}

MusicalInstrument[] instruments = new MusicalInstrument[]
{
    new Violin("Classic Violin", "Italy", 4, "Bowed")
};

for (int i = 0; i < instruments.Length; i++)
{
    instruments[i].Show();
    instruments[i].Desc();
    instruments[i].Sound();
    instruments[i].History();
    Console.WriteLine();
}

Worker[] workers = new Worker[]
{
    new President("Ilham Aliyev", 52, 15000, "SOCAR")
};

for (int i = 0; i < workers.Length; i++)
{
    workers[i].Print();
    Console.WriteLine();
}

class Device
{
    public string Name { get; set; }
    public string Brand { get; set; }

    public Device(string name, string brand)
    {
        Name = name;
        Brand = brand;
    }

    public virtual void Sound()
    {
        Console.WriteLine("...");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Device: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Brand: {Brand}");
    }
}

class Kettle : Device
{
    public int Volume { get; set; }
    public int Power { get; set; }

    public Kettle(string name, string brand, int volume, int power) : base(name, brand)
    {
        Volume = volume;
        Power = power;
    }

    public override void Sound()
    {
        Console.WriteLine("Shhhhh... click!");
    }

    public override void Show()
    {
        Console.WriteLine($"Kettle: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Brand: {Brand}, Volume: {Volume}L, Power: {Power}W");
    }
}

class Car : Device
{
    public int Speed { get; set; }
    public string FuelType { get; set; }

    public Car(string name, string brand, int speed, string fuelType) : base(name, brand)
    {
        Speed = speed;
        FuelType = fuelType;
    }

    public override void Sound()
    {
        Console.WriteLine("Vroom vroom!");
    }

    public override void Show()
    {
        Console.WriteLine($"Car: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Brand: {Brand}, Max speed: {Speed} km/h, Fuel: {FuelType}");
    }
}

class MusicalInstrument
{
    public string Name { get; set; }
    public string Origin { get; set; }
    public int StringCount { get; set; }

    public MusicalInstrument(string name, string origin, int stringCount)
    {
        Name = name;
        Origin = origin;
        StringCount = stringCount;
    }

    public virtual void Sound()
    {
        Console.WriteLine("...");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Instrument: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Origin: {Origin}, Strings: {StringCount}");
    }

    public virtual void History()
    {
        Console.WriteLine("History unknown.");
    }
}

class Violin : MusicalInstrument
{
    public string Type { get; set; }

    public Violin(string name, string origin, int stringCount, string type) : base(name, origin, stringCount)
    {
        Type = type;
    }

    public override void Sound()
    {
        Console.WriteLine("Squeeeak... eeee...");
    }

    public override void Show()
    {
        Console.WriteLine($"Instrument: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Origin: {Origin}, Strings: {StringCount}, Type: {Type}");
    }

    public override void History()
    {
        Console.WriteLine("Appeared in Italy in the 16th century. Very popular in classical music.");
    }
}

abstract class Worker
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Worker(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public abstract void Print();
}

class President : Worker
{
    public string Company { get; set; }

    public President(string name, int age, double salary, string company) : base(name, age, salary)
    {
        Company = company;
    }

    public override void Print()
    {
        Console.WriteLine($"Position: President");
        Console.WriteLine($"Name: {Name}, Age: {Age}");
        Console.WriteLine($"Company: {Company}, Salary: ${Salary}");
    }
}
