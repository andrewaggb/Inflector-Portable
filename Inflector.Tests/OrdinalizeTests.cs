﻿using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Inflector.Tests
{
    [TestFixture]
    public class OrdinalizeTests : InflectorTestBase
    {

        [TestCase(0, "0th")]
        [TestCase(1, "1st")]
        [TestCase(2, "2nd")]
        [TestCase(3, "3rd")]
        [TestCase(4, "4th")]
        [TestCase(5, "5th")]
        [TestCase(6, "6th")]
        [TestCase(7, "7th")]
        [TestCase(8, "8th")]
        [TestCase(9, "9th")]
        [TestCase(10, "10th")]
        [TestCase(11, "11th")]
        [TestCase(12, "12th")]
        [TestCase(13, "13th")]
        [TestCase(14, "14th")]
        [TestCase(20, "20th")]
        [TestCase(21, "21st")]
        [TestCase(22, "22nd")]
        [TestCase(23, "23rd")]
        [TestCase(24, "24th")]
        [TestCase(100, "100th")]
        [TestCase(101, "101st")]
        [TestCase(102, "102nd")]
        [TestCase(103, "103rd")]
        [TestCase(104, "104th")]
        [TestCase(110, "110th")]
        [TestCase(1000, "1000th")]
        [TestCase(1001, "1001st")]
        public void OrdanizeNumbersTest(int number, string ordanized)
        {
            Assert.AreEqual(number.Ordinalize(), ordanized);
        }

    }
}