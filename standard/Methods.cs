﻿using System;
using LibCalc.Engine;
using LibCalc.Types;

namespace StandardCalc.standard
{
    internal class Methods
    {
        internal static Method<float> Decimal()
        {
            return SimpleBase;

            [CalcType(CalcType.None)]
            [LevelType(LevelType.None)]
            [ArgsType(ArgsType.None)]
            static float SimpleBase(float[] f)
            {
                Values.Instance.Decimal = true;
                return -1;
            }
        }

        internal static Method<float> Clear()
        {
            return SimpleBase;

            [CalcType(CalcType.None)]
            [LevelType(LevelType.None)]
            [ArgsType(ArgsType.None)]
            static float SimpleBase(float[] f)
            {
                Values.Clear();
                Elements.Clear();
                return -1;
            }
        }

        internal static Method<float> Result()
        {
            return SimpleBase;

            [CalcType(CalcType.None)]
            [LevelType(LevelType.None)]
            [ArgsType(ArgsType.None)]
            static float SimpleBase(float[] f)
            {
                Values.Process();
                Values.Clear();
                return -1;
            }
        }

        internal static Method<float> AddFunction()
        {
            return SimpleBase;

            [CalcType(CalcType.Func)]
            [LevelType(LevelType.Two)]
            [ArgsType(ArgsType.Two)]
            static float SimpleBase(float[] f)
            {
                ValidateArgs(f, ArgsType.Two);
                return f[0] + f[1];
            }
        }

        internal static Method<float> Minus()
        {
            return SimpleBase;

            [CalcType(CalcType.Func)]
            [LevelType(LevelType.Two)]
            [ArgsType(ArgsType.Two)]
            static float SimpleBase(float[] f)
            {
                ValidateArgs(f, ArgsType.Two);
                return f[0] - f[1];
            }
        }

        internal static Method<float> Multiply()
        {
            return SimpleBase;

            [CalcType(CalcType.Func)]
            [LevelType(LevelType.Two)]
            [ArgsType(ArgsType.Two)]
            static float SimpleBase(float[] f)
            {
                ValidateArgs(f, ArgsType.Two);
                return f[0] * f[1];
            }
        }

        internal static Method<float> Division()
        {
            return SimpleBase;

            [CalcType(CalcType.Func)]
            [LevelType(LevelType.Two)]
            [ArgsType(ArgsType.Two)]
            static float SimpleBase(float[] f)
            {
                ValidateArgs(f, ArgsType.Two);
                return f[0] / f[1];
            }
        }

        internal static Method<float> Percent()
        {
            return SimpleBase;

            [CalcType(CalcType.Func)]
            [LevelType(LevelType.One)]
            [ArgsType(ArgsType.Two)]
            static float SimpleBase(float[] f)
            {
                ValidateArgs(f, ArgsType.Two);
                return (f[0] / 100) * f[1];
            }
        }

        internal static Method<float> Square()
        {
            return SimpleBase;

            [CalcType(CalcType.Func)]
            [LevelType(LevelType.Instant)]
            [ArgsType(ArgsType.One)]
            static float SimpleBase(float[] f)
            {
                ValidateArgs(f, ArgsType.One);
                return (float)Math.Pow(f[0], 2);
            }
        }

        internal static Method<float> Sqrt()
        {
            return SimpleBase;

            [CalcType(CalcType.Func)]
            [LevelType(LevelType.Instant)]
            [ArgsType(ArgsType.One)]
            static float SimpleBase(float[] f)
            {
                ValidateArgs(f, ArgsType.One);
                return (float)Math.Sqrt(f[0]);
            }
        }

        internal static Method<float> Invert()
        {
            return SimpleBase;

            [CalcType(CalcType.Func)]
            [LevelType(LevelType.Instant)]
            [ArgsType(ArgsType.One)]
            static float SimpleBase(float[] f)
            {
                ValidateArgs(f, ArgsType.One);
                return (-1) * f[0];
            }
        }

        private static void ValidateArgs(float[] f, ArgsType argType)
        {
            if (f != null && f.Length != (int)argType)
            {
                throw new ArgumentException("count args check failed");
            }
        }
    }
}