using System; 

namespace RelativesLib
{
    [Flags]
    public enum Directions : byte
    {
        //Mid
        None = 0,
        Up = 1 << 0,
        Down = 1 << 1,
        Forward = 1 << 2,
        Right = 1 << 3,
        Back = 1 << 4,
        Left = 1 << 5,
        ForwardRight = Forward | Right,
        BackRight = Back | Right,
        BackLeft = Back | Left,
        ForwardLeft = Forward | Left,
        //Up
        UpForward = Up | Forward,
        UpForwardRight = Up | ForwardRight,
        UpRight = Up | Right,
        UpBackRight = Up | BackRight,
        UpBack = Up | Back,
        UpBackLeft = Up | BackLeft,
        UpLeft = Up | Left,
        UpForwardLeft = Up | ForwardLeft,
        //Down
        DownForward = Down | Forward,
        DownForwardRight = Down | ForwardRight,
        DownRight = Down | Right,
        DownBackRight = Down | BackRight,
        DownBack = Down | Back,
        DownBackLeft = Down | BackLeft,
        DownLeft = Down | Left,
        DownForwardLeft = Down | ForwardLeft,
    }
}
