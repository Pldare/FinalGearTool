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
    public class ProtoStageDropView : ProtoBase
    {
        [ProtoMember(1)]
        public int StageId;
        [ProtoMember(2)]
        public string FirstAwardProview;
        [ProtoMember(3)]
        public string AwardProview;
        [ProtoMember(4)]
        public string ActivityAwardProview;
    }

}
