using NewsSearch.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSearch.Dto
{
    public class NewsDto 
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
        public NewsDto(NewsEntity entity)
        {
            Id = entity.Id;
            Title = entity.Title;
            Publication = entity.Publication;
            Author = entity.Author;
            Date = entity.Date;
            Year = entity.Year;
            Month = entity.Month;
            Url = entity.Url;
            Content = entity.Content;
        }
        public NewsDto()
        {

        }
      
    }
}
