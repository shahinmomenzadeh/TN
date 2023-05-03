using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1;

public class Todo
{
 
    public int ID { get; set; }

    [Required]
    public string Name { get; set; } 
    public virtual ICollection<list> Lists { get; set; }
    


}

