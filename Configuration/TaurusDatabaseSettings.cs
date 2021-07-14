namespace TaurusApi
{
    public class TaurusDatabaseSettings : ITaurusDatabaseSettings
    {
        public string PlayersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}