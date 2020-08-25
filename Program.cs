using System;
using Newtonsoft.Json;

namespace dsd_json
{
    class Program
    {
        static void Main(string[] args)
        {
            UserModel user = new UserModel("Leonan", 21, 10.002);

            string json = JsonConvert.SerializeObject(user);

            Console.WriteLine(json);

            var usuarioFromJson = JsonConvert.DeserializeObject<UserModel>(json);

            Console.Write(usuarioFromJson.ToString());

            Console.ReadLine();
        }
    }
}
