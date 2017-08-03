<Query Kind="Expression">
  <NuGetReference>CsvTools</NuGetReference>
  <Namespace>CsvTable = DataAccess.DataTable</Namespace>
  <Namespace>DataAccess</Namespace>
</Query>

DemoData
    .People
    .Dump()
    .Map(CsvTable.New.FromEnumerable)
    .SaveToString()