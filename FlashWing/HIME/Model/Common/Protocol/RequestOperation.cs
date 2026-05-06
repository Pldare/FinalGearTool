using FlashWing.HIME.Model.Common.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashWing.HIME.Script.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class RequestOperation
    {
        [ProtoMember(1)]
        public OperationCode OpCode;
        [ProtoMember(2)]
        public int RetailType;
        [ProtoMember(3)]
        public string RetailID;
        [ProtoMember(4)]
        public string RetailUid;
        [ProtoMember(5)]
        public int MsgId;
        [ProtoMember(6)]
        public string SessionId;
        [ProtoMember(7)]
        public int ActionId;
        [ProtoMember(8)]
        public long UserId;
        [ProtoMember(9)]
        public string UserToken;
        [ProtoMember(10)]
        public string PackageSign;
        [ProtoMember(11)]
        public string Channel;
        [ProtoMember(12)]
        public string Bid;
        [ProtoMember(13)]
        public string ServerId;
        [ProtoMember(14)]
        public string AppId;
        [ProtoMember(15)]
        public string Udid;
        [ProtoMember(16)]
        public string PhoneType;
        [ProtoMember(17)]
        public string Sys_Version;
        [ProtoMember(18)]
        public string ClientVer;
        [ProtoMember(30)]
        public string Bundle;
        [ProtoMember(101)]
        public int I32_1;
        [ProtoMember(102)]
        public int I32_2;
        [ProtoMember(103)]
        public int I32_3;
        [ProtoMember(104)]
        public int I32_4;
        [ProtoMember(105)]
        public int I32_5;
        [ProtoMember(106)]
        public int? I32_6;
        [ProtoMember(111)]
        public string Str_1;
        [ProtoMember(112)]
        public string Str_2;
        [ProtoMember(113)]
        public string Str_3;
        [ProtoMember(116)]
        public long I64_1;
        [ProtoMember(117)]
        public long I64_2;
        [ProtoMember(118)]
        public long I64_3;
        [ProtoMember(121)]
        public bool Bool_1;
        [ProtoMember(122)]
        public bool Bool_2;
        [ProtoMember(123)]
        public bool Bool_3;
        [ProtoMember(131)]
        public byte Byte_1;
        [ProtoMember(132)]
        public byte Byte_2;
        [ProtoMember(133)]
        public byte Byte_3;
        [ProtoMember(201)]
        public string[] Str_Array;
        [ProtoMember(202)]
        public int[] Int32_Array;
        [ProtoMember(203)]
        public long[] Int64_Array;
        [ProtoMember(204)]
        public byte[] Byte_Array;
        [ProtoMember(211)]
        public Dictionary<int, int> Int32_Dic;
        [ProtoMember(212)]
        public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus;
        [ProtoMember(213)]
        public Dictionary<int, ProtoRoleBattleGroup> PersonalStoryBattleGroup;
        [ProtoMember(214)]
        public List<ProtoBattleMonsterStatus> MonsterStatus;
        [ProtoMember(215)]
        public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus;
        [ProtoMember(216)]
        public ProtoStarshipPVPFormation[] StarshipPVPFormation;
    }
}