using System;

[AttributeUsage(AttributeTargets.Method)]
public class NavigationActionAttribute : Attribute
{
    public string DisplayName { get; }

    public NavigationActionAttribute(string i_DisplayName)
    {
        DisplayName = i_DisplayName;
    }
}
