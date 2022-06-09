namespace MyIFFrontend.Dtos.Curso;

public class CursoCreateUpdateDto
{
    public string Nome { get; set; }

    public string Descricao { get; set; }

    public int CargaHoraria { get; set; }

    public decimal Preco { get; set; }
}
