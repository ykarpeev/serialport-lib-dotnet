/*    This file is part of SerialPortLib source code.

    SerialPortLib is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    SerialPortLib is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with SerialPortLib.  If not, see <http://www.gnu.org/licenses/>.
*/

/*
 *     Author: Generoso Martello <gene@homegenie.it>
 *     Project Homepage: https://github.com/genielabs/serialport-lib-dotnet
 */

namespace SerialPortLib
{
    /// <summary>
    /// Message received event arguments.
    /// </summary>
    public class MessageReceivedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerialPortLib.MessageReceivedEventArgs"/> class.
        /// </summary>
        /// <param name="data">Data.</param>
        public MessageReceivedEventArgs(byte[] data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public byte[] Data { get; }
    }
}
