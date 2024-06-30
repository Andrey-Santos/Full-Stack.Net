using System.ComponentModel.DataAnnotations;

class GetCategoryByIdRequest : Request
{
    [Required(ErrorMessage = "Id inválido")]
    public long Id { get; set; }
}