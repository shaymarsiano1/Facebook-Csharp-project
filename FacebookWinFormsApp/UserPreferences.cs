public class UserPreferences
{
    public bool AutoRefreshFeed { get; set; }
    public int RefreshInterval { get; set; }

    public UserPreferences()
    {
        AutoRefreshFeed = true;
        RefreshInterval = 60; 
    }
}