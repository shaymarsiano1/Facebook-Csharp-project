using System;

public class UserActivity
{
    public int PhotoViewCount { get; set; } = 0;
    public int FriendsVisitCount { get; set; } = 0;
    public int PostsVisitCount { get; set; } = 0;
    public int FeedVisitCount { get; set; } = 0;

    public DateTime SessionStartTime { get; private set; }

    public UserActivity()
    {
        SessionStartTime = DateTime.Now;
    }

    public TimeSpan GetSessionDuration()
    {
        return DateTime.Now - SessionStartTime;
    }
}
