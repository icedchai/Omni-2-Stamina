using System;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using OMNI_FUCK_STAMINA.EventHandlers;
using Player = Exiled.Events.Handlers.Player;

namespace OMNI_FUCK_STAMINA
{
    public class StaminaPlugin : Plugin<Config>
    {

        public static StaminaPlugin pluginInstance;

        public override string Name => "SCP: Fuck Jumping!";

        public override string Author => "icedchqi";

        public override string Prefix => "omni-fuckjumping";

        public override Version Version => new(1, 0, 0);
        PluginEventHandler EventHandler;
        public override void OnEnabled()
        {
            pluginInstance = this;
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
        }
        private void RegisterEvents()
        { 
            EventHandler = new PluginEventHandler();
            Player.Jumping += EventHandler.OnPlayerJump;
        }

        private void UnregisterEvents()
        {
            Player.Jumping -= EventHandler.OnPlayerJump;
            EventHandler = null;

        }
    }
}
