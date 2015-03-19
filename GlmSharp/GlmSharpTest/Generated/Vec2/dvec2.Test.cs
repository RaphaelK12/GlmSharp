using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Vec2
{
    [TestFixture]
    public class DoubleVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec2(5);
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var v = new dvec2(-7.5d, 3.5d);
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
            }
            {
                var v = new dvec2(new dvec2(-5, 4.5d));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(4.5d, v.y);
            }
            {
                var v = new dvec2(new dvec3(-3, 4.5d, -8.5d));
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(4.5d, v.y);
            }
            {
                var v = new dvec2(new dvec4(2.5d, 1.5d, -3.5d, -8));
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new dvec2(-5, 3);
            Assert.AreEqual(-5, v[0]);
            Assert.AreEqual(3, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            
            v[1] = 0.0;
            Assert.AreEqual(0.0, v[1]);
            v[0] = 1.0;
            Assert.AreEqual(1.0, v[0]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[0] = -4;
            Assert.AreEqual(-4, v[0]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
            v[0] = -9.5d;
            Assert.AreEqual(-9.5d, v[0]);
            v[1] = -8.5d;
            Assert.AreEqual(-8.5d, v[1]);
            v[1] = -7.5d;
            Assert.AreEqual(-7.5d, v[1]);
            v[0] = -6.5d;
            Assert.AreEqual(-6.5d, v[0]);
            v[0] = -5.5d;
            Assert.AreEqual(-5.5d, v[0]);
            v[0] = -4.5d;
            Assert.AreEqual(-4.5d, v[0]);
            v[0] = -3.5d;
            Assert.AreEqual(-3.5d, v[0]);
            v[1] = -2.5d;
            Assert.AreEqual(-2.5d, v[1]);
            v[0] = -1.5d;
            Assert.AreEqual(-1.5d, v[0]);
            v[1] = -0.5d;
            Assert.AreEqual(-0.5d, v[1]);
            v[0] = 0.5d;
            Assert.AreEqual(0.5d, v[0]);
            v[1] = 1.5d;
            Assert.AreEqual(1.5d, v[1]);
            v[0] = 2.5d;
            Assert.AreEqual(2.5d, v[0]);
            v[0] = 3.5d;
            Assert.AreEqual(3.5d, v[0]);
            v[0] = 4.5d;
            Assert.AreEqual(4.5d, v[0]);
            v[1] = 5.5d;
            Assert.AreEqual(5.5d, v[1]);
            v[1] = 6.5d;
            Assert.AreEqual(6.5d, v[1]);
            v[0] = 7.5d;
            Assert.AreEqual(7.5d, v[0]);
            v[0] = 8.5d;
            Assert.AreEqual(8.5d, v[0]);
            v[0] = 9.5d;
            Assert.AreEqual(9.5d, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new dvec2(-9, 9.5d);
            var vals = v.Values;
            Assert.AreEqual(-9, vals[0]);
            Assert.AreEqual(9.5d, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0.0, dvec2.Zero.x);
            Assert.AreEqual(0.0, dvec2.Zero.y);
            
            Assert.AreEqual(1.0, dvec2.Ones.x);
            Assert.AreEqual(1.0, dvec2.Ones.y);
            
            Assert.AreEqual(1.0, dvec2.UnitX.x);
            Assert.AreEqual(0.0, dvec2.UnitX.y);
            
            Assert.AreEqual(0.0, dvec2.UnitY.x);
            Assert.AreEqual(1.0, dvec2.UnitY.y);
            
            Assert.AreEqual(double.MaxValue, dvec2.MaxValue.x);
            Assert.AreEqual(double.MaxValue, dvec2.MaxValue.y);
            
            Assert.AreEqual(double.MinValue, dvec2.MinValue.x);
            Assert.AreEqual(double.MinValue, dvec2.MinValue.y);
            
            Assert.AreEqual(double.Epsilon, dvec2.Epsilon.x);
            Assert.AreEqual(double.Epsilon, dvec2.Epsilon.y);
            
            Assert.AreEqual(double.NaN, dvec2.NaN.x);
            Assert.AreEqual(double.NaN, dvec2.NaN.y);
            
            Assert.AreEqual(double.NegativeInfinity, dvec2.NegativeInfinity.x);
            Assert.AreEqual(double.NegativeInfinity, dvec2.NegativeInfinity.y);
            
            Assert.AreEqual(double.PositiveInfinity, dvec2.PositiveInfinity.x);
            Assert.AreEqual(double.PositiveInfinity, dvec2.PositiveInfinity.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new dvec2(-7.5d, 1.0);
            var v2 = new dvec2(-7.5d, 1.0);
            var v3 = new dvec2(1.0, -7.5d);
            Assert.That(v1 == new dvec2(v1));
            Assert.That(v2 == new dvec2(v2));
            Assert.That(v3 == new dvec2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

    }
}
