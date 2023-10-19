public class DateTest
{
    public static int Main()
    {
        MyDate oneDate = new MyDate(2, 29, 2020);
        oneDate.Display();
        oneDate.Year = 2022;
        oneDate.Display();
        oneDate.SetDate(10, 31, 2022);
        oneDate.Display();
        oneDate.Month = 9;
        oneDate.Display();
        Console.WriteLine(oneDate);
        return 0;
    }
}

public class MyDate
{
    private int month;
    private int day;
    private int year;

    public int Month
    {
        get
        {
            return month;
        }
        set
        {
            if (value > 12 || value <= 0) { Console.WriteLine("illegal value for month"); }
            else
            {
                if (value == 4 || value == 6 || value == 9 || value == 11)
                {
                    if (this.day > 30)
                    {
                        Console.WriteLine("illegal value for day");
                    }
                    else
                    {
                        month = value;
                    }
                }
                if(value == 2)
                {
                    if((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
                    {
                        if(this.day > 29)
                        {
                            Console.WriteLine("illegal value for day");
                        }
                        else
                        {
                            month = value;
                        }
                    }
                    else
                    {
                        if(this.day > 28)
                        {
                            Console.WriteLine("illegal value for day");
                        }
                        else
                        {
                            month = value;
                        }
                    }
                }
                if(value == 1 || value == 3 || value == 5 || value == 7 || value == 8 || value == 10 || value == 12)
                {
                    month = value;
                }
            }
        }
    }

public int Day
{
    get
    {
        return day;
    }
    set
    {
        if (day <= 0 || day > 31)
        {
            Console.WriteLine("illegal value for day");
        }
        else
        {
            if (this.month == 1 || this.month == 3 || this.month == 5 || this.month == 7 || this.month == 8 || this.month == 10 || this.month == 12)
            {
                if (day > 0 && day <= 31)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("illegal value for day");
                }
            }
            if (this.month == 4 || this.month == 6 || this.month == 9 || this.month == 11)
            {
                if (day > 0 && day <= 30)
                {
                    day = value;
                }
                else
                {
                    Console.WriteLine("illegal value for day");
                }
            }
            if (this.month == 2)
            {
                if ((this.year % 4 == 0 && this.year % 100 != 0) || this.year % 400 == 0)
                {
                    if (day > 0 && day <= 29)
                    {
                        day = value;
                    }
                    else
                    {
                        Console.WriteLine("illegal value for day");
                    }
                }
                else
                {
                    if (day > 0 && day <= 28)
                    {
                        day = value;
                    }
                    else
                    {
                        Console.WriteLine("illegal value for day");
                    }
                }
            }
            else
            {
                Console.WriteLine("illegal value for day");
            }
        }
    }
}

public int Year
{
    get
    {
        return year;
    }
    set { 
            if(((this.year % 4 == 0 && this.year % 100 != 0) || this.year % 400 == 0)&& !(value % 4 ==0 && value %100 !=0 ))
            {
                if(this.day == 29)
                {
                    Console.WriteLine("illegal value for day");
                }
                else
                {
                    this.year = value;
                }
            }
            else
            {
                this.year = value;
            }

        
        
        }
}

public MyDate(int Month, int Day, int Year)
{
    if (Month > 31 || Month <= 0) { Console.WriteLine("illegal value for month"); }
    if (Day <= 0 || Day > 31)
    {
        Console.WriteLine("illegal value for day");
    }
    else
    {
        {
            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
            {
                if (Day > 0 && Day <= 31)
                {
                    this.year = Year;
                    this.month = Month;
                    this.day = Day;
                }
                else
                {
                    Console.WriteLine("illegal value for day");
                }
            }
            if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            {
                if (Day > 0 && Day <= 30)
                {
                    this.year = Year;
                    this.month = Month;
                    this.day = Day;
                }
                else
                {
                    Console.WriteLine("illegal value for day");
                }
            }
            if (Month == 2)
            {
                if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
                {
                    if (Day > 0 && Day <= 29)
                    {
                        this.year = Year;
                        this.month = Month;
                        this.day = Day;
                    }
                    else
                    {
                        Console.WriteLine("illegal value for day");
                    }
                }
                else
                {
                    if (Day > 0 && Day <= 28)
                    {
                        this.year = Year;
                        this.month = Month;
                        this.day = Day;
                    }
                    else
                    {
                        Console.WriteLine("illegal value for day");
                    }
                }
            }
        }
    }
}

public MyDate()
{
    this.day = 1;
    this.year = 2000;
    this.month = 1;
}

public void SetDate(int Month, int Day, int Year)
{
    if (Month > 31 || Month <= 0) { Console.WriteLine("illegal value for month"); }
    if (Day <= 0 || Day > 31)
    {
        Console.WriteLine("illegal value for day");
    }
    else
    {
        {
            if (Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
            {
                if (Day > 0 && Day <= 31)
                {
                    this.year = Year;
                    this.month = Month;
                    this.day = Day;
                }
                else
                {
                    Console.WriteLine("illegal value for day");
                }
            }
            if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
            {
                if (Day > 0 && Day <= 30)
                {
                    this.year = Year;
                    this.month = Month;
                    this.day = Day;
                }
                else
                {
                    Console.WriteLine("illegal value for day");
                }
            }
            if (Month == 2)
            {
                if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
                {
                    if (Day > 0 && Day <= 29)
                    {
                        this.year = Year;
                        this.month = Month;
                        this.day = Day;
                    }
                    else
                    {
                        Console.WriteLine("illegal value for day");
                    }
                }
                else
                {
                    if (Day > 0 && Day <= 28)
                    {
                        this.year = Year;
                        this.month = Month;
                        this.day = Day;
                    }
                    else
                    {
                        Console.WriteLine("illegal value for day");
                    }
                }
            }
        }
    }
}

public string Display()
{
    string disp = month + "月" + day + "日" + year + "年";
    Console.WriteLine(disp);
    return disp;
}

    public override string ToString()
    {
        return month + "月" + day + "日" + year + "年";
    }
}