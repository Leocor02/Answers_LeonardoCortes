using System;
using System.Collections.Generic;
using System.Text;

namespace Answers_LeonardoCortes.Models
{
    public class AskStatus
    {
        public AskStatus()
        {
            Asks = new HashSet<Ask>();
        }

        public int AskStatusId { get; set; }
        public string AskStatus1 { get; set; } = null!;

        public virtual ICollection<Ask> Asks { get; set; }
    }
}
