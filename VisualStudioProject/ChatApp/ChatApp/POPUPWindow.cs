using System; // Содержит фундаментальные и базовые классы
using System.Drawing; // Предоставляет методы для рисования объектов на устройстве отображения.
using System.Windows.Forms; // Содержит классы для создания приложений Windows
using System.Net; // Предоставляет простой программный интерфейс для многих протоколов, используемых в современных сетях.
using System.Net.Sockets; // Пространство имён для контроля доступа к сети
using System.Text.RegularExpressions; // Содержит классы, обеспечивающие доступ к обработчику регулярных выражений

namespace ChatApp
{
    public partial class POPUPWindow : Form
    {
        Color themeColor; // Цвет темы
        string localIP; // Локальный IP адрес, определяется автоматически или вводится вручную
        int actualPort; // Порт используемый для подключения
        string userName; // Никнейм пользователя в программе
        // Регулярное выражения для проверки неверно введённого пользователем IP адреса.
        string pattern = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";

        // Инициализирует форму с настройкой имени, порта, IP адреса и темы.
        public POPUPWindow()
        {
            InitializeComponent();
            // При запуске определяем тему приложения, по умолчанию она синяя.
            ThemeColor();
            BoxIP.ValidatingType = typeof(IPAddress); // Задаём полю BoxIP тип IPAddress
            // Ниже определяем IP адрес ПК
            // Создаём сокет с UDP протоколом.
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0)) 
            {
                // Подключаемся к бесплатному DNS серверу Google
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                // Получаем локальный IP из локальной конечной точки
                localIP = endPoint.Address.ToString();
            }
            BoxIP.Text = localIP; // Записываем определённый адрес в форму
            actualPort = Convert.ToInt32(PortBox.Value); // Берём порт из формы переводя его в число
            userName = NameField.Text; // Берём имя из формы
        }

        public void ShowDialog(ref int port, ref string localIPaddr, ref string Name, ref Color Clr)
        {
            /* Метод показывающий форму POPUPWindow, так же метод принимает 
             * все значения определённые в форме и передаёт ссылку на них второй форме MainWindow*/
            this.ShowDialog();
            // Ниже берём значения переменных из формы POPUPWindow
            port = actualPort;
            localIPaddr = localIP;
            Name = userName;
            Clr = themeColor;
        }


        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            // Метод вызывается при нажатии на кнопку закрытия и закрывает POPUPWindow
            userName = NameField.Text;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Метод вызывается при отрисовке элементов и меняет цвет рамки формы POPUPWindow
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.FromArgb(64, 64, 64), ButtonBorderStyle.Solid);
        }

        private void PortBox_ValueChanged(object sender, EventArgs e)
        {
            // Метод вызывается при изменении значения в поле для порта и перезаписывает значение в переменную
            actualPort = Convert.ToInt32(PortBox.Value);
        }

        private void BoxIP_ValueChanged(object sender, EventArgs e)
        {
            // Метод так же перезаписывает значение IP аналогично с полем для порта
            if (Regex.IsMatch(BoxIP.Text, pattern) || BoxIP.Text == "localhost")
                localIP = BoxIP.Text;
        }

        private void BoxIP_TextControl(object sender, EventArgs e)
        {
            /* Метод проверяет введённый IP и исправляет его
            на верный по умолчанию, если он введён не правильно, когда мы покидаем строку ввода*/
            if (!Regex.IsMatch(BoxIP.Text, pattern) && BoxIP.Text != "localhost")
                Console.WriteLine("FUCK!");
                BoxIP.Text = localIP;
        }

        private void NameField_VisibleChanged(object sender, EventArgs e)
        {
            // Перезаписываем имя как только в поле меняется значение
            userName = NameField.Text;
        }

        public void ChangeTheme(Color color)
        {
            // Метод изменяет цвета элементов формы POPUPWindow в соответствии с полученным цветом
            // Ниже меняем цвет текста
            LogoLabel.ForeColor = color;
            NameLabel.ForeColor = color;
            PortLabel.ForeColor = color;
            IPLabel.ForeColor = color;
            ThemeLabel.ForeColor = color;
            // Далее меняем изображение кнопки закрытия окна, все изображения берём из файла ресурсов.
            if (color == Color.FromArgb(0, 122, 204))
                CloseWindowButton.BackgroundImage = Properties.Resources.CloseIcon2;
            else if (color == Color.DarkRed)
                CloseWindowButton.BackgroundImage = Properties.Resources.CloseIconRed;
            else if (color == Color.Orange)
                CloseWindowButton.BackgroundImage = Properties.Resources.CloseIconOrange;
            else if (color == Color.Green)
                CloseWindowButton.BackgroundImage = Properties.Resources.CloseIconGreen;
            else
                CloseWindowButton.BackgroundImage = Properties.Resources.CloseIconIndigo;
        }

        private void ThemeField_SelectedItemChanged(object sender, EventArgs e)
        {
            // Метод вызывается когда мы меняем цвет темы в форме и меняет тему) логично!
            ThemeColor();
        }

        private void ThemeColor()
        // Метод определяет какой цвет темы выбран в форме
        {
            // Смотрим какой цвет выбран в форме и изменяем переменную themeColor
            if (ThemeField.Text == "Blue")
                themeColor = Color.FromArgb(0, 122, 204);
            else if (ThemeField.Text == "Red")
                themeColor = Color.DarkRed;
            else if (ThemeField.Text == "Orange")
                themeColor = Color.Orange;
            else if (ThemeField.Text == "Green")
                themeColor = Color.Green;
            else
                themeColor = Color.Indigo;
            ChangeTheme(themeColor);
        }
    }
}
