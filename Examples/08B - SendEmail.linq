<Query Kind="Program">
  <NuGetReference>SparkPost</NuGetReference>
  <Namespace>SparkPost</Namespace>
</Query>

void Main(string[] args)
{
#if CMD
	var recipient = args[0];
	var csv = Console.In.ReadToEnd();
#else
	var recipient = "test@test.com";
	var csv = "Column1,Column2,Column3,Column4\r\nItem1,Item1,Item1,Item1";
#endif

	var t = new Transmission();

	t.Content.From.Email = "no-reply@springfieldpublications.com";
	t.Content.Subject = "Your report is attached";
	t.Content.Text = "Here's your report, as requested.";

	new Recipient
	{
		Address = new Address { Email = recipient }
	}
	.Apply(t.Recipients.Add);
	
	new Attachment
	{
		Data = csv.Map(Encoding.UTF8.GetBytes).Map(Convert.ToBase64String),
		Name = "CustomerReport.csv",
		Type = "text/csv"
	}
	.Apply(t.Content.Attachments.Add);
	
	var client = new SparkPost.Client(Util.GetPassword("sparkpostapikey"));
	client.Transmissions.Send(t).Wait();
	
	"Done".Dump();
}

// lprun -format=csv "07A - QueryPeople.linq" Baker Capaldi | lprun "07B - SendEmail.linq" test@test.com