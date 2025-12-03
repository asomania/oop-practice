using System;

abstract class Emplooyeer{
    public string Name { get; set;}
    public string Department { get; set;}

    public Emplooyeer(){
    }
    /*
    * Burda verdiğimiz method bizim alt sınıflarda zorunlu olarak kullanmamızı sağlar.
    * Polimorfizm sağlar
    * Normal classlarda bu dayatma olmaz
    */
    public abstract int Salary();
}

class FullTimeEmployee : Emplooyeer {
    public int BaseSalary{get; set;}

    public FullTimeEmployee(string name, string department, int salary){
        Name = name;
        Department = department;
        BaseSalary = salary;
    }
    public override int Salary(){
        return BaseSalary + 1200;
    }
}

class PartTimeEmployee : Emplooyeer {
    public int HourlyRate { get; set; }
    public int WorkedHours { get; set; }

    public PartTimeEmployee(string name, string department, int rate, int hours)
    {
        Name = name;
        Department = department;
        HourlyRate = rate;
        WorkedHours = hours;
    }

    public override int Salary()
    {
        return HourlyRate * WorkedHours;
    }
}

class Program{
    static void Main(){
        Emplooyeer fullTimeEmployerr  = new FullTimeEmployee("Eren", "It", 300);
        Emplooyeer halfTimeEmployerr  = new PartTimeEmployee("Ali", "Sales", 100, 10);

        Console.WriteLine(fullTimeEmployerr.Salary());
        Console.WriteLine(halfTimeEmployerr.Salary());
    }
}