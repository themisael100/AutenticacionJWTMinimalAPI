namespace AutenticacionJWTMinimalAPI.Endpoints
{
    public static class TestEndpoint
    {
        static List<Object> data = new List<object>();

        public static void AddTestEndpints(this WebApplication app)
        {
            app.MapGet("/test", () =>
            {
                return data;
            }).AllowAnonymous();

            app.MapPost("/test", (string name, string lastname) =>
            {
                data.Add(new { name, lastname });
                return Results.Ok();
            }).AllowAnonymous();

            app.MapDelete("/test", () =>
            {
                data = new List<object>();

                return Results.Ok();
            }).RequireAuthorization();
        }
    }
}
