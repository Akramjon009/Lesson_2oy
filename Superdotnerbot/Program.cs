using System;

using Telegram.Bot;
using Telegram.Bot.Types;

class Mybot 
{
    static void Main(string[] args)
    {
        var client = new TelegramBotClient("6482056515:AAHU6-FHmT6yKxcIlS4wZFMaOGKIazE_fps");
        client.StartReceiving(Update,Error);
        Console.ReadLine();
    }

    private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
    {
        var message = update.Message;
        if (message.Text != null)   
        {
            
            await botClient.SendTextMessageAsync(message.Chat.Id, $"salom {message.Chat.Username}");
            return;
           
        }
        if (message.Photo != null) 
        {
             
            await botClient.SendTextMessageAsync(message.Chat.Id, $"👍 cool {message.Chat.Bio}");
            return;
        }
    }
    
}