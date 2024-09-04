namespace WebApi_02.Models;

public class Estudante
{
    public Guid Id { get; init; }  //guid: tipo de dado para identificar de forma unica o objeto (globaly unique identifier).
    public bool Ativo { get; private set; } 
    public string Nome { get; private set; }

    public Estudante(string nome, bool ativo)
    {
        Nome = nome;
        Ativo = ativo;
        Id = Guid.NewGuid(); // aplicando ao id o metodo de novo GUID
    }

    
}