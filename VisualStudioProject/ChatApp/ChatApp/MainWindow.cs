using System; // Содержит фундаментальные и базовые классы
using System.Drawing; // Предоставляет методы для рисования объектов на устройстве отображения.
using System.Windows.Forms; // Содержит классы для создания приложений Windows
using System.Net; // Предоставляет простой программный интерфейс для многих протоколов, используемых в современных сетях.
using System.Net.Sockets; // Пространство имён для контроля доступа к сети
using System.Collections.Generic; // Содержит интерфейсы и классы, определяющие универсальные коллекции (у нас для списка друзей)
using System.Threading; // Пространство имён для встраивания многопоточности (для использования потоков в программе)
using System.IO; // Содержит типы, позволяющие осуществлять чтение и запись в файлы и потоки данных

namespace ChatApp
{
    public partial class MainWindow : Form
    {
        NetworkStream serverStream; // Поток данных для сервера
        NetworkStream clientStream; // Поток данных для клиента
        TcpClient client;           // Сокет для подключения к серверу

        Color Clr; // Цвет темы
        int panelWidth; // Ширина панели меню
        bool Hidden; // Скрыта панель или нет
        string localIPaddr; // Локальный IP
        int port; // Порт
        string Name; // Имя пользователя программы
        string friendName; // Имя друга подключившегося друга
        public StreamReader STR;
        public StreamWriter STW;
        private bool mouseDown; 
        private Point lastLocation; // Последнее местоположение (координаты для меню)
        List<string> users = new List<string> { }; // Список пользователей
        //Form popup = new POPUPWindow();
        POPUPWindow popupwindow = new POPUPWindow(); // Создаём экземпляр класса окна с настройками


        public MainWindow()
        {
            InitializeComponent(); // Инициализируем гравную форму
            panelWidth = ContentPanel.Width; // получаем ширину панели меню
            Hidden = true; // Устанавливаем её скрытой по умолчанию
            ContentPanel.Width = 0; // Назначаем ширину в 0
            // Прежде чем открыть главную форму, открываем форму с настройками
            popupwindow.ShowDialog(ref port, ref localIPaddr, ref Name, ref Clr);
            // Как только форма POPUPWindow закроется, меняем тему главной формы, цвет Clr мы уже передали по ссылке когда закрывали POPUPWindow
            ChangeTheme(Clr);
            AcceptButton = SendButton; // Назвачаем клавишу ввода на кнопку отправки сообщения
        }

        void StartServer()
        {
            // Метод запускает сервер для прослушивания входящих сообщений в отдельном потоке
            try
            {
                // Локальный адрес на котором разместим сервер
                IPAddress localAddr = IPAddress.Parse(localIPaddr);
                // Создаём ожидание TCP сообщений из сети
                TcpListener tcp = new TcpListener(localAddr, port);
                tcp.Start(); // Запускаем сервер
                MessageBox.AppendText("Server is running: " + localIPaddr + ":" + port + "\n");

                // Буфер для записи полученных данных
                Byte[] bytes = new Byte[256];
                String data = null;

                // Используем лямбда выражение чтобы записать код в серверный поток
                Thread serverListening = new Thread(() =>
                {
                    while (true)
                    {
                        // Входим в бесконечный цикл и ждём пока к нам кто то подключится
                        // Ждём в отдельном потоке, иначе зависнет вся программа на время ожидания
                        var ServClient = tcp.AcceptTcpClient();
                        // Если мы прошли дальше значит кто-то к нам подключился!
                        try
                        {
                            // Код ниже помещается в очередь на поток созданный выше
                            ThreadPool.QueueUserWorkItem((_) =>
                            {
                                // Мы не можем изменять интерфейс программы в этом потоке, по этому будем использовать Invoke
                                data = null;

                                //Получаем сетевой поток подключенного клиента для общения с ним
                                serverStream = ServClient.GetStream();

                                int gettedBytes;
                                // Ниже мы добавляем текст в основной поток формы спомощью Invoke
                                Action action2 = () => MessageBox.AppendText("The client is connected!\n");
                                if (InvokeRequired)
                                    Invoke(action2);
                                else
                                    action2();
                                try
                                {
                                    // Цикл для получения всех данных, отправленных клиентом.
                                    while ((gettedBytes = serverStream.Read(bytes, 0, bytes.Length)) != 0)
                                    {
                                        // Переводим байты в нормальную строку.
                                        data = System.Text.Encoding.UTF8.GetString(bytes, 0, gettedBytes);
                                        // Если нам пришло сообщение с таким тегом имени, это значит что нам представились.
                                        if (data.Contains("{name}"))
                                            friendName = data.Split(':')[1];
                                        else
                                        {
                                            Action action = () => MessageBox.AppendText(friendName + ": " + data + "\n");
                                            // Свойство InvokeRequired указывает, нужно ли нам вызывать это событие именно из другого потока или мы уже в основном
                                            if (InvokeRequired)
                                                Invoke(action);
                                            else
                                                action();
                                        }
                                    }

                                    // Закрываем соединение с клиентом
                                    ServClient.Close();
                                }
                                catch (IOException)
                                {
                                    // Исключение будет вызвано если подключенный к серверу клиент оборвёт соединение
                                    Action action = () => MessageBox.AppendText(friendName + " disconnected!\n");
                                    if (InvokeRequired)
                                        Invoke(action);
                                    else
                                        action();
                                }
                            }, null);
                        }
                        catch (IOException)
                        {
                            // Исключение будет вызвано если подключенный к серверу клиент оборвёт соединение
                            MessageBox.AppendText(friendName + " disconnected!\n");
                        }
                        catch (SocketException e)
                        {
                            // Ошибка в сокете и мы сообщим об этом
                            Action action = () => MessageBox.AppendText("SocketException: " + e + "\n");
                            if (InvokeRequired)
                                Invoke(action);
                            else
                                action();
                        }
                    }
                });
                serverListening.IsBackground = true; // Делаем поток фоновым, чтобы не мешал)
                serverListening.Start(); // Стартуем!
            }
            catch (SocketException)
            {
                // Конечно будет ошибка, если ты попытаешься запустить сервер на уже используемом IP и порту
                MessageBox.AppendText("Server is already running!\n");
            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            // Вызываем окно с настройками при нажатии на кнопку
            popupwindow.ShowDialog(ref port, ref localIPaddr, ref Name, ref Clr);
            // Окно закрывается и мы снова меняем тему
            ChangeTheme(Clr);
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            // При нажатии на окно, запоминаем последнее место где была мышка
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            // При перемещении нажатой мыши изменяем расположение 
            // главной формы на экране со смещением позиции на последнюю где находится мышь
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                // Обновляем окно
                this.Update();
            }
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            // Отпускаем мышку
            mouseDown = false;
        }

        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            // Закрываем окно
            this.Close();
        }

