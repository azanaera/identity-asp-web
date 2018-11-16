using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace test_asp.Models
{
    public class Record
    {
        public int ID { get; set; }
        public string PublicKey { get; set; }
        public string Fingerprint { get; set; }
        public string CivilStatus { get; set; }
        public bool IsAlive { get; set; }

        public DateTime CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Record()
        {
            CreatedBy = DateTime.Now;
            CreatedAt = DateTime.Now;
            UpdatedBy = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }

  
        
}
