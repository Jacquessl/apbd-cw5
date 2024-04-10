// namespace WebApplication1.EndPoints;
//
// public static class AnimalEndPoints
// {
//     public static void MapAnimalEndpoints(this WebApplication app)
//     {
//         app.MapGet("/animals", () =>
//         {
//             return Results.Ok();
//         });
//
//         app.MapGet("/animals/{id}", (int id) =>
//         {
//             return Results.Ok(id);
//         });
//
//         app.MapPost("/animals", () =>
//         {
//             return Results.Created();
//         });
//         app.MapDelete("/animals", () =>
//         {
//             return Results.Ok();
//         });
//     }
//     
// }