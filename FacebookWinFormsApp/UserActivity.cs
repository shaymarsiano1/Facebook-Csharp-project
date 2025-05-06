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

    public int GetPanelVisitCount(ePanelType i_PanelType) => m_VisitedPanels.TryGetValue(i_PanelType, out int count) ? count : 0;

    public void UpdateActivity(ePanelType i_PanelType)
    {
        m_VisitedPanels[i_PanelType]++;
    }
}
