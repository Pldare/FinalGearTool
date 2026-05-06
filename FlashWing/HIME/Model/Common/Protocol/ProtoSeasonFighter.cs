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
    public class ProtoSeasonFighter : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int Area;
        [ProtoMember(3)]
        public int Point;
        [ProtoMember(4)]
        public Dictionary<int, List<long>> EnemyIdDic;
        [ProtoMember(5)]
        public long LastRefreshEnemyTS;
        [ProtoMember(6)]
        public int RankingWhenRefresh;
        [ProtoMember(7)]
        public int BestRanking;
        [ProtoMember(8)]
        public bool IsReceviedRankingAward;
        [ProtoMember(9)]
        public bool IsReceviedPointAward;
        [ProtoMember(10)]
        public List<int> ReceviedFirstAward;
    }
}
