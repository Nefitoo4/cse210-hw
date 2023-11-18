using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Develop05
{
    public abstract class Goal
    {
        protected string _name;
        protected string _description;
        protected int _points;
        protected int _bonuses;
    }
}