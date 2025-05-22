using System;

public class NavigationItem
{
    public string Text { get; }
    private readonly Action r_Action;

    public NavigationItem(string i_Text, Action i_Action)
    {
        Text = i_Text;
        r_Action = i_Action;
    }

    public void Selected()
    {
        r_Action?.Invoke();
    }
}
