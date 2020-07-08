using System;
using System.Collections.Generic;
using System.Text;

namespace WebFilmsCollection.Application.ViewModels
{
    public class FilmesViewModel
    {
        public string title1 { get; set; }
        public string title2 { get; set; }
        public string poster { get; set; }
        public string thumbnail { get; set; }
        public metadataViewModel[] metadata { get; set; }
    }
}
