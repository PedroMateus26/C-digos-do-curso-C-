using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilderExemplo.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public String Content { get; set; }
        public String Title { get; set; }
        public int Likes { get; set; }
        public List<Comments> Comments { get; set; } = new List<Comments>();

        public Post() { }

        public Post(DateTime moment, string content, string title, int likes)
        {
            this.Moment = moment;
            this.Content = content;
            this.Title = title;
            this.Likes = likes;
        }

        public void AddComments(Comments comment)
        {
            this.Comments.Add(comment);
        }

        public void RemoveComments(Comments comment)
        {
            this.Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Title);
            sb.Append(this.Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments");
            foreach (Comments c in Comments) sb.AppendLine(c.Text);
            return sb.ToString();
        }
    }
}
