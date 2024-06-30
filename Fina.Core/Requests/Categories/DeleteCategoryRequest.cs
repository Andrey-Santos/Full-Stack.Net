using System.ComponentModel.DataAnnotations;

class DeleteCategoryRequest : Request
{
    [Required(ErrorMessage = "Id inválido")]
    public long Id { get; set; }
}