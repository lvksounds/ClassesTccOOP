using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Waise.Portal.Models.Academico
{
    public class Curso
    {
        [Required]
        [DisplayName("Nome do Curso")]
        public string NomeCurso { get; set; }
        
        [Key]
        public long IDCurso { get; set; }
        [DisplayName("Instituição")]
        public long? InstituicaoId { get; set; }

        public Instituicao? Instituicao { get; set; }

    }
}
