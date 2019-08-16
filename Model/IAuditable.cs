﻿using System;

namespace SmartInventorySystem.Model
{
    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime ModifiedAt { get; set; }
        string ModifiedBy { get; set; }
    }
}