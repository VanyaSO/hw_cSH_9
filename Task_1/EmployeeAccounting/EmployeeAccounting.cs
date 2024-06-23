namespace Task_1;

public static class EmployeeAccounting
{
    private static List<Employee> _listEmployees = new List<Employee>();

    public static Predicate<Employee> FindByFullName(FullName fullName)
    {
        return empl => fullName.Compare(empl.FullName);
    }

    public static Predicate<Employee> FindByEmail(string email)
    {
        return empl => empl.CorporateEmail == email;
    }

    public static Comparison<Employee> SortByName()
    {
        return (empl1, empl2) => empl1.FullName.FirstName.CompareTo(empl2.FullName.FirstName);
    }

    public static void AddEmployee(Employee employee)
    {
        _listEmployees.Add(employee);
    }

    public static bool RemoveEmployee(FullName fullName)
    {
        return _listEmployees.Remove(FindEmployee(FindByFullName(fullName)));
    }

    public static bool ChangeEmployeeData(FullName fullName, Action<Employee> action)
    {
        Employee empl = FindEmployee(FindByFullName(fullName));

        if (empl != null)
        {
            action(empl);
            return true;
        }

        return false;
    }

    public static Employee FindEmployee(Predicate<Employee> predicate)
    {
        return _listEmployees.Find(predicate);
    }

    public static void SortList(Comparison<Employee> comparison)
    {
        _listEmployees.Sort(comparison);
    }

public static void Show()
    {
        foreach (var empl in _listEmployees)
        {
            Console.WriteLine(empl);
        }
    }
    
}