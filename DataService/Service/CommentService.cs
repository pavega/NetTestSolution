using DataService.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace DataService.Service
{
    public class CommentService
    {
        RestClient client = new RestClient();

        public List<Comment> getComments() {
            List<Comment> comments = new List<Comment>();

            var request = new RestRequest("https://jsonplaceholder.typicode.com/comments", Method.Get);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            comments = JsonConvert.DeserializeObject<List<Comment>>(response.Content);


            return comments;
        }

        public List<Comment> getById(int id)
        {
            List<Comment> comments = getComments();
            List<Comment> result = comments.Where(u => u.id == id).ToList();

            return result;
        }
    }
}
