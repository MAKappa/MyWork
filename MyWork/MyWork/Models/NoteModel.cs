using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Models
{
    public class NoteModel
    {
        public int id { get; set; }
        public string Descrizione { get; set; }
        public DateTime NoteEntryDate { get; set; }
        public int NoteId { get; set; }
        public ActivityModel CurrentActivity { get; set; }

    }
}
