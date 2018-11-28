<Query Kind="Statements" />

public static class MyExtensions
{
	public static U Map<T, U>(this T x, Func<T, U> fn) => fn(x);
	public static T Tee<T>(this T x, Action<T> act)
	{
		act(x);
		return x;
	}

	public static IEnumerable<T> Iter<T>(this IEnumerable<T> seq, Action<T> act)
	{
		foreach (var item in seq) act(item);

		return seq;
	}

	public static IEnumerable<T> Iteri<T>(this IEnumerable<T> seq, Action<T, int> act)
	{
		var counter = 0;
		foreach (var item in seq) act(item, counter++);

		return seq;
	}
}

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