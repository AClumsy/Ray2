﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ray2.EventProcess
{
    public interface IEventProcessorFactory
    {
        IEventProcessor Create(string processName);
    }
}
