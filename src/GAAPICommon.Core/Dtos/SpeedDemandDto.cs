﻿using System;
using System.Linq;
using System.Net;

namespace GAAPICommon.Core.Dtos
{
    public class SpeedDemandDto
    {
        public SpeedDemandDto(byte[] bytes)
        {
            if (bytes.Length != 10)
                throw new ArgumentOutOfRangeException("bytes");

            IPAddress = new IPAddress(bytes.Take(4).ToArray());
            Forward = BitConverter.ToInt16(bytes, 4);
            Angular = BitConverter.ToInt16(bytes, 6);
            Lateral = BitConverter.ToInt16(bytes, 8);           
        }

        public SpeedDemandDto(IPAddress ipAddress, short forward, short angular, short lateral)
        {
            if (ipAddress == null)
                throw new ArgumentNullException("ipAddress");

            IPAddress = ipAddress;

            Forward = forward;
            Angular = angular;
            Lateral = lateral;
        }

        public IPAddress IPAddress { get; set; } = null;

        public short Forward { get; set; } = 0;

        public short Angular { get; set; } = 0;

        public short Lateral { get; set; } = 0;
    }
}
