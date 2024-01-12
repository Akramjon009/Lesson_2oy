
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;

namespace HttpCrud.Posts_Crude
{
    internal class PostsMehtod
    {
        #region deleate mathod
        public static async ValueTask<string> DeleteAsync(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync("posts/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PatchAsync
        public static async ValueTask<string> PatchAsync(HttpClient httpClient, string mytitle)
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

            HttpResponseMessage response = await httpClient.PatchAsync("posts/1", jsonContent);

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PutAsync
        public static async ValueTask<string> PutAsync(HttpClient httpClient, int userid = 1, int myid = 15250, string Title = "code work", bool Body = true)
        {
            using StringContent jsonContent = new
            (
                JsonSerializer.Serialize(new
                {
                    userId = userid,
                    id = myid,
                    title = Title,
                    body = Body
                }),
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await httpClient.PutAsync("posts/1", jsonContent);

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PostAsync
        public static async ValueTask<string> PostAsync(HttpClient httpClient, int userid, int myid, string title, bool Body = true)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("todos", new Post(UserId: userid, Id: myid, Title: title, body: Body));

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region GetAsync
        public static async Task GetAsync(HttpClient httpClient)
        {

            using HttpResponseMessage response = await httpClient.GetAsync("posts/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"{jsonResponse}\n");
        }
        #endregion
    }
}
