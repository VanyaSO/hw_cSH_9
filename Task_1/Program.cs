using System.Threading.Channels;

namespace Task_1;

// Створіть додаток для обліку співробітників, який має зберігати
// наступну інформацію:
//  П.І.Б.;
//  посада;
//  заробітна плата;
//  корпоративний email.
// Для зберігання даних співробітників використовуйте клас
// List<T>.
// Додаток має надавати таку функціональність:
//  додавати співробітників;
//  видаляти співробітників;
//  змінювати інформацію про співробітників;
//  пошук співробітників за параметрами;
//  сортування співробітників за параметрами.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----Add-----");
        EmployeeAccounting.AddEmployee(new Employee("Emily", "Johnson", "Marie", "Data Scientist", 105000, "emily.johnson@company.com"));
        EmployeeAccounting.AddEmployee(new Employee("John", "Doe", "Michael", "Software Engineer", 85000, "john.doe@company.com"));
        EmployeeAccounting.AddEmployee(new Employee("Jane", "Smith", "Alice", "Product Manager", 95000, "jane.smith@company.com"));
        EmployeeAccounting.AddEmployee(new Employee("Alex", "Brown", "James", "UX Designer", 75000, "alex.brown@company.com"));
        EmployeeAccounting.Show();

        Console.WriteLine("-----Remove-----");
        FullName removeFullName = new FullName("Emily", "Johnson", "Marie");
        // удаляем пользователя и в зависимоти от рез. выводим инфорамцию об этом
        bool emplIsRemove = EmployeeAccounting.RemoveEmployee(removeFullName);
        Console.WriteLine(emplIsRemove ? $"--{removeFullName} successfully deleted" : $"--Error deleted {removeFullName}");
        
        Console.WriteLine("-----Change-----");
        FullName changeFullName = new FullName("John", "Doe", "Michael");
        Employee emplChangeData = EmployeeAccounting.FindEmployee(EmployeeAccounting.FindByFullName(changeFullName));
        Console.WriteLine(emplChangeData); // перед изменениями
        bool emplDataIsChange = EmployeeAccounting.ChangeEmployeeData(changeFullName, (empl) => { empl.Salary = 100; });
        Console.WriteLine((emplDataIsChange ? $"--Salary successfully changed" : "--Error changed"));
        Console.WriteLine(emplChangeData); // после изменений изменениями
        
        Console.WriteLine("-----Find-----");
        Console.WriteLine(EmployeeAccounting.FindEmployee(EmployeeAccounting.FindByFullName(changeFullName)));
        Console.WriteLine(EmployeeAccounting.FindEmployee(EmployeeAccounting.FindByEmail("alex.brown@company.com")));
        
        Console.WriteLine("-----Sort-----");
        EmployeeAccounting.SortList(EmployeeAccounting.SortByName());
        EmployeeAccounting.Show();
    }
}