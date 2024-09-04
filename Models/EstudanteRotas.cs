namespace WebApi_02.Models;

public static class EstudanteRotas
{
    public static void AddEstudanteRotas(this WebApplication app)
    {
        app.MapGet("estudantes", () => new Estudante("Marcos", true));
    }

}