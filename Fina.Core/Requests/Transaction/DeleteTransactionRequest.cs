using System.ComponentModel.DataAnnotations;

class DeleteTransactionRequest : Request
{
    [Required(ErrorMessage = "Id inválido")]
    public long Id { get; set; }
}