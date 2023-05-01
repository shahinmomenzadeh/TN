using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1;
[ApiController]
[Route("[controller]")]
public class list
{
        public string ID { get; set; }
        public virtual ICollection<Todo> Todos { get; set; }
    
}
