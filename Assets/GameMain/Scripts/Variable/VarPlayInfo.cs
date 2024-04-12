
using GameFramework;

namespace StarForce
{
    public class VarPlayInfo : Variable<PlayInfo>
    {
        public VarPlayInfo() { }

        public static implicit operator VarPlayInfo(PlayInfo value)
        {
            VarPlayInfo varValue = ReferencePool.Acquire<VarPlayInfo>();
            varValue.Value = value;
            return varValue;
        }

        public static implicit operator PlayInfo(VarPlayInfo value)
        {
            return value.Value;
        }
    }
}