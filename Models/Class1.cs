namespace Models
{
    public class Class1
    {
        public class Sale
        {
            public int Id { get; set; }
            public int StoreId { get; set; }
            public string OrderNumber { get; set; }
            public DateTime OrderDate { get; set; }
            public int Quantity { get; set; }
            public string? PayTerms { get; set; }
            public int TitleId { get; set; }
            public Title Title { get; set; }
            public Store Store { get; set; }
        }
    }
}
}