using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace NoOpenDoorIfLoockByScp079;

public class Plugin : Plugin<Config>
{
    public override string Author => "RomzyyTV";
    public override string Name => "No open door if loock by Scp079";
    public override Version Version => new(1, 0, 0);
    public override Version RequiredExiledVersion => new(9, 0, 0);
    public override PluginPriority Priority => PluginPriority.First;
    
    private static EventHandlers _Handlers;
    public static Plugin Singleton;

    public override void OnEnabled()
    {
        _Handlers = new EventHandlers();
        Singleton = this;
        
        Player.InteractingDoor += _Handlers.OnPlayerInteractingDoor;
        
        base.OnEnabled();
    }

    public override void OnDisabled()
    {
        Player.InteractingDoor -= _Handlers.OnPlayerInteractingDoor;
        
        _Handlers = null;
        Singleton = null;
        base.OnDisabled();
    }
}