using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Develop05
{
    public abstract class Goal
    {
        private string _goalDescription;
        private bool _Completed;

        public Goal(string description)
        {
            _goalDescription = description;
            _Completed = false;
        }

        public string GoalDescription
        {
            get {return _goalDescription;}
        }

        public bool Completed
        {
            get{return _Completed;}
            set {_Completed = value;}
        }

        public abstract int RecordEvent();

        public abstract void Display();
    }
}