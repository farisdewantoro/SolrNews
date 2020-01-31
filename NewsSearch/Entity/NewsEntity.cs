using NewsSearch.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSearch.Entity
{
    public class NewsEntity
    {
        public double Id { get; set; }

        public string Title { get; set; }

        public string Publication { get; set; }

        public string Author { get; set; }

        public string Date { get; set; }

        public string Year { get; set; }

        public string Month { get; set; }

        public string Url { get; set; }

        public string Content { get; set; }
        public NewsEntity()
        {

        }
        public NewsEntity(NewsDto dto)
        {
            Id = dto.Id;
            Publication = dto.Publication;
            Author = dto.Author;
            Date = dto.Date;
            Year = dto.Year;
            Month = dto.Month;
            Url = dto.Url;
            Content = dto.Content;
        }
    }
}
