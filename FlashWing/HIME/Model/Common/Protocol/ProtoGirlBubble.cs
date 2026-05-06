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
    public class ProtoGirlBubble : ProtoBase
    {

        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int Step;
        [ProtoMember(3)]
        public BubbleProcessStatus Status;
        [ProtoMember(4)]
        public int RefreshNum;
        [ProtoMember(5)]
        public Dictionary<int, int> RandomBubbleDic;
        [ProtoMember(6)]
        public BubbleInfo BubbleInfo;
        [ProtoMember(7)]
        public int TodayEnergyCost;
        [ProtoMember(8)]
        public int TodayExpedition;
        [ProtoMember(9)]
        public long TimeFlag;
        [ProtoMember(10)]
        public List<int> UnlockSlots;
    }
}
