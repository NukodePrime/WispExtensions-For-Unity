using System.Collections.Generic;
using UnityEngine;

namespace WispExtensions
{
    public static class WispFloat
    {
        public static Vector2 ToVector2(this float ParamMe)
        {
            return new Vector2(ParamMe, ParamMe);
        }
    }
}