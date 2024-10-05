
using CustomPlayerEffects;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System.Collections;

namespace OMNI_FUCK_STAMINA.EventHandlers
{
    public class PluginEventHandler
    {
        public void OnPlayerJump(JumpingEventArgs e)
        {
            if (e.Player.IsHuman & e.Player.IsUsingStamina)
            { 
                if (e.Player.IsEffectActive<Invigorated>()||e.Player.IsEffectActive<Scp207>())
                {
                    ;
                }
                else
                {
                    e.Player.Stamina -= (StaminaPlugin.pluginInstance.Config.StaminaUseOnJump * 0.01f);
                }
            }
        }

    }
}
