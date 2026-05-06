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
    public class ATBossView : ProtoBase
    {
        [ProtoMember(1)]
        public long Id;
        [ProtoMember(2)]
        public string OriginPlayerName;
        [ProtoMember(3)]
        public int BossConfID;
        [ProtoMember(4)]
        public ATBossStatus BossStatus;
        [ProtoMember(5)]
        public Dictionary<long, int> DamageValueDic;
        [ProtoMember(6)]
        public long StartBossBattleTS;
        [ProtoMember(7)]
        public int BornRuleID;
        [ProtoMember(8)]
        public Dictionary<int, int> MonserDamageInfo;
        [ProtoMember(9)]
        public long OriginPlayerId;
    }
}
