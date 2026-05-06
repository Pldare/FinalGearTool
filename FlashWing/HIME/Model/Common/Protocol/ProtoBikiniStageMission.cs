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
    public class ProtoBikiniStageMission : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;

        [ProtoMember(2)]
        public int StarMark;

        [ProtoMember(6)]
        public int CompleteCount;

        [ProtoMember(9)]
        public ObjState State;

        [ProtoMember(14)]
        public long CreateTime;

    }
}
