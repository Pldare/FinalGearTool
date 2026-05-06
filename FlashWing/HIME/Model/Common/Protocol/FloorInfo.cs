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
    public class FloorInfo
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int Step;
        [ProtoMember(3)]
        public List<EventData> RndEID;
        [ProtoMember(4)]
        public EventData EID;
        [ProtoMember(5)]
        public List<int> Treasure;
        [ProtoMember(6)]
        public int WeakenId;
        [ProtoMember(7)]
        public int Fnum;
        [ProtoMember(8)]
        public bool Finish;
    }
}
