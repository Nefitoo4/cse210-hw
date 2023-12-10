using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation1
{
    public class Comment
    {
        private readonly string commenterName;
        private readonly string text;

        public Comment(string commenterName, string text)
        {
            this.commenterName = commenterName;
            this.text = text;
        }

        public override string ToString()
        {
            return $"{commenterName}: {text}";
        }
    }
}
