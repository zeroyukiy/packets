﻿// WingsEmu
// 
// Developed by NosWings Team

namespace WingsEmu.Packets.ClientPackets
{
    [PacketHeader("hero")]
    public class HeroPacket : ClientPacket
    {
        #region Properties

        [PacketIndex(0, serializeToEnd: true)]
        public string Message { get; set; }

        #endregion
    }
}