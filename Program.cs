
interface IGeoObj
{
    string GetInfo();
}

class River : IGeoObj
{
    private int x;
    public int y;
    public string name;
    public string description;
    private int speed;
    private int length;

    public River(int x, int y, string name, string description, int speed, int length)
    {
        this.x = x;
        this.y = y;
        this.name = name;
        this.description = description;
        this.speed = speed;
        this.length = length;
    }

    public string GetInfo(int x, int y, string name, string description, int speed, int length)
    {
        return "Координати X: " + x + "\n" + "Координати Y: " + y + "\n" + "Назва: " + name + "\n" + "Опис: " + description + "\n" + "Швидкiсть течiй: " + speed + " км/ч" + "\nДовжина: " + length;
    }

    public string GetInfo()
    {
        throw new NotImplementedException();
    }
}

class Mountain : IGeoObj
{
    private int x;
    public int y;
    public string name;
    public string description;
    private int hight;


    public Mountain(int x, int y, string name, string description, int hight)
    {
        this.x = x;
        this.y = y;
        this.name = name;
        this.description = description;
        this.hight = hight;

    }

    public string GetInfo(int x, int y, string name, string description, int hight)
    {
        return "Координати X: " + x + "\n" + "Координати Y: " + y + "\n" + "Назва: " + name + "\n" + "Опис: " + description + "\n" + "Найвища точка: " + hight + " метрiв";

    }
    public string GetInfo()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int checkNum()
        {
            int value = 0;
            while (true)
            {
                try
                {
                    value = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введiть число!");
                    continue;
                }
                if (value < 1)
                {
                    Console.WriteLine("Число повинно бути додатне");
                    continue;
                }
                return value;
            }
        }

        int checkcoord()
        {
            int value = 0;
            while (true)
            {
                try
                {
                    value = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введiть число!");
                    continue;
                }
                return value;
            }
        }

        int x;
        int y;
        string name;
        string description;
        int obj;
        int speed;
        int hight;
        int check;
        int length;
        Console.WriteLine("Введiть координати об`екта по координатам X");
        x = checkcoord();
        Console.WriteLine("Введiть координати об`екта по координатам Y");
        y = checkcoord();
        Console.WriteLine("Введiть назву об`екта");
        name = Console.ReadLine();
        Console.WriteLine("Введiть опис об`екта");
        description = Console.ReadLine();
        Console.WriteLine("Якщо це рiчка, введiть 1\nЯкщо це гора, введiть 2");
        obj = checkcoord();
        while (obj != 1 && obj != 2)
        {
            Console.WriteLine("Щось не так! Спробуйте ще раз!");
            obj = checkcoord();
        }
        if (obj == 1)
        {
            Console.WriteLine("Введiть швидкiсть течiй");
            speed = checkNum();
            Console.WriteLine("Введiть довжину рiчки");
            length = checkNum();
            River riv = new River(x, y, name, description, speed, length);
            Console.WriteLine();
            Console.WriteLine(riv.GetInfo(x, y, name, description, speed, length));
        }
        else if (obj == 2)
        {
            Console.WriteLine("Введiть найвищу точку гори");
            hight = checkNum();
            Mountain mount = new Mountain(x, y, name, description, hight);
            Console.WriteLine();
            Console.WriteLine(mount.GetInfo(x, y, name, description, hight));
        }
    }
}
