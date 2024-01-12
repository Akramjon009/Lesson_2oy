using System.Net.Http.Json;
using System.Text.Json;
using System.Text;

namespace HttpCrud.Photos_Curde
{
    internal class PhotosMethods
    {
        #region deleate mathod
        public static async ValueTask<string> DeleteAsync(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync("photos/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PatchAsync
        public static async ValueTask<string> PatchAsync(HttpClient httpClient, string thumbnailurl)
        {
            using StringContent jsonContent = new
            (
                JsonSerializer.Serialize(new
                {
                    thumbnailUrl = thumbnailurl,
                }),
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await httpClient.PatchAsync("photos/1", jsonContent);

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region PutAsync
        public static async ValueTask<string> PutAsync(HttpClient httpClient,int albumid,int Id,string Title,string Url,string ThumbnailUrl)
        {
            using StringContent jsonContent = new
            (
                JsonSerializer.Serialize(new
                {
                    albumId = albumid,
                    id = Id,
                    title = Title,
                    url = Url,
                    thumbnailUrl = ThumbnailUrl
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
        public static async ValueTask<string> PostAsync(HttpClient httpClient, int albumid, int Id, string Title, string Url, string ThumbnailUrl)
        {

            HttpResponseMessage response = await httpClient.PostAsJsonAsync("photos", new Root(albumId: albumid, id: Id, title: Title, url: Url, thumbnailUrl: ThumbnailUrl));

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
        #endregion

        #region GetAsync
        public static async Task GetAsync(HttpClient httpClient)
        {

            using HttpResponseMessage response = await httpClient.GetAsync("photos/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            var jsonResponse = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"{jsonResponse}\n");
        }
        #endregion
    }
}
