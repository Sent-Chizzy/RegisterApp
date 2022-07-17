using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RegisterApp.Models
{
    public class Register
    {
       
        public int ID { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }
        [Required]
        public string CellPhone { get; set; }
        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        public Register()
        {

        }
    }

}
