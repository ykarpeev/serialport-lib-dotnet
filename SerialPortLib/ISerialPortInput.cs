namespace SerialPortLib
{
    using System.IO.Ports;

    /// <summary>
    /// Serial port interface.
    /// </summary>
    public interface ISerialPortInput
    {
        /// <summary>
        /// Occurs when connection status changes.
        /// </summary>
        event SerialPortInput.ConnectionStatusChangedEventHandler ConnectionStatusChanged;

        /// <summary>
        /// Occurs when message is received.
        /// </summary>
        event SerialPortInput.MessageReceivedEventHandler MessageReceived;

        /// <summary>
        /// Gets a value indicating whether this instance is connected.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is connected; otherwise, <c>false</c>.
        /// </value>
        bool IsConnected { get; }

        /// <summary>
        /// Connects to serial port.
        /// </summary>
        /// <returns>Connection call result.</returns>
        bool Connect();

        /// <summary>
        /// Disconnect from serial port.
        /// </summary>
        void Disconnect();

        /// <summary>
        /// Sets the port.
        /// </summary>
        /// <param name="portname">The port ame.</param>
        /// <param name="baudrate">The baud rate.</param>
        /// <param name="stopbits">The stop bits.</param>
        /// <param name="parity">The parity.</param>
        void SetPort(string portname, int baudrate = 115200, StopBits stopbits = StopBits.One, Parity parity = Parity.None, DataBits dataBits = DataBits.Eight);

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Success state.</returns>
        bool SendMessage(byte[] message);
    }
}
