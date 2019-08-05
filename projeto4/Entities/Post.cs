using System;
using System.Collections.Generic;
using System.Text;

namespace projeto4.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Coment> comments { get; set; } = new List <Coment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComment (Coment coment)
        {
            comments.Add(coment);

        }

        public void RemoveComment(Coment coment)
        {
            comments.Remove(coment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("comments");
            foreach(Coment c in comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
