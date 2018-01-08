using System;
using System.Collections.Generic;
using System.Windows;
using Modbus;
using Microsoft.VisualBasic;

namespace AXARemote.Model
{
    public class Axa : ModbusClient
    {
        protected Axa()
        {
            IpAddress = DefaultIpAddress;
            ConnectionTimeout = 5;
            NumberOfRetries = 15;
        }


        public List<Tuple<string, Func<int, int, dynamic>>> FunctionCodes =>
            new List<Tuple<string, Func<int, int, dynamic>>>
            {
                new Tuple<string, Func<int, int, dynamic>>("03 (0x03) Read Holding Registers", ReadHoldingRegisters),
                new Tuple<string, Func<int, int, dynamic>>("04 (0x04) Read Input Registers", ReadInputRegisters),
                new Tuple<string, Func<int, int, dynamic>>("06 (0x06) Write Single Register", WriteSingleRegister),
                new Tuple<string, Func<int, int, dynamic>>("16 (0x10) Write Multiple Registers", SplitAndWriteRegisters)
            };

        #region General Default Values

        protected readonly int DefaultDeviceId = 0;
        private const string DefaultIpAddress = "192.168.1.188";
        protected readonly int DefaultPort = 502;
        protected readonly double DefaultPollRate = 4.0;
        protected readonly double DefaultScalar = 1.0;
        protected readonly int DefaultSelectedRegisterCount = 1;
        protected readonly int DefaultDecimalAddress = 2;

        #endregion
    }
}