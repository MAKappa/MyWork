using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Data
{
    public class Note
    {
        public int id { get; set; }
        public string Descrizione { get; set; }
        public DateTime NoteEntryDate { get; set; }
        public int NoteId { get; set; }
        public Note CurrentNote { get; set; }
    }
}
