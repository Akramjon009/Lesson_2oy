using HttpCrud;
using HttpCrud.Comments_Crude;

public class Program
{
    private static HttpClient sharedClient = new()
    {
        BaseAddress = new Uri("https://jsonplaceholder.typicode.com"),
    };

    static async Task Main(string[] args)
    {
        #region Todosmathod
        //todosmathod.GetAsync(sharedClient).Wait();
        //string result2 = await todosmathod.DeleteAsync(sharedClient);
        //string resultofpatch = await todosmathod.PatchAsync(sharedClient,"code work");
        //string putasinc = await todosmathod.PutAsync(sharedClient);

        //Console.WriteLine(result2);
        //Console.WriteLine(resultofpatch);
        //Console.WriteLine(putasinc);
        #endregion

        #region commentsMathod
        //CommentsMethod.GetAsync(sharedClient).Wait();
        //string result_comment = await CommentsMethod.DeleteAsync(sharedClient);
        //string resultofpatch_comment = await CommentsMethod.PatchAsync(sharedClient, "code work");
        //string putasinc_comment = await CommentsMethod.PutAsync(sharedClient);

        //Console.WriteLine(result_comment);
        //Console.WriteLine(resultofpatch_comment);
        //Console.WriteLine(putasinc_comment);
        #endregion

        #region 
        albusMathod.GetAsync(sharedClient).Wait();
        string result2 = await albusMathod.DeleteAsync(sharedClient);
        string resultofpatch = await albusMathod.PatchAsync(sharedClient, "code work");
        string putasinc = await albusMathod.PutAsync(sharedClient);

        Console.WriteLine(result2);
        Console.WriteLine(resultofpatch);
        Console.WriteLine(putasinc);
        #endregion


    }
}
