using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Alunos.Model
{
    [Table("materiais")]
    public partial class Material
    {
    #region "Propriedades"
    
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nome", TypeName = "varchar")]
    [Required]
    [MaxLength(150)]
    public string Nome { get; set; }
    
    [Column("aluno_id")]
    [Required]
    public int AlunoId { get; set; }

    #endregion

    }
}
