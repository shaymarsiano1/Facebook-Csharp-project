using FacebookWinFormsApp;
using System;

public class PanelEventArgs : EventArgs
{
    public ePanelType PanelType { get; }

    public PanelEventArgs(ePanelType i_PanelType)
    {
        PanelType = i_PanelType;
    }
}
