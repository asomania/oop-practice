using System;
using System.Collections.Generic;
/*
* Interface bizim için bir sözleşme gibidir.
* Bir sınıfın hangi metotları uygulaması gerektiğini belirler.
* Bu örnekte, ISalaryReport arayüzü, maaş raporu oluşturma işlevselliğini tanımlar.
* Bir sınıf bu arayüzü uyguladığında, GenerateReport metodunu içermek zorundadır.
* Bu, farklı sınıfların aynı raporlama işlevselliğini paylaşmasını sağlar.
* Ayrıca, IComparable arayüzü, Employee sınıfının nesnelerinin sıralanmasını sağlar.
* IComparable arayüzü, CompareTo metodunu içerir ve bu metod, nesnelerin nasıl karşılaştırılacağını belirler. 
* Built-in arayüzler, .NET Framework tarafından sağlanan ve yaygın olarak kullanılan arayüzlerdir.
*/
public interface ISalaryReport{
    void GenerateReport();
}

public class Employee : IComparable<Employee>, ISalaryReport {
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int salary){
        Name = name;
        Salary = salary;
    }

    public int CompareTo(Employee other){
        return this.Name.CompareTo(other.Name);
    }
    public void GenerateReport(){
        Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
    }
}

class Program {
    static void Main(string[] args) {
        List<Employee> employees = new List<Employee>{
            new Employee("Zlice", 50000),
            new Employee("Bob", 60000),
            new Employee("Charlie", 55000)
        };

        employees.Sort();  

        foreach(var emp in employees){
            Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}");
            emp.GenerateReport();
    
        }
    }
}
