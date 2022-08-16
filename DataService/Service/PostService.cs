using DataService.Model;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace DataService.Service
{
    public class PostService
    {
        RestClient client = new RestClient();

        public List<Post> getPosts()
        {
            List<Post> posts = new List<Post>();

            var request = new RestRequest("https://jsonplaceholder.typicode.com/posts", Method.Get);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            posts = JsonConvert.DeserializeObject<List<Post>>(response.Content);


            return posts;
        }


        public List<Post> getById(int id)
        {
            List<Post> posts = getPosts();
            List<Post> result = posts.Where(u => u.id == id).ToList();

            return result;
        }
    }
}
