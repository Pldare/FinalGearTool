namespace FlashWing.HIME.Script.Model.Common.Protocol
{
    public enum DataType : byte
    {
        Kill,
        Request,
        Response,
        Event,
        Publish,
        Confirm,
        PublicKey,
        GZip = 128
    }
}
