using System;
using System.Collections.Generic;
using Objective.Domain.Common;

namespace Objective.Domain.Tags
{
    public sealed class TagColor : ValueObject
    {
        public TagColor(int red, int green, int blue)
        {
            // TODO: add contract programming

            if (red < 0 || red > 255)
            {
                throw new ArgumentOutOfRangeException(nameof(red), "Value should be in range from 0 to 255");
            }

            if (green < 0 || green > 255)
            {
                throw new ArgumentOutOfRangeException(nameof(green), "Value should be in range from 0 to 255");
            }

            if (blue < 0 || blue > 255)
            {
                throw new ArgumentOutOfRangeException(nameof(blue), "Value should be in range from 0 to 255");
            }

            Red = red;
            Green = green;
            Blue = blue;
        }

        public int Red { get; }

        public int Green { get; }

        public int Blue { get; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Red;
            yield return Green;
            yield return Blue;
        }
    }
}