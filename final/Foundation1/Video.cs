using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Foundation1
{
    public class Video
    {
        private readonly string title;
        private readonly string author;
        private readonly int lengthInSeconds;
        private readonly List<Comment> comments;

        public Video(string title, string author, int lengthInSeconds)
        {
            this.title = title;
            this.author = author;
            this.lengthInSeconds = lengthInSeconds;
            this.comments = new List<Comment>();
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public override string ToString()
        {
            return $"{title} by {author} ({lengthInSeconds} seconds)";
        }

        public IEnumerable<Comment> GetComments()
        {
            return comments;
        }
    }
}
