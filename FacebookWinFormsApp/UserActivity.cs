using System;

public class UserActivity
{
    private static readonly UserActivity s_Instance = new UserActivity();
    public static UserActivity Instance
    {
        get { return s_Instance; }
    }
    public int PhotoViewCount { get; set; } = 0;
    public int FriendsVisitCount { get; set; } = 0;
    public int PostsVisitCount { get; set; } = 0;
    public int FeedVisitCount { get; set; } = 0;

    public DateTime SessionStartTime { get; private set; }

    private UserActivity() 
    {
        SessionStartTime = DateTime.Now;
    }

    public TimeSpan GetSessionDuration()
    {
        return DateTime.Now - SessionStartTime;
    }
}
