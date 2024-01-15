using System;
using System.Threading.Tasks.Dataflow;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

class  Dafex
{
    static void Main(string[] args)
    {
        var client = new TelegramBotClient("6974661632:AAFVQEMg2oHNsleEtkcbClwYgU7ErdWrMsc");
        client.StartReceiving(Update, Error);
        Console.ReadLine();
    }

    private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
    {
        var message = update.Message;
        if (message.Text == @"/start")
        {
            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                    InlineKeyboardButton.WithUrl("Go url 1", "https://www.youtube.com/@DAFex.motors/videos"),
                    InlineKeyboardButton.WithUrl("Go url 2", "https://www.instagram.com/dafex.motors.uz")
                });
            await botClient.SendTextMessageAsync(
                chatId: update.Message.Chat.Id,
                text: "DAFex accounts Akramjon",
                replyMarkup: inlineKeyboard
                );
            await botClient.SendTextMessageAsync(message.Chat.Id, "mashina nomini kiriting");


        } 
    }
}