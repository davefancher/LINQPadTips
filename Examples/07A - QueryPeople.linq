<Query Kind="Program" />

void Main(string[] args)
{
#if CMD
	var lastNames = args.Select(name => name.ToLower());
#else
	var lastNames = new[] { "capaldi", "baker", "tennant" };
#endif
	
	DemoData
        .People
        .Join(
            lastNames,
            p => p.LastName.ToLower(),
            n => n,
            (p, _) => p)
        .OrderBy(p => p.LastName)
        .ThenBy(p => p.FirstName)
		.Dump();
}