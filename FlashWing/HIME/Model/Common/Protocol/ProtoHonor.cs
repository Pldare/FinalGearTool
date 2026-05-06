using FlashWing.HIME.Model.Common.Enum;
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
    public class ProtoHonor : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public Dictionary<OpenArea, int> HonorAreaLock;
        [ProtoMember(3)]
        public Dictionary<int, int> HonorItemList;
        [ProtoMember(4)]
        public Dictionary<int, int> QuestionList;
        [ProtoMember(5)]
        public int Level;
        [ProtoMember(6)]
        public long HonorVal;
        [ProtoMember(7)]
        public Dictionary<int, int> HonorAllItemList;
        [ProtoMember(8)]
        public bool GetTodayReward;
    }
}
