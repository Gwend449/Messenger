using System;
using Newtonsoft.Json;

namespace Messenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);

            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);

            //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2022-05-09T09:55:22.9699725Z"}
            //RusAl < 09.05.2022 9:55:22 >: Privet
        }
    }
}
