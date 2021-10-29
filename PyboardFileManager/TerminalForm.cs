using PyboardFileManager.Properties;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PyboardFileManager
{
    public partial class TerminalForm : Form
    {
        private System.IO.Ports.SerialPort _SerialPort = null;

        private bool _command_has_run = false;
        private bool _dtrEnable = false;
        private int _baudRate = 115200;
        private int _bufferLimit = 16384;
        private int _bufferResetSize = 2048;
        private string _comPort = "COM3";
        private string _command = string.Empty;
        private string _readBuffer = string.Empty;

        public TerminalForm(string ComPort, int BaudRate, string Command, bool DTREnable)
        {
            try
            {
                InitializeComponent();
                _comPort = ComPort;
                _baudRate = BaudRate;
                _command = Command;
                _dtrEnable = DTREnable;

                _SerialPort = serialPort1;
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void TerminalForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Font = new Font(ConfigurationManager.AppSettings["TerminalFont"], Convert.ToSingle(ConfigurationManager.AppSettings["TerminalFontSize"]), FontStyle.Bold);
                txtDisplay.BackColor = Utils.DecodeColor("TerminalBackColor");
                txtDisplay.ForeColor = Utils.DecodeColor("TerminalForeColor");

                txtDisplay.ShortcutsEnabled = false;
                txtDisplay.ReadOnly = true;

                GetWindowValue();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void TerminalForm_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!_SerialPort.IsOpen)
                {
                    _SerialPort.PortName = _comPort;
                    _SerialPort.BaudRate = _baudRate;
                    _SerialPort.DtrEnable = _dtrEnable;
                    _SerialPort.ReadTimeout = 100;
                    _SerialPort.WriteTimeout = 100;
                    _SerialPort.Open();
                    SendCtrlC();
                }
                if (!_command_has_run)
                    timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;

                if (!String.IsNullOrEmpty(_command))
                {
                    if (_SerialPort.IsOpen)
                    {
                        _SerialPort.Write(_command);
                        _SerialPort.Write("\r");
                    }
                }

                _command_has_run = true;
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                _readBuffer = _SerialPort.ReadExisting();
                this.Invoke(new EventHandler(DoUpdate));
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void txtDisplay_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || (e.Control && e.KeyCode == Keys.E) || (e.Control && e.KeyCode == Keys.C) || (e.Control && e.KeyCode == Keys.V) || (e.Shift && e.KeyCode == Keys.Insert))
                {
                    e.IsInputKey = true;
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void txtDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    byte[] b = { 27, 91, 65 };
                    _SerialPort.Write(b, 0, 3);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    byte[] b = { 27, 91, 66 };
                    _SerialPort.Write(b, 0, 3);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Tab)
                {
                    _SerialPort.Write("\t");
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (e.Shift && e.KeyCode == Keys.Insert)
                {
                    string pastedText = Clipboard.GetText();
                    if (pastedText != "")
                    {
                        _SerialPort.Write(pastedText);
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (e.Control && e.KeyCode == Keys.V)
                {
                    string pastedText = Clipboard.GetText();
                    if (pastedText != "")
                    {
                        _SerialPort.Write(pastedText);
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (e.Control && e.KeyCode == Keys.E)
                {
                    SendCtrlE();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (e.Control && e.KeyCode == Keys.C)
                {
                    SendCtrlC();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    //Debug.WriteLine("KEY NOT Handled");
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void SendCtrlC()
        {
            try
            {
                if (_SerialPort.IsOpen)
                {
                    char[] key = new char[1];
                    key[0] = (char)3;
                    _SerialPort.Write(key, 0, 1);
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void SendCtrlE()
        {
            try
            {
                if (_SerialPort.IsOpen)
                {
                    char[] key = new char[1];
                    key[0] = (char)5;
                    _SerialPort.Write(key, 0, 1);
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }


        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char[] key = new char[1];
                key[0] = e.KeyChar;
                _SerialPort.Write(key, 0, 1);
                e.Handled = true;
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void TerminalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SendCtrlC();
                _SerialPort.Close();
                SaveWindowValue();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        public void DoUpdate(object sender, System.EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(_readBuffer))
                {
                    // process a single backspace
                    if (_readBuffer == "\b\u001b[K" || _readBuffer == "\b")
                    {
                        removeChar();
                    }
                    else if (_readBuffer[0] == 27 && _readBuffer[1] == 91)  // else if it begins with an escape sequence...
                    {
                        string cmd = _readBuffer.Substring(2);
                        int pos = cmd.IndexOf('D');
                        if (pos > 0)
                        {
                            string countstr = cmd.Substring(0, pos);
                            int count = Convert.ToInt16(countstr);
                            if (count > 0)
                            {
                                removeChar(count);
                            }
                            string remainder = cmd.Substring(pos + 1);
                            if (remainder != "")
                            {
                                if (remainder == "\b\u001b[K" || remainder == "\b")
                                {
                                    removeChar();
                                }
                                else
                                {
                                    if (remainder[0] == 27 && remainder[1] == 91 && remainder[2] == 75)
                                    {
                                        addText(remainder.Substring(3));
                                    }
                                    else
                                    {
                                        addText(remainder);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (cmd.StartsWith("K"))
                            {
                                string remainder = cmd.Substring(1);
                                addText(remainder);
                            }
                            else
                                Log("  cmd:" + cmd);
                        }
                    }
                    else // else it is just some text from the device
                    {
                        addText(_readBuffer);
                    }

                    // truncate the terminal buffer
                    if (txtDisplay.TextLength > _bufferLimit)
                    {
                        txtDisplay.Text = txtDisplay.Text.Substring(txtDisplay.TextLength - _bufferResetSize);
                    }

                }

            }
            catch (Exception ex)
            {
                Log("  Error:" + ex.Message);
            }
        
        }

        private void addText(string buffer)
        {
            try
            {
                txtDisplay.AppendText(buffer);
                txtDisplay.SelectionStart = txtDisplay.TextLength;
                txtDisplay.SelectionLength = 0;
                txtDisplay.ScrollToCaret();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void removeChar(int count = 1)
        {
            try
            {
                txtDisplay.SelectionStart = txtDisplay.TextLength - count;
                txtDisplay.SelectionLength = count;
                txtDisplay.SelectedText = "";
                txtDisplay.ScrollToCaret();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void Log(string msg)
        {
            Debug.WriteLine(msg);
            //txtDisplay.AppendText(msg);
            //txtDisplay.SelectionStart = txtDisplay.TextLength;
            //txtDisplay.SelectionLength = 0;
            //txtDisplay.ScrollToCaret();
        }

        private void GetWindowValue()
        {
            Width = Settings.Default.REPLWidth;
            Height = Settings.Default.REPLHeight;
            Top = Settings.Default.REPLTop < 0 ? 0 : Settings.Default.REPLTop;
            Left = Settings.Default.REPLLeft < 0 ? 0 : Settings.Default.REPLLeft;
        }

        private void SaveWindowValue()
        {
            Settings.Default.REPLHeight = Height;
            Settings.Default.REPLWidth = Width;
            Settings.Default.REPLLeft = Left;
            Settings.Default.REPLTop = Top;
            Settings.Default.Save();
        }
    }
}
