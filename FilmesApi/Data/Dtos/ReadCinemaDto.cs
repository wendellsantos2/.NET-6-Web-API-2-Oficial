 
namespace FilmesApi.Data.Dtos
{
    public class ReadCinemaDto
    {
     
        public int Id { get; set; }
      

        public string Nome { get; set; }

        public ReadCinemaDto ReadEnderecoDto { get; set; }
        public object Endereco { get; internal set; }
    }
}
