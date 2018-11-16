using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_asp.Models.Address
{
    public class Barangay
    {
        public int Id { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
    }
}
