namespace AutenticacionJWTMinimalAPI.Endpoints
{
    public static class ProtectedEndpoint
    {
        static List<Object> data = new List<object>();

        public static void AddProtectedEndpoints(this WebApplication app)
        {
            app.MapGet("/protected", () =>
            {
                return data;
            }).RequireAuthorization();

            app.MapPost("/protected", (string name, string lastname) =>
            {
                data.Add(new { name, lastname });

                return Results.Ok();
            }).RequireAuthorization();
        }
    }
}
