using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace test_asp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage = "Password must be at least 6 characters long")]
        public string Password { get; set; }
        public char Access { get; set; }

        public DateTime CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Status { get; set; }

        public User()
        {
            CreatedAt = DateTime.Now;
            CreatedBy = DateTime.Now;
            UpdatedAt = DateTime.Now;
            UpdatedBy = DateTime.Now;
        }

    }
}
