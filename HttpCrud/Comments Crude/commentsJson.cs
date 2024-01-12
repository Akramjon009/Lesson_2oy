namespace HttpCrud.Comments_Crude
{
    internal static class commentsjson
    {
        public record class Todo
        (
        int? UserId = null,
        int? Id = null,
        string? Title = null,
        bool? Completed = null
        );
    }
}
