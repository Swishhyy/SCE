using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE
{
    public class Config : IConfig
    {
        [Description("Whether the plugin is enabled or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether to enable debug logging")]
        public bool Debug { get; set; } = false;
    }
}
