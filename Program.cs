using System;

public class Curso
{
    public int Codigo;
    public string NomeCurso;
    public Curso(int cod, string nome)
    {
        this.Codigo = cod;
        this.NomeCurso = nome;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        // Criando um array de curso
        Curso[] listaCursos = new Curso[3];

        // Criando os itens do array
        listaCursos[0] = new Curso(1, "Curso 1");
        listaCursos[1] = new Curso(2, "Curso 2");
        listaCursos[2] = new Curso(3, "Curso 3");

        // Navegando pelo array e imprimindo o conteúdo
        foreach (Curso curso in listaCursos)
        {
            Console.WriteLine(curso.NomeCurso);
        }
        Console.Read();
    }
}
