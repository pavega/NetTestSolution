using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Model
{
    public class Comment
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        public Comment(int postId, int id, string name, string email, string body)
        {
            this.postId = postId;
            this.id = id;
            this.name = name;
            this.email = email;
            this.body = body;
        }

        public Comment() { }

    }
}
