﻿using Abp.Domain.Entities.Auditing;

namespace Abp.Configuration
{
    ///// <summary>
    ///// This class is used to store setting values on the database.
    ///// </summary>
    //public class Setting : AuditedEntity<long>, ISettingValue //TODO: Move to ABP.Core module and put an interface here to be used by SettingManager.
    //{
    //    /// <summary>
    //    /// TenantId for this setting.
    //    /// TenantId is null if this setting is not Tenant level.
    //    /// </summary>
    //    public virtual int? TenantId { get; set; }

    //    /// <summary>
    //    /// UserId for this setting.
    //    /// UserId is null if this setting is not user level.
    //    /// </summary>
    //    public virtual long? UserId { get; set; }
        
    //    /// <summary>
    //    /// Unique name of the setting.
    //    /// </summary>
    //    public virtual string Name { get; set; }

    //    /// <summary>
    //    /// Value of the setting.
    //    /// </summary>
    //    public virtual string Value { get; set; }
    //}
}