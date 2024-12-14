using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;

namespace NoOpenDoorIfLoockByScp079;
public class EventHandlers
{
    public void OnPlayerInteractingDoor(InteractingDoorEventArgs ev)
    {
        if (ev.Door.DoorLockType is DoorLockType.Lockdown079 or DoorLockType.Regular079)
        {
            if (Plugin.Singleton.Config.NotAllowedRole.Contains(ev.Player.Role))
            {
                ev.IsAllowed = false;
            }
        }
    }
}