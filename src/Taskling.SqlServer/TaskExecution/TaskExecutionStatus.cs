﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taskling.SqlServer.TaskExecution
{
    public enum TaskExecutionStatus
    {
        Unavailable=0,
        Available=1,
        Disabled=2,
        Unlimited=3
    }
}