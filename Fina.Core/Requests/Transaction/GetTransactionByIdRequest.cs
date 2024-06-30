using System.ComponentModel.DataAnnotations;

class GetTransactionByIdRequest
{
    [Required(ErrorMessage = "Id inválido")]
    public long Id { get; set; }
}