using System;

using Objective.Core.Domain.Common;

namespace Objective.Core.Domain.Milestones
{
    public sealed class MilestoneStatus : Enumeration
    {
        public static MilestoneStatus Open = new MilestoneStatus(1, nameof(Open));
        public static MilestoneStatus Close = new MilestoneStatus(2, nameof(Close));

        public MilestoneStatus(int id, string name) 
            : base(id, name)
        {
        }
    }
}