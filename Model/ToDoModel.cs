using System;

namespace PraktijkOpdracht.Model
{
    class ToDoModel
    {
        public string Module { get; set; }
        public string Thema { get; set; }
        public int TaakId { get; set; }
        public string Taak { get; set; }
        public string Omschrijving { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime InleverDatum { get; set; }
        public string Status { get; set; }
    }
}
