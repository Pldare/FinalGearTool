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
    public class ProtoFighterDesc : ProtoBase
    {
        [ProtoMember(1)]
        public long Id;
        [ProtoMember(2)]
        public string BattleDesc;
    }
}
