// task 1
class Device
{
    public string Name;
    public string Brand;

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
        Console.WriteLine("Device: " + Name);
    }

    public virtual void Desc()
    {
        Console.WriteLine("Brand: " + Brand);
    }
}

class Kettle : Device
{
    public int Volume;
    public int Power;

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
        Console.WriteLine("Kettle: " + Name);
    }

    public override void Desc()
    {
        Console.WriteLine("Brand: " + Brand + ", Volume: " + Volume + "L, Power: " + Power + "W");
    }
}

class Microwave : Device
{
    public int Power;
    public double CameraVolume;

    public Microwave(string name, string brand, int power, double cameraVolume) : base(name, brand)
    {
        Power = power;
        CameraVolume = cameraVolume;
    }

    public override void Sound()
    {
        Console.WriteLine("Ding!");
    }

    public override void Show()
    {
        Console.WriteLine("Microwave: " + Name);
    }

    public override void Desc()
    {
        Console.WriteLine("Brand: " + Brand + ", Power: " + Power + "W, Volume: " + CameraVolume + "L");
    }
}

class Car : Device
{
    public int Speed;
    public string FuelType;

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
        Console.WriteLine("Car: " + Name);
    }

    public override void Desc()
    {
        Console.WriteLine("Brand: " + Brand + ", Max speed: " + Speed + "km/h, Fuel: " + FuelType);
    }
}

class Steamship : Device
{
    public int Capacity;
    public double Length;

    public Steamship(string name, string brand, int capacity, double length) : base(name, brand)
    {
        Capacity = capacity;
        Length = length;
    }

    public override void Sound()
    {
        Console.WriteLine("Tuuuuut!!!");
    }

    public override void Show()
    {
        Console.WriteLine("Steamship: " + Name);
    }

    public override void Desc()
    {
        Console.WriteLine("Brand: " + Brand + ", Capacity: " + Capacity + " passengers, Length: " + Length + "m");
    }
}

// Main

Kettle kettle = new Kettle("AquaBoil 3000", "Philips", 2, 2200);
Microwave microwave = new Microwave("QuickHeat X5", "Samsung", 900, 25);
Car car = new Car("Model S", "Tesla", 250, "Electric");
Steamship steamship = new Steamship("Atlantic Queen", "Carnival", 3000, 320);

List<Device> devices = new List<Device>();
devices.Add(kettle);
devices.Add(microwave);
devices.Add(car);
devices.Add(steamship);

for (int i = 0; i < devices.Count; i++)
{
    devices[i].Show();
    devices[i].Desc();
    devices[i].Sound();
    Console.WriteLine();
}

// task 2

class MusicalInstrument
{
    public string Name;
    public string Origin;
    public int StringCount;

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
        Console.WriteLine("Instrument: " + Name);
    }

    public virtual void Desc()
    {
        Console.WriteLine("Origin: " + Origin + ", Strings: " + StringCount);
    }

    public virtual void History()
    {
        Console.WriteLine("History unknown.");
    }
}

class Violin : MusicalInstrument
{
    public Violin() : base("Violin", "Italy", 4) { }

    public override void Sound()
    {
        Console.WriteLine("Squeeeak... eeee...");
    }

    public override void Show()
    {
        Console.WriteLine("Instrument: Violin");
    }

    public override void Desc()
    {
        Console.WriteLine("Origin: Italy, Strings: 4, Type: Bowed");
    }

