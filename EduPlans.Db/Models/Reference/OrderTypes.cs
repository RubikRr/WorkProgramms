using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    [Table("order_types")]
    public class OrderTypes
    {
        public int Id { get; set; }
        public string type { get; set; }

    }

}
