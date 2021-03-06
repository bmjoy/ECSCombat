﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Mathematics;

namespace Battle
{
    public static class MathUtil
    {
        /// <summary>
        /// Gets the heading given a delta vector separating two points.
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public static float GetHeadingToPoint(float3 delta)
        {
            return math.atan2(delta.x, delta.z);
        }

        /// <summary>
        /// Returns the smallest angle difference between two stated angles.
        /// </summary>
        public static float GetAngleDifference(float target, float source)
        {
            // custom mod required - mod(a,n) = a - floor(a / n) * n
            double a = (target - source) + math.PI;
            double n = math.PI * 2;
            return (float)((a - math.floor(a / n) * n) - math.PI);
        }
    }
}
