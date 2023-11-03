namespace N36_HT1.Models
{

    public record Person(string FirstName, string LastName);
    public record Employee(string FirstName, string LastName, double Salary) : Person(FirstName, LastName);
    public record Manager(string FirstName, string LastName, double Salary, string Department) : Employee(FirstName, LastName, Salary);

}