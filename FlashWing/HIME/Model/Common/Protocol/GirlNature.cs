using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlashWing.HIME.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class GirlNature
    {
        [ProtoMember(1)]
        public int AttrId;
        [ProtoMember(2)]
        public int AttrLvl;
        [ProtoMember(3)]
        public int AttrExp;
    }
}
