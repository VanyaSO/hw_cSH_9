namespace Task_2;

public struct FullName
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SurName { get; set; }

    public FullName(string fNme, string lName, string sName)
    {
        FirstName = fNme;
        LastName = lName;
        SurName = sName;
    }
    
    public override string ToString()
    {
        return $"{LastName} {FirstName} {SurName}";
    }
}