using System;

using Objective.Core.Domain.Common;

namespace Objective.Core.Domain.Objectives
{
    public sealed class ObjectiveStatus : Enumeration
    {
        public static ObjectiveStatus Open = new ObjectiveStatus(1, nameof(Open));
        public static ObjectiveStatus Close = new ObjectiveStatus(2, nameof(Close));

        public ObjectiveStatus(int id, string name) 
            : base(id, name)
        {
        }
    }
}