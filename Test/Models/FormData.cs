using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class FormData
    {
        [Key]
        string userName { get; set; }
        string userEmail { get; set; }
        string userText { get; set; }
    }
}
