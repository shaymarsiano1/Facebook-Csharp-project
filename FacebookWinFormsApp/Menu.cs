using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
    public class Menu : List<NavigationItem>
    {
        private readonly FlowLayoutPanel r_ContainerPanel;

        public Menu(FlowLayoutPanel i_Panel)
        {
            r_ContainerPanel = i_Panel ?? throw new ArgumentNullException(nameof(i_Panel));
        }

        public void BuildUI()
        {
            r_ContainerPanel.Controls.Clear();
            foreach (NavigationItem item in this)
            {
                Button button = new Button
                {
                    Text = item.Text,
                    Width = 150,
                    Height = 40,
                    Margin = new Padding(5)
                };

                button.Click += (sender, e) => item.Selected();
                r_ContainerPanel.Controls.Add(button);
            }
        }
    }
}
