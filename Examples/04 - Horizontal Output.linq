<Query Kind="Statements" />

Util
    .HorizontalRun(
        true,
        DemoData.People)
    .Dump();

Util
    .HorizontalRun(
        true,
        "Check out the",
        new Hyperlinq("http://kcdc.info/sessions", "sessions"),
        "at KCDC!")
    .Map(run => Util.WithStyle(run, "font-size: 16pt;"))
    .Dump();

Util
    .WordRun(
        true,
        "Check out the",
        new Hyperlinq("http://kcdc.info/sessions", "sessions"),
        "at KCDC!")
    .Map(run => Util.WithStyle(run, "font-size: 16pt;"))
    .Dump();
