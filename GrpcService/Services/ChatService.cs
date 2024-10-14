using Grpc.Core;
using System.Xml.Linq;

namespace GrpcService.Services
{
    public class ChatService : Chat.ChatBase
    {
        // Список для хранения всех подключенных клиентов
        private static List<IServerStreamWriter<Message>> _clients = new List<IServerStreamWriter<Message>>();

        public override async Task<Empty> SendMessage(Message request, ServerCallContext context)
        {
            // Отправляем сообщение всем подключенным клиентам
            foreach (var client in _clients)
            {
                await client.WriteAsync(request);
            }
            return new Empty(); // Возвращаем пустой ответ
        }

        public override async Task ReceiveMessages(Empty request, IServerStreamWriter<Message> responseStream, ServerCallContext context)
        {
            _clients.Add(responseStream);
            try
            {
                while (true)
                {
                    await Task.Delay(1000); // Позволяет поддерживать соединение
                }
            }
            catch
            {
                // Обработка отключения клиента
            }
            finally
            {
                _clients.Remove(responseStream);
            }
        }
    }

}
