namespace FlashWing.HIME.Script.Model.Common.Protocol
{
    public enum DataType : byte
    {
        Kill,
        Response,
        Event,
        Publish,
        Confirm,
        PublicKey,
        GZip = 128
    }
}
