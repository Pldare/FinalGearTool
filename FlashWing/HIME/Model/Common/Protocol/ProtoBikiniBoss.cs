using FlashWing.HIME.Script.Model.Common.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashWing.HIME.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class ProtoBikiniBoss : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int BattleNum;
        [ProtoMember(3)]
        public int WinNum;
        [ProtoMember(4)]
        public int Score;
        [ProtoMember(5)]
        public int[] Sockets;
        [ProtoMember(6)]
        public Dictionary<int, BikiniBossMission> Missions;
    }
}
