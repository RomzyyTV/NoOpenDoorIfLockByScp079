using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace NoOpenDoorIfLockByScp079;

public class Config : IConfig
{
    [Description("If the plugin must be in debug mode (Not recommended)")]
    public bool Debug { get; set; }

    [Description("Whether the plugin should be activated or not")]
    public bool IsEnabled { get; set; } = true;

    public List<RoleTypeId> NotAllowedRole { get; set; } = new List<RoleTypeId>
    {
        RoleTypeId.Scp049,
        RoleTypeId.Scp096,
        RoleTypeId.Scp106,
        RoleTypeId.Scp173,
        RoleTypeId.Scp939,
        RoleTypeId.Scp3114,
    };
}