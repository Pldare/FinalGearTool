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
    public class ProtoStarshipExplore : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int ExplorePhy;
        [ProtoMember(3)]
        public int ExplorePhyCount;
        [ProtoMember(4)]
        public int OpenChapter;
        [ProtoMember(5)]
        public int Chapter;
        [ProtoMember(6)]
        public Dictionary<int, ProtoStarshipExploreChapter> ExploreChapters;
        [ProtoMember(7)]
        public Dictionary<int, int> ExploreBuffs;
        [ProtoMember(8)]
        public Dictionary<ExploreEventType, ProtoStarshipExploreEvent> ExploreEvents;
        [ProtoMember(9)]
        public ExploreEventType EventType;
        [ProtoMember(10)]
        public List<int> Ships;
        [ProtoMember(11)]
        public List<ProtoExploreEventsLog> ExploreEventsLogs;
        [ProtoMember(12)]
        public int PayDiscount;
    }
}
