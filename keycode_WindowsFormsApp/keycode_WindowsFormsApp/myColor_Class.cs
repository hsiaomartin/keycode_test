using System;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;

namespace myColor_class
{
    public class myColor
    {
        public List<SolidBrush> brush;
        public List<Color> color;
        public myColor()
        {
            brush = GetBrushes();
            color = GetColor();
        }

        List<SolidBrush> GetBrushes()
        {
            Type type = typeof(Brushes);
            List<SolidBrush> brushs = new List<SolidBrush>();
            BindingFlags flags = (BindingFlags.Public | BindingFlags.Static);
            foreach (MemberInfo info in type.GetMembers(flags))
            {
                if (info.MemberType == MemberTypes.Property)
                {
                    string name = info.Name;
                    //靜態屬性
                    object obj = type.GetProperty(name).GetValue(null, null);
                    brushs.Add((SolidBrush)obj);
                }
            }
            return brushs;
        }

        List<Color> GetColor()
        {
            Type type = typeof(Color);
            List<Color> colors = new List<Color>();
            BindingFlags flags = (BindingFlags.Public | BindingFlags.Static);
            foreach (MemberInfo info in type.GetMembers(flags))
            {
                if (info.MemberType == MemberTypes.Property)
                {
                    string name = info.Name;
                    //靜態屬性
                    object obj = type.GetProperty(name).GetValue(null, null);
                    colors.Add((Color)obj);
                }
            }
            return colors;
        }
    }
}
