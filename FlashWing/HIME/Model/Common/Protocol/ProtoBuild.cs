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
    public class ProtoBuild : ProtoBase
    {

        [ProtoMember(1)]
        public string Id;

        [ProtoMember(2)]
        public int RecruitDataId;

        [ProtoMember(3)]
        public long StartTime;

        [ProtoMember(4)]
        public long EndTime;

        [ProtoMember(6)]
        public int RecruitLibraryId;

        [ProtoMember(7)]
        public ObjState State;

        [ProtoMember(8)]
        public RecruitSubTypes RecruitSubType;

        [ProtoMember(220)]
        public string CostInfo;

    }
}
