using DataService.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataService.Service
{
    public class UserService
    {
        RestClient client = new RestClient();

        public List<User> getUsers()
        {
            List<User> users = new List<User>();

            var request = new RestRequest("https://jsonplaceholder.typicode.com/users", Method.Get);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            users = JsonConvert.DeserializeObject<List<User>>(response.Content);

            return users;
        }

        public List<User> getUserById(int id)
        {
            List<User> users = getUsers();
            List<User> result = users.Where(u => u.id == id).ToList();

            return result;
        }

    }
}
