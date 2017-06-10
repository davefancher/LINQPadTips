<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var people =
    Util
        .Cache(
            () =>
                DemoData
                    .People
                    .Select(
                        p =>
                        {
                            Task.Delay(500).Wait();
        
                            return p;
                        })
                    .ToArray(),
            "",
            out bool gotFromCache);

gotFromCache.Dump("Got customers from cache?");
people.Dump();