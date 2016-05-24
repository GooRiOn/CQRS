﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Infrastructure
{
    public interface IEventStore
    {
        IEventSource<TEventBase> GetSource<TEventBase>();
    }
}