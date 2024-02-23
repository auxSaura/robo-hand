//hello gays today we have
    
namespace RoboticArm
{
    static class Arduino
    {
        static SerialPort port;
        static bool isConnected = false;

        public static bool IsConnected()
        {
            return isConnected;
        }

        public static string PortName()
        {
            return port.PortName;
        }

        public static bool Conect(string _port)
        {
            port = new SerialPort(_port, 9600, Parity.None, 8, StopBits.One);
            port.ReadTimeout = 10000;
   public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            StatusChange();

        }

        private void StatusChange()
        {
            AutorunCheckBox.Checked = IsAutorun();

            if(Arduino.IsConnected())
            {
                ConnectGroup.Text = "Connected";
                ConnectionButton.Text = "Disconnect";
                
                Ports.Items.Clear();
                Ports.Items.Add(Arduino.PortName());
                Ports.SelectedItem = Arduino.PortName();
                Ports.Enabled = false;
            }
