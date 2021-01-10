using System;

namespace Domain
{
    public class Activity
    {
        // Se usa un Guid para facilitar su creación, tanto desde cliente como servidor.
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        // Lugar, sitio, recinto donde se lleva a cabo la actividad o evento.
        public string Venue { get; set; }
    }
}