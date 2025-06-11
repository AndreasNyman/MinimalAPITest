using MinimalAPITest;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
StudentCollection.Init();

//app.MapGet("/", () => "Hello World!");

app.MapGet("/students", () =>
{
    return StudentCollection.Students;
});

app.MapGet("student", (int id) =>
{
    var student = StudentCollection.Students.FirstOrDefault(s => s.Id == id);
    if (student != null)
    {
        return Results.Ok(student);
    }
    else
    {
        return Results.NotFound();
    }
});

app.MapPost("/students", (Student student) =>
{
    if (student != null)
    {
        StudentCollection.AddNewStudent(student);
        return Results.Created($"/student/{student.Id}", student);
    }
    else
    {
        return Results.BadRequest("Invalid student data.");
    }
});

app.MapPut("/students", (Student student) =>
{
    try
    {
        StudentCollection.UpdateStudent(student);
        return Results.Ok(student);
    }
    catch (Exception ex)
    {

        return Results.Problem(ex.Message);
    }

});

app.MapDelete("student", (int id) =>
{
    var student = StudentCollection.Students.FirstOrDefault(s => s.Id == id);
    if (student != null)
    {
        StudentCollection.Students.Remove(student);
        return Results.Ok(student);
    }
    else
    {
        return Results.NotFound();
    }
}); ;

app.Run();
