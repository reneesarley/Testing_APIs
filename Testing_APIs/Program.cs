using System;
using RestSharp;
using RestSharp.Authenticators;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Testing_APIs
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //1
        //    var client = new RestClient("https://api.twilio.com/2010-04-01/Accounts");
      
        //    //2
        //    var request = new RestRequest("Accounts/AC674ab5f2c2d97142070400153c34bcfa/Messages", Method.POST);
        //    //3
        //    request.AddParameter("To", "+15038631605");
        //    request.AddParameter("From", "+19718034174");
        //    request.AddParameter("Body", "Hello world!");
        //    //4
        //    client.Authenticator = new HttpBasicAuthenticator("AC674ab5f2c2d97142070400153c34bcfa", "843f163e0a2dfa22f7348a04cadd7eee");
        //    //5
        //    client.ExecuteAsync(request, response =>
        //    {
        //        Console.WriteLine(response);
        //    });
        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
       
            const string accountSid = "AC674ab5f2c2d97142070400153c34bcfa";
            const string authToken = "843f163e0a2dfa22f7348a04cadd7eee";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+15038631605");
            var message = MessageResource.Create(
                to,
                from: new PhoneNumber("+19718034174"),
                body: "This is the ship that made the Kessel Run in fourteen parsecs?");

            Console.WriteLine(message.Sid);
        }
    }
}
