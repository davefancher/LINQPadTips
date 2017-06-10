<Query Kind="Statements" />

public class Person
{
    public Person(string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }

    public Person(string firstName, string lastName)
        : this(firstName, "", lastName)
    { }

    public string FirstName { get; }
    public string MiddleName { get; }
    public string LastName { get; }

    // Customize object dumps
    //    object ToDump() =>
    //        new {
    //            FirstName = this.FirstName,
    //            LastName = this.LastName,
    //            MiddleName = Util.OnDemand("Click to reveal", () => this.MiddleName)
    //        };
}

// Globally customize object dumps
//static object ToDump(object o)
//{
//    var str = o as string;
//    if (str != null && str == "")
//    {
//        return Util.WithStyle("{not specified}", "color: #C0C0C0; font-style: italic;");
//    }
//
//    return o;
//}

public static class DemoData
{
    public static IEnumerable<Person> People =
        new[]
        {
            new Person("William", "Henry", "Hartnell"),
            new Person("Patrick", "George", "Troughton"),
            new Person("John", "Devon Roland", "Pertwee"),
            new Person("Thomas", "Steward", "Baker"),
            new Person("Peter", "Davison"),
            new Person("Colin", "Baker"),
            new Person("Sylvester", "McCoy"),
            new Person("Paul", "John", "McGann"),
            new Person("Sir John", "Vincent", "Hurt"),
            new Person("Christopher", "Eccleston"),
            new Person("David", "Tennant"),
            new Person("Matthew", "Robert", "Smith"),
            new Person("Peter", "Dougan", "Capaldi")
        };
}
