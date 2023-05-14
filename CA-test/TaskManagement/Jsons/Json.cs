using System.Text.Json;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Jsons
{
    public  class Json
    {
        public static async Task SerializePersonToFile()
        {
            var fileName = "Users.json";
            var myList = DataContext.Users;

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using var stream = new FileStream(fileName, FileMode.Append);
            await JsonSerializer.SerializeAsync(stream, myList, options);
            await stream.DisposeAsync();
        }
        public static async Task SerializeMessageToFile()
        {
            var fileName = "Message.json";
            var myList = DataContext.Messages;

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using var stream = new FileStream(fileName, FileMode.Append);
            await JsonSerializer.SerializeAsync(stream, myList, options);
            await stream.DisposeAsync();
        }
        public static async Task SerializeBlogToFile()
        {
            var fileName = "Blog.json";
            var myList = DataContext.Blogs;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using var stream = new FileStream(fileName, FileMode.Append);
            await JsonSerializer.SerializeAsync(stream, myList, options);
            await stream.DisposeAsync();
        }

        public static async Task<List<User>> DeserializePersonFromFile()
        {
            //var fileName = "Users.json";

            //using var stream = new FileStream(fileName, FileMode.Open);
            //var people = await JsonSerializer.DeserializeAsync<List<User>>(stream);

            //return people;
            var fileName = "Users.json";
            var people = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(fileName);
            //using var stream = new FileStream(fileName, FileMode.Open);
            //var options = new JsonSerializerOptions
            //{
            //    PropertyNameCaseInsensitive = true
            //};
            //var people = await JsonSerializer.DeserializeAsync<List<User>>(stream, options);

            return people;
        }
        public static async Task<List<Message>> DeserializeMessageFromFile()
        {
            var fileName = "Message.json";

            using var stream = new FileStream(fileName, FileMode.Open);
            var messages = await JsonSerializer.DeserializeAsync<List<Message>>(stream);

            return messages;
        }
        public static async Task<List<Blog>> DeserializeBlogFromFile()
        {
            var fileName = "Blog.json";

            using var stream = new FileStream(fileName, FileMode.OpenOrCreate);
            var blogs = await JsonSerializer.DeserializeAsync<List<Blog>>(stream);

            return blogs;
        }

    }
}
