using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace probeersel.Models
{
    internal class Class2
    {
           {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int? PublisherId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Advance { get; set; }
        public int? Royalty { get; set; }
        public int? YtdSales { get; set; }
        public string? Notes { get; set; }
        public DateTime PubDate { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<TitleAuthor> TitlesAuthors { get; set; }
    }
}
