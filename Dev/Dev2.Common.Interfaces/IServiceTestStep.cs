﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Dev2.Common.Interfaces
{
    public interface IServiceTestStep
    {
        Guid UniqueId { get; set; }
        string ActivityType { get; set; }
        StepType Type { get; set; }
        List<IServiceTestOutput> StepOutputs { get; set; }
        IServiceTestStep Parent { get; set; }
        ObservableCollection<IServiceTestStep> Children { get; set; }
    }
}