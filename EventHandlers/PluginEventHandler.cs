
using CustomPlayerEffects;
using Exiled.Events.EventArgs.Player;

namespace OMNI_FUCK_STAMINA.EventHandlers
{
    public class PluginEventHandler
    {
        public void OnPlayerJump(JumpingEventArgs e)
        {
            if(!e.Player.IsEffectActive<Invigorated>()|| !e.Player.IsEffectActive<Scp207>())
                e.Player.Stamina -= (StaminaPlugin.pluginInstance.Config.StaminaUseOnJump/100);
        }

    }
}
