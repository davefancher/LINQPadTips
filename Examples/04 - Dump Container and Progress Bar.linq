<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var people =
    DemoData
        .People;

var count = people.Count().ConvertTo<float>();

var pb = new Util.ProgressBar("Processing") { HideWhenCompleted = true }.Dump();
var dc = new DumpContainer("").Dump();

people
    .Iteri(
        (c, ix) =>
        {
            pb.Fraction = (ix + 1) / count;
            pb.Caption = $"Processing ({pb.Fraction:P0})";
            dc.UpdateContent(c);

            // Simulate long running process
            Task.Delay(500).Wait();
        });

Util.ClearResults();

"Done".Dump();