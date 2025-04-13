using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE
{
    public class Plugin : Plugin<Config>
    {
        // Override the plugin's name property.
        public override string Name => "SCE";
        // Override the plugin's author property.
        public override string Author => "Swishhyy";
        // Override the plugin's version property.
        public override Version Version => new(1, 0, 0);

        public override void OnEnabled()
        {
            Log.Info($"{Name} by {Author} has been enabled!");
        }
        public override void OnDisabled()
        {
            Log.Info($"{Name} by {Author} has been disabled!");
        }
    }
}