    public override void History()
    {
        Console.WriteLine("The violin appeared in northern Italy in the early 16th century. " +
            "It evolved from earlier bowed instruments like the rebec and lira da braccio.");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone() : base("Trombone", "Europe", 0) { }

    public override void Sound()
    {
        Console.WriteLine("Bwaaaaah... wah wah...");
    }

    public override void Show()
    {
        Console.WriteLine("Instrument: Trombone");
    }

    public override void Desc()
    {
        Console.WriteLine("Origin: Europe, Type: Brass wind, No strings");
    }

    public override void History()
    {
        Console.WriteLine("The trombone was developed in the 15th century in Burgundy. " +
            "It was originally called the sackbut and was widely used in church music.");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele() : base("Ukulele", "Portugal/Hawaii", 4) { }

    public override void Sound()
    {
        Console.WriteLine("Dum dum da-da dum...");
    }

    public override void Show()
    {
        Console.WriteLine("Instrument: Ukulele");
    }

    public override void Desc()
    {
        Console.WriteLine("Origin: Portugal/Hawaii, Strings: 4, Type: Plucked");
    }

    public override void History()
    {
        Console.WriteLine("The ukulele was introduced to Hawaii in 1879 by Portuguese immigrants. " +
            "It became a symbol of Hawaiian culture and gained worldwide popularity in the 20th century.");
    }
}

class Cello : MusicalInstrument
{
    public Cello() : base("Cello", "Italy", 4) { }

    public override void Sound()
    {
        Console.WriteLine("Mmmmm... ooohhh...");
    }

    public override void Show()
    {
        Console.WriteLine("Instrument: Cello");
    }

    public override void Desc()
    {
        Console.WriteLine("Origin: Italy, Strings: 4, Type: Bowed, tuning: C-G-D-A");
    }

    public override void History()
    {
        Console.WriteLine("The cello emerged in Italy during the 16th century. " +
            "Its deep, rich tone made it a staple of orchestras and chamber music by the 18th century.");
    }
}

// Main

List<MusicalInstrument> instruments = new List<MusicalInstrument>();
instruments.Add(new Violin());
instruments.Add(new Trombone());
instruments.Add(new Ukulele());
instruments.Add(new Cello());

for (int i = 0; i < instruments.Count; i++)
{
    instruments[i].Show();
    instruments[i].Desc();
    instruments[i].Sound();
    instruments[i].History();
    Console.WriteLine();
}

//task 3

abstract class Worker
{
    public string Name;
    public int Age;
    public double Salary;

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
    public string Company;

    public President(string name, int age, double salary, string company) : base(name, age, salary)
    {
        Company = company;
    }

    public override void Print()
    {
        Console.WriteLine("Position: President");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Company: " + Company);
        Console.WriteLine("Salary: $" + Salary);
    }
}

class Security : Worker
{
    public string Post;

    public Security(string name, int age, double salary, string post) : base(name, age, salary)
    {
        Post = post;
    }

    public override void Print()
    {
        Console.WriteLine("Position: Security");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Post: " + Post);
        Console.WriteLine("Salary: $" + Salary);
    }
}

class Manager : Worker
{
    public string Department;
    public int TeamSize;

    public Manager(string name, int age, double salary, string department, int teamSize) : base(name, age, salary)
    {
        Department = department;
        TeamSize = teamSize;
    }

    public override void Print()
    {
        Console.WriteLine("Position: Manager");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Team size: " + TeamSize);
        Console.WriteLine("Salary: $" + Salary);
    }
}

class Engineer : Worker
{
    public string Specialization;
    public int Experience;

    public Engineer(string name, int age, double salary, string specialization, int experience) : base(name, age, salary)
    {
        Specialization = specialization;
        Experience = experience;
    }

    public override void Print()
    {
        Console.WriteLine("Position: Engineer");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Specialization: " + Specialization);
        Console.WriteLine("Experience: " + Experience + " years");
        Console.WriteLine("Salary: $" + Salary);
    }
}

// Main

List<Worker> workers = new List<Worker>();
workers.Add(new President("Ilham Aliyev", 52, 15000, "SOCAR"));
workers.Add(new Security("Tural Mammadov", 35, 800, "Main entrance"));
workers.Add(new Manager("Aysel Hasanova", 40, 3500, "Sales", 12));
workers.Add(new Engineer("Rauf Guliyev", 29, 2200, "Software", 5));

for (int i = 0; i < workers.Count; i++)
{
    workers[i].Print();
    Console.WriteLine();
}

