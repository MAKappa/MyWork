using MyWork.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Data
{
    public class Activity
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Descrizione { get; set; }
        public DateTime ActivityDate { get; set; }
        public string Note { get; set; }
        public StateEnum State { get; set; }

        public ICollection<ActivityUser> ActivityUsers { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
