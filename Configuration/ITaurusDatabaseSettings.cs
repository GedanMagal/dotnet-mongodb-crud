namespace TaurusApi
{
    public interface ITaurusDatabaseSettings
    {
        string PlayersCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}