using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using System.Globalization;
using System.Xml.Linq;

namespace HttpCrud.Comments_Crude
{
    internal class CommentsMethod
    {

        #region deleate mathod
        public static async ValueTask<string> DeleteAsync(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync("comments/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PatchAsync
        public static async ValueTask<string> PatchAsync(HttpClient httpClient, string myname)
        {
            using StringContent jsonContent = new
            (
                JsonSerializer.Serialize(new
                {
                    name = myname,
                }),
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await httpClient.PatchAsync("comments/1", jsonContent);

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PutAsync
        public static async ValueTask<string> PutAsync(HttpClient httpClient, int postid = 1, int myid = 15250, string Name = "Akramjon", string myemail = "abduvahobov@gmail.com", string Body = "work" )
        {
            using StringContent jsonContent = new
            (
                JsonSerializer.Serialize(new
                {
                    postId = postid,
                    id = myid,
                    name = Name,
                    email = myemail,
                    body = Body
                }),
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await httpClient.PutAsync("comments/1", jsonContent);

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PostAsync
        public static async ValueTask<string> PostAsync(HttpClient httpClient, int postid = 19, int myid = 15250, string Name = "Akramjon", string myemail = "abduvahobov@gmail.com", string Body = "work")
        {

            HttpResponseMessage response = await httpClient.PostAsJsonAsync("comments", new commentsdo(postId: postid, id: myid, name: Name, email: myemail,body: Body));

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region GetAsync
        public static async Task GetAsync(HttpClient httpClient)
        {

            using HttpResponseMessage response = await httpClient.GetAsync("comments/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"{jsonResponse}\n");
        }
        #endregion
    }
}
