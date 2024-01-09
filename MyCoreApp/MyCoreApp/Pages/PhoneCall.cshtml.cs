using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Twilio;


using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML.Messaging;

namespace MyCoreApp.Pages
{
    public class PhoneCallModel : PageModel
    {
        public void OnGet()
        {
            string accountSid = "AC9d36c599937bbb9e1cdaf980bcf4a2c1";
            string authToken = "80fa2bc5fafe049cebc9ddcce9e04c3c";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Pirates for all eternity",
                from: new Twilio.Types.PhoneNumber(""),
                to: new Twilio.Types.PhoneNumber("+13062819843")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
