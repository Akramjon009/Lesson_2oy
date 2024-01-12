using HttpCrud;

public class Program
{
    private static HttpClient sharedClient = new()
    {
        BaseAddress = new Uri("https://jsonplaceholder.typicode.com"),
    };

    static async Task Main(string[] args)
    {
        #region Todosmathod
        todosmathod.GetAsync(sharedClient).Wait();
        string result2 = await todosmathod.DeleteAsync(sharedClient);
        string resultofpatch = await todosmathod.PatchAsync(sharedClient,"code work");
        string putasinc = await todosmathod.PutAsync(sharedClient);

        Console.WriteLine(result2);
        Console.WriteLine(resultofpatch);
        Console.WriteLine(putasinc);
        #endregion


    }
}
