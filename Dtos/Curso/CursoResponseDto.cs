namespace MyIFFrontend.Dtos.Curso;

public class CursoResponseDto
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public string Descricao { get; set; }

    public int CargaHoraria { get; set; }

    public DateTime DataAtualizacao { get; set; }

    public decimal Preco { get; set; }
}
