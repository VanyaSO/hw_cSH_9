namespace Task_1;

public class Employee
{
    public FullName FullName { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public string CorporateEmail { get; set; }

    public Employee(string fName, string lName, string sName, string position, double salary, string corporateEmail)
    {
        FullName = new FullName(fName, lName, sName);
        Position = position;
        Salary = salary;
        CorporateEmail = corporateEmail;
    }

    public override string ToString()
    {
        Console.WriteLine(FullName);
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"CorporateEmail: {CorporateEmail}");
        return "";
    }
}