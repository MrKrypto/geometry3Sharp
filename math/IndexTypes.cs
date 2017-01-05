﻿using System;

namespace g3
{

    public struct Index3i
    {
        public int a;
        public int b;
        public int c;

        public Index3i(int z) { a = b = c = z; }
        public Index3i(int ii, int jj, int kk) { a = ii; b = jj; c = kk; }
        public Index3i(int[] i2) { a = i2[0]; b = i2[1]; c = i2[2]; }
        public Index3i(Index3i copy) { a = copy.a; b = copy.b; c = copy.b; }

        static public readonly Index3i Zero = new Index3i(0, 0, 0);
        static public readonly Index3i One = new Index3i(1, 1, 1);
        static public readonly Index3i Max = new Index3i(int.MaxValue, int.MaxValue, int.MaxValue);


        public int this[int key]
        {
            get { return (key == 0) ? a : (key == 1) ? b : c; }
            set { if (key == 0) a = value; else if (key == 1) b = value; else c = value; }
        }

        public int[] array {
            get { return new int[] { a, b, c }; }
        }


        public int LengthSquared
        {
            get { return a * a + b * b + c * c; }
        }
        public int Length
        {
            get { return (int)Math.Sqrt(LengthSquared); }
        }


        public void Set(Index3i o)
        {
            a = o[0]; b = o[1]; c = o[2];
        }
        public void Set(int ii, int jj, int kk)
        {
            a = ii; b = jj; c = kk;
        }


        public static Index3i operator -(Index3i v)
        {
            return new Index3i(-v.a, -v.b, -v.c);
        }

        public static Index3i operator *(int f, Index3i v)
        {
            return new Index3i(f * v.a, f * v.b, f * v.c);
        }
        public static Index3i operator *(Index3i v, int f)
        {
            return new Index3i(f * v.a, f * v.b, f * v.c);
        }
        public static Index3i operator /(Index3i v, int f)
        {
            return new Index3i(v.a / f, v.b / f, v.c / f);
        }


        public static Index3i operator *(Index3i a, Index3i b)
        {
            return new Index3i(a.a * b.a, a.b * b.b, a.c * b.c);
        }
        public static Index3i operator /(Index3i a, Index3i b)
        {
            return new Index3i(a.a / b.a, a.b / b.b, a.c / b.c);
        }


        public static Index3i operator +(Index3i v0, Index3i v1)
        {
            return new Index3i(v0.a + v1.a, v0.b + v1.b, v0.c + v1.c);
        }
        public static Index3i operator +(Index3i v0, int f)
        {
            return new Index3i(v0.a + f, v0.b + f, v0.c + f);
        }

        public static Index3i operator -(Index3i v0, Index3i v1)
        {
            return new Index3i(v0.a - v1.a, v0.b - v1.b, v0.c - v1.c);
        }
        public static Index3i operator -(Index3i v0, int f)
        {
            return new Index3i(v0.a - f, v0.b - f, v0.c - f);
        }


        public static bool operator ==(Index3i a, Index3i b)
        {
            return (a.a == b.a && a.b == b.b && a.c == b.c);
        }
        public static bool operator !=(Index3i a, Index3i b)
        {
            return (a.a != b.a || a.b != b.b || a.c != b.c);
        }
        public override bool Equals(object obj)
        {
            return this == (Index3i)obj;
        }
        public override int GetHashCode()
        {
            return (a+b+c).GetHashCode();
        }
        


        public override string ToString() {
            return string.Format("[{0:F8},{1:F8},{2:F8}]", a, b, c);
        }

    }












    public struct Index2i
    {
        public int a;
        public int b;

        public Index2i(int z) { a = b = z; }
        public Index2i(int ii, int jj) { a = ii; b = jj; }
        public Index2i(int[] i2) { a = i2[0]; b = i2[1]; }
        public Index2i(Index2i copy) { a = copy.a; b = copy.b; }

        static public readonly Index2i Zero = new Index2i(0, 0);
        static public readonly Index2i One = new Index2i(1, 1);
        static public readonly Index2i Max = new Index2i(int.MaxValue, int.MaxValue);


        public int this[int key]
        {
            get { return (key == 0) ? a : b; }
            set { if (key == 0) a = value; else b = value; }
        }

        public int[] array {
            get { return new int[] { a, b }; }
        }


        public int LengthSquared
        {
            get { return a * a + b * b; }
        }
        public int Length
        {
            get { return (int)Math.Sqrt(LengthSquared); }
        }


        public void Set(Index2i o)
        {
            a = o[0]; b = o[1];
        }
        public void Set(int ii, int jj)
        {
            a = ii; b = jj;
        }


        public static Index2i operator -(Index2i v)
        {
            return new Index2i(-v.a, -v.b);
        }

        public static Index2i operator *(int f, Index2i v)
        {
            return new Index2i(f * v.a, f * v.b);
        }
        public static Index2i operator *(Index2i v, int f)
        {
            return new Index2i(f * v.a, f * v.b);
        }
        public static Index2i operator /(Index2i v, int f)
        {
            return new Index2i(v.a / f, v.b / f);
        }


        public static Index2i operator *(Index2i a, Index2i b)
        {
            return new Index2i(a.a * b.a, a.b * b.b);
        }
        public static Index2i operator /(Index2i a, Index2i b)
        {
            return new Index2i(a.a / b.a, a.b / b.b);
        }


        public static Index2i operator +(Index2i v0, Index2i v1)
        {
            return new Index2i(v0.a + v1.a, v0.b + v1.b);
        }
        public static Index2i operator +(Index2i v0, int f)
        {
            return new Index2i(v0.a + f, v0.b + f);
        }

        public static Index2i operator -(Index2i v0, Index2i v1)
        {
            return new Index2i(v0.a - v1.a, v0.b - v1.b);
        }
        public static Index2i operator -(Index2i v0, int f)
        {
            return new Index2i(v0.a - f, v0.b - f);
        }


        public static bool operator ==(Index2i a, Index2i b)
        {
            return (a.a == b.a && a.b == b.b);
        }
        public static bool operator !=(Index2i a, Index2i b)
        {
            return (a.a != b.a || a.b != b.b);
        }
        public override bool Equals(object obj)
        {
            return this == (Index2i)obj;
        }
        public override int GetHashCode()
        {
            return (a+b).GetHashCode();
        }
        


        public override string ToString() {
            return string.Format("[{0:F8},{1:F8}]", a, b);
        }

    }




}