using Grpc.Core;
using Grpc.Net.Client;
using GrpcService; // Убедитесь, что это ваше пространство имен

class Program
{
    static async Task Main(string[] args)
    {
        /*using var channel = GrpcChannel.ForAddress("http://localhost:5203");
        var client = new Chat.ChatClient(channel);

        Console.Write("Введите ваше имя: ");
        var username = Console.ReadLine();

        using var call = client.JoinChat();

        // Запускаем слушатель сообщений
        var listenerTask = Task.Run(async () =>
        {
            while (await call.ResponseStream.MoveNext())
            {
                var message = call.ResponseStream.Current;
                Console.WriteLine($"[{message.Username}]: {message.Content}");
            }
        });

        // Отправка сообщений
        while (true)
        {
            Console.Write("Введите сообщение (или 'exit' для выхода): ");
            var messageContent = Console.ReadLine();

            if (messageContent == "exit")
                break;

            var message = new Message
            {
                Username = username,
                Text = messageContent
            };

            await call.RequestStream.WriteAsync(message);
        }

        await call.RequestStream.CompleteAsync();
        await listenerTask; // Ждем завершения слушателя*/
    }
}