using System.Net.Http.Json;
using System.Text.Json;
using System.Text;


namespace HttpCrud.Users_Crud
{
    internal class UsersMethod
    {
        #region deleate mathod
        public static async ValueTask<string> DeleteAsync(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync("users/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PatchAsync
        public static async ValueTask<string> PatchAsync(HttpClient httpClient, string Name)
        {
            using StringContent jsonContent = new
            (
                JsonSerializer.Serialize(new
                {
                    name = Name,
                }),
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await httpClient.PatchAsync("users/1", jsonContent);

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PutAsync
        public static async ValueTask<string> PutAsync(HttpClient httpClient,int Id,string Name,string userName,string Email,string Website)
        {
            using StringContent jsonContent = new
            (
                JsonSerializer.Serialize(new
                {
                    id = Id,
                    name = Name,
                    username = userName,
                    email = Email,
                    website = Website
                    
                }),
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await httpClient.PutAsync("users/1", jsonContent);

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PostAsync
        public static async ValueTask<string> PostAsync(HttpClient httpClient, int Id, string Name, string userName, string Email, string Website)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("todos", new Users(id:Id,name:Name,username:userName,email:Email,website:Website));

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region GetAsync
        public static async Task GetAsync(HttpClient httpClient)
        {

            using HttpResponseMessage response = await httpClient.GetAsync("users/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"{jsonResponse}\n");
        }
        #endregion
    }
}
