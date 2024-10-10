using System.ComponentModel;
using Exiled.API.Interfaces;


namespace OMNI_FUCK_STAMINA
{
    public class Config : IConfig
    {
        [Description("Indicates plugin enabled or not")]
        public bool IsEnabled { get; set; } = true;

        [Description("Indicates debug mode enabled or not")]
        public bool Debug { get; set; } = false;
        [Description("Percent of stamina to consume when jumping")]
        public float StaminaUseOnJump { get; set; } = 30;

    }
}
