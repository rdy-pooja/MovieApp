using System;
using System.Collections.Generic;

#nullable disable

namespace MovieApp.Models
{
    public partial class Producer
    {
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
