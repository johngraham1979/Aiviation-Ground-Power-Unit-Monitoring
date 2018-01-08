using System;
using System.Collections.Generic;

namespace AXARemote.Model
{
    public class Axa2400 : Axa
    {
        #region AXA2400 Functions

        public List<Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>> Axa2400MiscDictionary =>
            new List<Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>>
            {
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Fan Control", 259, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "EF Interlock Bypassed", 260, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Remote Stop", 263, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "GPU Enable", 264, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "90% Switch", 265, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Door Switch", 266, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Plug Temperature", 267, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Mode", 268, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Units of Measure", 270, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Date and Time Format", 272, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Compensation Time", 515, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Modbus Slave Address", 516, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Interlock Delay", 517, 20.0, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Voltage RMS Setting", 519, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Display Language", 525, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "LED Brightness", 545, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Set Date Year", 552, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Set Date Month", 553, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Set Date Day", 554, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Set Time Hours", 555, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Set Time Minutes", 556, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Set Time Seconds", 557, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Set Date and Time Trigger", 558, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Customer ID, character 0 and 1", 632, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Customer ID, character 2 and 3", 633, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Customer ID, character 4 and 5", 634, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "CTRL Mode (Current state of GPU)", 1027, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output 1 Status", 1029, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output 2 Status", 1030, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Temperature, IGBT 1", 1068, 10.0, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Temperature, IGBT 2", 1069, 10.0, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Unit Error Number", 1070, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Total Time, Upper Word", 1074, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Total Time, Lower Word", 1075, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Total Power, Upper Word", 1076, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Total Power, Lower Word", 1077, 10.0, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Input Status Low", 1082, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Status", 1083, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Input Status High", 1084, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Date Year", 1092, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Date Month", 1093, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Date Day", 1094, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Time Hour", 1095, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Time Minutes", 1096, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Time Seconds", 1097, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Number of Showable Loggings", 2307, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Last Logging", 2308, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Blackbox Record 0, Base Address", 4096, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Blackbox Record 1, Base Address", 4224, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Blackbox Record 2, Base Address", 4352, 1, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Blackbox Record 99, base address", 16768, 1, FunctionCodes[0]
                )
            };

        public List<Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>> Axa2400PowerDictionary =>
            new List<Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>>
            {
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Cable Compensation Output 1", 520, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Cable Compensation Output 2", 521, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "28V Output Voltage", 522, 25.46, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "28V Cable Compensation", 523, 25.46, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "28V Current Limit", 524, 18.24, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Interlock Ripple Level", 547, 34.174, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Neutral Voltage Supervision Level", 526, 814.80, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Earth Leakage Current Level", 543, 40.96, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Earth Leakage Delay", 544, 0.40, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "DC Link Voltage (mean)", 1032, 2.234, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "DC Link Voltage Ripple", 1034, 2.234, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Inverter Current RMS Average", 1039, 3.120, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Voltage RMS Average", 1043, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Voltage RMS Ph-Ph Average", 1047, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Current RMS Average", 1051, 3.120, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Active Power Sum", 1055, 116.12, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Reactive Power Sum", 1059, 116.12, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Apparent Power Sum", 1063, 123.86, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "F1 Voltage", 1064, 34.174, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "F1 Voltage Ripple", 1065, 34.174, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "F2 Voltage", 1066, 34.174, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "F2 Voltage Ripple", 1067, 34.174, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Earth Leakage Current", 1071, 40.96, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Supply Voltage", 1072, 68.23, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Neutral Voltage Supervision", 1073, 814.80, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Power Factor", 1078, 65535, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "28V Output Voltage", 1085, 25.46, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "28V Output Current", 1086, 18.24, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "28V Output Power", 1087, 116.12, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Input Voltage RMS Average", 1090, 10.0, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Input Current RMS Average", 1091, 10.0, FunctionCodes[0]
                )
            };

        public List<Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>> Axa2400PhasePowerDictionary =>
            new List<Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>>
            {
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Inverter Current RMS Phase A", 1036, 3.120, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Inverter Current RMS Phase B", 1037, 3.120, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Inverter Current RMS Phase C", 1038, 3.120, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Voltage RMS Phase A", 1040, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Voltage RMS Phase B", 1041, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Voltage RMS Phase C", 1042, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Voltage RMS Phase A-B", 1044, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Voltage RMS Phase B-C", 1045, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Voltage RMS Phase C-A", 1046, 10.163, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Current RMS Phase A", 1048, 3.120, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Current RMS Phase B", 1049, 3.1203, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Current RMS Phase C", 1050, 3.120, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Active Power Phase A", 1052, 116.12, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Active Power Phase B", 1053, 116.12, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Active Power Phase C", 1054, 116.12, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Reactive Power Phase A", 1056, 116.12, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Reactive Power Phase B", 1057, 116.12, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Reactive Power Phase C", 1058, 116.12, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Apparent Power Phase A", 1060, 123.86, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Apparent Power Phase B", 1061, 123.86, FunctionCodes[0]
                ),
                new Tuple<string, int, double, Tuple<string, Func<int, int, dynamic>>>(
                    "Output Apparent Power Phase C", 1062, 123.86, FunctionCodes[0]
                )
            };

        #endregion
    }
}