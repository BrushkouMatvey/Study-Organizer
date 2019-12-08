using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace code.Models
{
    public class MasterMenuItem
    {
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Type TargetType { get; set; }
        
        public MasterMenuItem(string Title, string IconSource,  Type target)
        {
            this.Title = Title;
            this.IconSource = IconSource;
            this.TargetType = target;
        }
    }
}
