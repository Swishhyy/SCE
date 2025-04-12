using System;
using Exiled.API.Features;

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
    }
}
