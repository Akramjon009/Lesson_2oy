namespace HttpCrud.Posts_Crude
{
    public record class Post
    (
        int? UserId = null,
        int? Id = null,
        string? Title = null,
        bool? body = null
    );
}
