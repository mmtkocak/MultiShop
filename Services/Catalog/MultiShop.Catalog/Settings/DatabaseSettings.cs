namespace MultiShop.Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CategoryColletionName { get; set; }
        public string ProductColletionName { get; set; }
        public string ProductDetailColletionName { get; set; }
        public string ProductImageColletionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
