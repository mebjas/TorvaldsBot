using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Luis.Models;
using TorvaldsBot.Models;

namespace TorvaldsBot.Dialogs
{
    [Serializable]
    public class CoreLuisDialog : LuisDialog<object>
    {
        [LuisIntent("")]
        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Could not get your intent.");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Greetings")]
        public async Task GreetingsIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(Greetings.getGreetingResponse());
            context.Wait(MessageReceived);
        }
    }
}
