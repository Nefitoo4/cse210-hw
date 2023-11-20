using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;

namespace Develop05
{
    class EternalGoal : Goal
    {
        public EternalGoal(string goalDescription, int goalValue)
            : base(goalDescription, goalValue)
        {
        }

        public override void RecordEvent()
        {
            base.RecordEvent();
        }
    }
}