        private void ResizeWindowButton_Click(object sender, EventArgs e)
        {
            // Если состояние окна нормальное (не свёрнутое и не расвёрнутое) растягиваем его на весь экран
            if (WindowState.ToString() == "Normal")
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
                // Иначе просто оставляем нормальным окно
                this.WindowState = FormWindowState.Normal;
        }

        private void HideWindowButton_Click(object sender, EventArgs e)
        {
            // Сворачиваем окно
            this.WindowState = FormWindowState.Minimized;
        }

        private void MessageButton_Click(object sender, EventArgs e)
        {
            // Запускаем таймер при раскрытии меню
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Метод "Тик-так" вызывается каждый раз когда время таймера меняется
            // Если меню скрыто
            if (Hidden)
            {
                // Увеличиваем ширину панели увеличивая её
                ContentPanel.Width = ContentPanel.Width + 10;
                // Если ширина равняется с нужной шириной, останавливаем таймер и говорим что панель больше не скрыта
                if (ContentPanel.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                // Если панель раскрыта, уменьшаем ширину
                ContentPanel.Width = ContentPanel.Width - 10;
                //Останавливаемся если она равна нулю
                if (ContentPanel.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            // Берём данные нового пользователя, сортируем и помещаем в список
            string name = NameBox.Text;
            string address = AddressBox.Text;
            string port = PortBox.Text;
            string user = name + ":" + address + ":" + port;
            users.Add(user);
            UsersList.Items.Add(user);
            NameBox.Text = ""; AddressBox.Text = ""; PortBox.Text = ""; // Очищаем поля
            MessageBox.AppendText("Friend added: " + user.Split(':')[0] + "\n"); // Сообщаем о добавлении
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            // Запускаем сервер по нажатию кнопки
            StartServer();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            // Метод подключения к другому серверу
            try
            {
                // Берём текущего выбранного пользователя для подключения
                string[] clientToConnect = UsersList.Text.Split(':');
                MessageBox.AppendText("Connection to the friend: " + clientToConnect[0] + "\n");
                // Создаём TcpClient.
                Int32 port = Convert.ToInt32(clientToConnect[2]);
                client = new TcpClient(clientToConnect[1], port);
                // Получаем объект для отправки и получения данных от клиента
                clientStream = client.GetStream();
                // Переводим сообщение в байты
                Byte[] mybytes = System.Text.Encoding.UTF8.GetBytes("{name}:" + Name);
                clientStream.Write(mybytes, 0, mybytes.Length); // Отсылаем
                MessageBox.AppendText("The connection was successful.\n");

            }
            catch (FormatException)
            {
                // Да как ты мог?
                MessageBox.AppendText("Connection failed, you entered the data incorrectly.\n");
            }
            catch (IndexOutOfRangeException)
            {
                // Остановись...
                MessageBox.AppendText("Connection failed, you entered the data incorrectly.\n");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.AppendText("ArgumentNullException: " + ex);
            }
            catch (SocketException)
            {
                // Не соединился(
                MessageBox.AppendText("Connection not established.\n");
            }
        }

        public void SendMessage()
        {
            // Метод отправляет сообщения!
            try
            {
                // Если клиент подключён...
                if (client.Connected)
                {
                    // Берём смс из поля для ввода сообщений
                    string mydata = MessageText.Text;

                    // Переводим сообщение в байты для отправки
                    Byte[] mybytes = System.Text.Encoding.UTF8.GetBytes("{name}:" + Name);
                    clientStream.Write(mybytes, 0, mybytes.Length); // Отправляем в поток
                    mybytes = System.Text.Encoding.UTF8.GetBytes(mydata); 
                    clientStream.Write(mybytes, 0, mybytes.Length);
                    MessageText.Text = "";
                    MessageBox.AppendText("You: " + mydata + "\n");
                }
            }
            catch (IOException)
            {
                // Друг походу отключился а ты попытался ему написать
                MessageBox.AppendText("Friend no longer available.\n");
            }
            catch (NullReferenceException)
            {
                // Смысл было отправлять? Ты не подключен
                MessageBox.AppendText("You are not connected to anyone.\n");
            }
        }

        public void SendButton_Click(object sender, EventArgs e)
        {
            // Отправляем сообщение)
            SendMessage();
        }

        public void ChangeTheme(Color color)
        {
            // Метод изменяем мноооооого картинок (не знаю, костыль или нет), а так же некоторые элементы
            ContentPanel.BackColor = color;
            SendButton.ForeColor = color;
            SendButton.FlatAppearance.BorderColor = color;
            MessageBox.ForeColor = color;
            if (color == Color.FromArgb(0, 122, 204))
            {
                // Стандартная тема
                ProfileButton.BackgroundImage = Properties.Resources.ProfileIcon;
                MessageButton.BackgroundImage = Properties.Resources.MessageIcon;
                CloseWindowButton.BackgroundImage = Properties.Resources.CloseIcon2;
                ResizeWindowButton.BackgroundImage = Properties.Resources.FillWindow;
                HideWindowButton.BackgroundImage = Properties.Resources.HideWindow;
            }
            else if (color == Color.Orange)
            {
                // Ммм, фанта
                ProfileButton.BackgroundImage = Properties.Resources.ProfileIconOrange;
                MessageButton.BackgroundImage = Properties.Resources.MessageIconOrange;
                CloseWindowButton.BackgroundImage = Properties.Resources.CloseIconOrange;
                ResizeWindowButton.BackgroundImage = Properties.Resources.FillWindowOrange;
                HideWindowButton.BackgroundImage = Properties.Resources.HideWindowOrange;
            }
            else if (color == Color.Green)
            {
                // Зелёная тема для тех кто един с природой
                ProfileButton.BackgroundImage = Properties.Resources.ProfileIconGreen;
                MessageButton.BackgroundImage = Properties.Resources.MessageIconGreen;
                CloseWindowButton.BackgroundImage = Properties.Resources.CloseIconGreen;
                ResizeWindowButton.BackgroundImage = Properties.Resources.FillWindowGreen;
                HideWindowButton.BackgroundImage = Properties.Resources.HideWindowGreen;
            }
            else if (color == Color.DarkRed)
            {
                // Тёмная сторона силы
                ProfileButton.BackgroundImage = Properties.Resources.ProfileIconRed;
                MessageButton.BackgroundImage = Properties.Resources.MessageIconRed;
                CloseWindowButton.BackgroundImage = Properties.Resources.CloseIconRed;
                ResizeWindowButton.BackgroundImage = Properties.Resources.FillWindowRed;
                HideWindowButton.BackgroundImage = Properties.Resources.HideWindowRed;
            }
            else
            {
                // Хм, индиго
                ProfileButton.BackgroundImage = Properties.Resources.ProfileIconIndigo;
                MessageButton.BackgroundImage = Properties.Resources.MessageIconIndigo;
                CloseWindowButton.BackgroundImage = Properties.Resources.CloseIconIndigo;
                ResizeWindowButton.BackgroundImage = Properties.Resources.FillWindowIndigo;
                HideWindowButton.BackgroundImage = Properties.Resources.HideWindowIndigo;
            }
            Thread.Sleep(1);
        }
        public static bool SetStyle(Control c, ControlStyles Style, bool value)
        {
            bool retval = false;
            Type typeTB = typeof(Control);
            System.Reflection.MethodInfo misSetStyle = typeTB.GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (misSetStyle != null && c != null) { misSetStyle.Invoke(c, new object[] { Style, value }); retval = true; }
            return retval;
        }
    }
}