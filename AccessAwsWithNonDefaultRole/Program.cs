namespace AccessAwsWithNonDefaultRole
{
    using Amazon.SimpleSystemsManagement;
    using Amazon.SimpleSystemsManagement.Model;
    using Newtonsoft.Json;

    internal class Program
    {
        private static async Task Main(string[] args)
        {
            AmazonSimpleSystemsManagementClient client = new();

            GetParameterResponse response = await client.GetParameterAsync(
                new GetParameterRequest
                {
                    Name = "/exl/stage/NReco/Owner",
                    WithDecryption = true,
                });

            Console.WriteLine(
                JsonConvert.SerializeObject(
                    response,
                    Formatting.Indented));
        }
    }
}