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
    public class ResponseOperation
    {
        [ProtoMember(1)]
        public OperationCode Operation;
        [ProtoMember(2)]
        public DataType ResponseType;
        [ProtoMember(3)]
        public ErrorCode ErrorCode;
        [ProtoMember(4)]
        public long UserId;
        [ProtoMember(5)]
        public string SessionId;
        [ProtoMember(6)]
        public Dictionary<DataTypes, HashSet<ProtoBase>> ReturnCache;
        [ProtoMember(7)]
        public Dictionary<DataTypes, HashSet<byte[]>> ReturnCacheBytes;

        public ResponseOperation()
        {

        }
        public ResponseOperation(OperationCode operation, long userId, DataType type = DataType.Response)
        {
            this.Operation = operation;
            this.UserId = userId;
            this.ResponseType = type;
        }
    }
}
