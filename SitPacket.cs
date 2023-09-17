﻿// WingsEmu
// 
// Developed by NosWings Team

using System.Collections.Generic;

namespace WingsEmu.Packets.ClientPackets
{
    [PacketHeader("rest")]
    public class SitPacket : ClientPacket
    {
        #region Properties

        [PacketIndex(0)]
        public byte Amount { get; set; }

        [PacketIndex(1, RemoveSeparator = true)]
        public List<SitSubPacket> Users { get; set; }

        #endregion
    }
}