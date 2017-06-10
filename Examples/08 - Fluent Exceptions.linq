<Query Kind="Statements" />

Util
    .Try(
        () => throw new NotImplementedException(),
        ex =>
        {
            ex.Dump("Exception");
            return new Person("", "", "");
        })
    .Dump("Result");
    