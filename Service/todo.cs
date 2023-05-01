using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1;
[ApiController]
[Route("[controller]")]
public class Todo
{
    [Key]
    public int ID { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(250)")]
    public string name { get; set; } = " ";

    public string list { get; set; } = " ";


}