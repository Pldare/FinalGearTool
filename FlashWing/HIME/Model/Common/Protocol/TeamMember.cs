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
    public class TeamMember
    {

        [ProtoMember(1)]
        public int GirlId;

        [ProtoMember(2)]
        public int Level;

        [ProtoMember(3)]
        public int Start;

        [ProtoMember(4)]
        public int Skin;

    }
}
