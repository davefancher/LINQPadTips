<Query Kind="Statements" />

DemoData
    .People
    .First()
    .Map(p => $"{p.LastName}, {p.FirstName}")
//    .Map(name => Util.HighlightIf(name, n => n.StartsWith("A")))
//    .Tee(o => o.GetType().Dump())
    .Map(name => Util.WithStyle(name, "text-decoration: underline; font-size: 14pt; color: orange;"))
//    .Tee(o => o.GetType().Dump())
    .Dump();
    