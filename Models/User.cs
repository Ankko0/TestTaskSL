using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softline.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }

        public DateTime Birthday { get; set; }
        public string Description { get; set; }
        public bool MaternityLeave { get; set; }


    }
}
