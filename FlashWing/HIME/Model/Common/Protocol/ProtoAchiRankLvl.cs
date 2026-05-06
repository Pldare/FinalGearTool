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
    public class ProtoAchiRankLvl
    {

        [ProtoMember(1)]
        public int Id;

        [ProtoMember(2)]
        public int Exp;

        [ProtoMember(3)]
        public int Lvl;

        [ProtoMember(4)]
        public List<int> HaveRecievedLvlLst;

    }
}
