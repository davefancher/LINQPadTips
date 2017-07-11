<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

public IEnumerable<Person> GetPeople() =>
    DemoData
        .People
        .Select(
            p =>
            {
                Task.Delay(500).Wait();
    
                return p;
            });

void Main()
{
    var people =
        Util
            .Cache(
                () => GetPeople().ToArray(),
                "",
                out bool gotFromCache);
    
    gotFromCache.Dump("Got customers from cache?");
    people.Dump();
    
    var people2 =
        GetPeople()
            .Cache("", out bool gotFromCache2)
            .ToArray();
    
    gotFromCache2.Dump("Got customers from cache?");
    people2.Dump();
}

// Define other methods and classes here
