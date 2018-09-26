using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(Tweede.UWP.Services.MessageServicesUWP))]
namespace Tweede.UWP.Services
{
    public class MessageServicesUWP : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "we zitten in UWP";
        }
    }
}
