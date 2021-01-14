using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using MetroFramework;

namespace WindowsUI.Utilities
{
    public static class AppHelper
    {
        public static Color GetStateColor(TaskStateNames baseNames)
        {
            switch (baseNames)
            {
                case TaskStateNames.ToDo:
                    return MetroColors.Red;
                case TaskStateNames.Doing:
                    return MetroColors.Yellow;
                case TaskStateNames.Done:
                    return MetroColors.Green;
                default:
                    return Color.DarkGray;
            }
        }
        public static Color GetStateColor(string desc)
        {
            Color color = Color.DarkGray;
            if (desc == null)
            {
                return MetroColors.Orange;
            }

            desc = desc.ToLower();
            if (desc.Contains("to do") || desc.Contains("todo"))
            {
                color = MetroColors.Red;
            }
            else if (desc.Contains("doing"))
            {
                color = MetroColors.Yellow;

            }
            else if (desc.Contains("done"))
            {
                color = MetroColors.Green;
            }
            else if (desc.Contains("created"))
            {
                color = MetroColors.Orange;
            }

            return color;
        }

        public static T GetCurrentForm<T>() where T : Form
        {
            var name = typeof(T).Name;

            return (T)Application.OpenForms[name];
        }
        public static void FocusMainForm()
        {
            var res = AppHelper.GetCurrentForm<MainForm>();
            if (res != null)
            {
                res.Show();
                res.Focus();
                res.Focus();
                res.Focus();
            }
        }
    }

}
