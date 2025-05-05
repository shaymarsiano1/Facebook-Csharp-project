using FacebookWinFormsApp;
using System;
using System.Collections.Generic;

public class UserActivity
{
    private static readonly UserActivity s_Instance = new UserActivity();
    public static UserActivity Instance
    {
        get { return s_Instance; }
    }
    private Dictionary<ePanelType,int> m_VisitedPanels = new Dictionary<ePanelType,int>();
    public DateTime SessionStartTime { get; private set; }

    private UserActivity() 
    {
        foreach (ePanelType panelType in Enum.GetValues(typeof(ePanelType)))
        {
            m_VisitedPanels[panelType] = 0;
        }
        SessionStartTime = DateTime.Now;
    }

    public TimeSpan GetSessionDuration()
    {
        return DateTime.Now - SessionStartTime;
    }

    public int GetPanelVisitCount(ePanelType panelType)
    {
        if (m_VisitedPanels.ContainsKey(panelType))
        {
            return m_VisitedPanels[panelType];
        }
        return 0;
    }

    public void UpdateActivity(ePanelType panelType)
    {
        m_VisitedPanels[panelType]++;
    }
}
