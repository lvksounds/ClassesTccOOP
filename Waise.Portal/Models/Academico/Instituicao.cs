using System.ComponentModel.DataAnnotations;

namespace Waise.Portal.Models.Academico
{
    public class Instituicao
    {
        public string Nome { get; set; }
        [Key]
        public long ID { get; set; }

        public virtual ICollection<Curso>? Cursos { get; set; }
    }
}
