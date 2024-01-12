namespace HttpCrud
{
    internal static class Todosjson
    {
        
            internal static void WriteRequestToConsole(this HttpResponseMessage response)
            {
                if (response is null)
                {
                    return;
                }

                var request = response.RequestMessage;
                Console.Write($"{request?.Method} ");
                Console.Write($"{request?.RequestUri} ");
                Console.WriteLine($"HTTP/{request?.Version}");
            }
        
    }

    public record class Todo
    (
        int? UserId = null,
        int? Id = null,
        string? Title = null,
        bool? Completed = null
    );
}
