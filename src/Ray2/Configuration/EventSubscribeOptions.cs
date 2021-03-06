﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ray2.Configuration
{
    public class EventSubscribeOptions
    {
        public EventSubscribeOptions(string mqProvider, string topic, string fullName)
        {
            this.MQProvider = mqProvider;
            this.Topic = topic;
            this.EventSubscribeFullName = fullName;
        }
        public string EventSubscribeFullName { get; private set; }
        public string MQProvider { get; private set; }
        public string Topic { get; private set; }
    }
}
