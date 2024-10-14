using System.Windows;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using GrpcService;
using GrpcService.Services;

namespace Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GrpcService.Chat.ChatClient _client; // Объявляем поле класса
        private string _username;

        public MainWindow()
        {
            InitializeComponent();
            InitializeClient();
            StartReceivingMessages();
        }

        private void InitializeClient()
        {
            var channel = GrpcChannel.ForAddress("http://localhost:5203"); // Убедитесь, что адрес совпадает с вашим сервером
            _client = new GrpcService.Chat.ChatClient(channel); // Инициализируем поле класса
        }

        private async void StartReceivingMessages()
        {
            var call = _client.ReceiveMessages(new GrpcService.Empty());
            try
            {
                while (await call.ResponseStream.MoveNext(CancellationToken.None))
                {
                    var message = call.ResponseStream.Current;
                    ChatHistory.AppendText($"{message.Username}: {message.Text}\n");
                }
            }
            catch (Exception ex)
            {
                ChatHistory.AppendText($"Error receiving messages: {ex.Message}\n");
            }
        }

        private async void SendButton_Click(object sender, RoutedEventArgs e) // Изменён на async
        {
            var message = new Message
            {
                Username = UsernameInput.Text,
                Text = MessageInput.Text
            };

            // Отправка сообщения через gRPC
            await _client.SendMessageAsync(message); // Теперь это работает
            MessageInput.Clear();
        }
    }
}