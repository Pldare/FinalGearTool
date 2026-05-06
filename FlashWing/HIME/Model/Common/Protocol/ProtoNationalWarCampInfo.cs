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
    public class ProtoNationalWarCampInfo : ProtoBase
    {
        [ProtoMember(1)]
        public long Id;
        [ProtoMember(2)]
        public int BgGirl;
        [ProtoMember(3)]
        public int Level;
        [ProtoMember(4)]
        public string Name;
        [ProtoMember(5)]
        public int PlayerTitle;
        [ProtoMember(6)]
        public long LastLoginTime;
        [ProtoMember(7)]
        public long Power;
        [ProtoMember(8)]
        public NationWarFalg CampType;
        [ProtoMember(9)]
        public int CurrArmyId;
    }
}
