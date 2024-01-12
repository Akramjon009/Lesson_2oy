using System.Text.Json;
using System.Text;
using System.Net.Http.Json;
using static HttpCrud.Checkall;
using System.ComponentModel;
using System.Reflection;
using System.Numerics;
namespace HttpCrud
{
    public class todosmathod(HttpClient httpClient)
    {

        #region deleate mathod
        public static async ValueTask<string> DeleteAsync(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync("todos/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PatchAsync
        public static async ValueTask<string> PatchAsync(HttpClient httpClient,string mytitle)
        {
            using StringContent jsonContent = new
            (
                JsonSerializer.Serialize(new
                {
                    title = mytitle,
                }),
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await httpClient.PatchAsync("todos/1", jsonContent);

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PutAsync
        public static async ValueTask<string> PutAsync(HttpClient httpClient,int userid = 1,int myid =15250 ,string Title= "code work",bool check = true)
        {
            using StringContent jsonContent = new
            (
                JsonSerializer.Serialize(new
                {
                    userId = userid,
                    id = myid,
                    title = Title,
                    completed = check
                }),
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await httpClient.PutAsync("todos/1", jsonContent);

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PostAsync
        public static async ValueTask<string> PostAsync(HttpClient httpClient,int userid,int myid,string title,bool check )
        {
            using StringContent jsonContent = new
            (
                JsonSerializer.Serialize(new
                {
                    userId = 77,
                    id = 1,
                    title = "write code",
                    completed = false
                }),
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await httpClient.PostAsJsonAsync("todos", new Todo(UserId: userid, Id: myid, Title: title, Completed: check));

            response.EnsureSuccessStatusCode().WriteRequestToConsole() ;

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region GetAsync
        public static async Task GetAsync(HttpClient httpClient)
        {

            using HttpResponseMessage response = await httpClient.GetAsync("todos/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"{jsonResponse}\n");
        }
        #endregion

    }
}
