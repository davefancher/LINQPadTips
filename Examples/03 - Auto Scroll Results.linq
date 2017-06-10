<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Util.AutoScrollResults = true;

DemoData
    .People
    .Iter(
        c =>
        {
            c.Dump();

            // Simulate long running process
            Task.Delay(100).Wait();
        });