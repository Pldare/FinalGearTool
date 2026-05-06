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
    public class ProtoGirlLevelInfo
    {

        [ProtoMember(1)]
        public int Level;

        [ProtoMember(2)]
        public int Exp;

    }
}
