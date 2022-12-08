using ObjCRuntime;

namespace Drastic.MarqueeLabelObjc
{
    [Native]
    public enum MarqueeType : ulong
    {
        LeftRight = 0,
        RightLeft = 1,
        Continuous = 2,
        ContinuousReverse = 3,
        Left = 4,
        Right = 5
    }
}
