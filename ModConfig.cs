using Nautilus.Json;
using Nautilus.Options.Attributes;

namespace Alomare.FasterBuild
{
    [Menu("Faster Build")]
    public class ModOptions : ConfigFile
    {
        [Slider("Construct Speed Multiplier", 0.1f, 10.0f, DefaultValue = 2.0f, Format = "{0:F2}")]
        public float ConstructSpeedMultiplier = 2.0f;
    }
}