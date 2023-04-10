using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libmsstyle;

namespace Windows.UI.Theming
{
    public class VisualStyleHandler
    {
        public static VisualStyle DarkStyle = new();
        public static VisualStyle LightStyle = new();

        public static void LoadTheme()
        {
            // Extract visual styles
            var UserTempFiles = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\";
            File.WriteAllBytes(UserTempFiles + "Light.msstyles", Properties.Resources.light);
            File.WriteAllBytes(UserTempFiles + "Dark.msstyles", Properties.Resources.Dark);

            // Load styles
            DarkStyle.Load(Path.Combine(UserTempFiles, "Dark.msstyles"));
            LightStyle.Load(Path.Combine(UserTempFiles, "Light.msstyles"));
        }

        public static StylePart GetCommandLinkPart(VisualStyle v)
        {
            return (from classes in v.Classes.Values where classes.ClassName == "Button" from parts in classes.Parts where parts.Value.PartName == "COMMANDLINK" select parts.Value).FirstOrDefault();
        }
        public static StylePart GetGroupBox(VisualStyle v)
        {
            return (from classes in v.Classes.Values where classes.ClassName == "Button" from parts in classes.Parts where parts.Value.PartName == "GROUPBOX" select parts.Value).FirstOrDefault();
        }
        public static StylePart GetCommandLinkGlyphPart(VisualStyle v)
        {
            return (from classes in v.Classes.Values where classes.ClassName == "Button" from parts in classes.Parts where parts.Value.PartName == "COMMANDLINKGLYPH" select parts.Value).FirstOrDefault();
        }
#nullable enable
        public static StylePart? GetProgressbarBg(VisualStyle v)
        {
            return (from classes in v.Classes.Values where classes.ClassName == "Progress" from parts in classes.Parts where parts.Value.PartName == "BAR" select parts.Value).FirstOrDefault();
        }
        public static StylePart? GetProgressbarFill(VisualStyle v)
        {
            return (from classes in v.Classes.Values where classes.ClassName == "Progress" from parts in classes.Parts where parts.Value.PartName == "FILL" select parts.Value).FirstOrDefault();
        }
#nullable disable
        public static StylePart GetButtonPart(VisualStyle v)
        {
            return (from classes in v.Classes.Values where classes.ClassName == "Button" from parts in classes.Parts where parts.Value.PartName == "PUSHBUTTON" select parts.Value).FirstOrDefault();
        }
        public static StylePart GetEditBorder(VisualStyle v)
        {
            return (from classes in v.Classes.Values where classes.ClassName == "Edit" from parts in classes.Parts where parts.Value.PartName == "EDITBORDER_NOSCROLL" select parts.Value).FirstOrDefault();
        }
        public static StylePart GetEditBackground(VisualStyle v)
        {
            return (from classes in v.Classes.Values where classes.ClassName == "Edit" from parts in classes.Parts where parts.Value.PartName == "EDITBORDER_NOSCROLL" select parts.Value).Last();
        }
    }
}
