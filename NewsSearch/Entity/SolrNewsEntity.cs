using NewsSearch.Dto;
using SolrNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsSearch.Entity
{
    public class SolrNewsEntity
    {
        [SolrUniqueKey("id")]
        public double Id { get; set; }
        [SolrField("title")]
        public string Title { get; set; }
        [SolrField("publication")]
        public string Publication { get; set; }
        [SolrField("author")]
        public string Author { get; set; }
        [SolrField("date")]
        public string Date { get; set; }
        [SolrField("year")]
        public string Year { get; set; }
        [SolrField("month")]
        public string Month { get; set; }
        [SolrField("url")]
        public string Url { get; set; }
        [SolrField("content")]
        public string Content { get; set; }
        public SolrNewsEntity(NewsDto dto)
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
