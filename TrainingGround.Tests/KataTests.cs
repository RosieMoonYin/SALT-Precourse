using System;

namespace TrainingGround.Tests;

    public class KataTests
    {
        [Fact]
        public void TestSenior()
        {
            // Age above 55 and handicap above 7 should be "Senior"
            Assert.Equal("Senior", Kata.OpenOrSenior(56, 8));
        }
        [Fact]
        public void TestOpen()
        {
            //Age below 55 and handicap below 7 should be "Open"
            Assert.Equal("Open", Kata.OpenOrSenior(33, 2));
        }


        //all for PIN
        [Fact]
        public void InvalidLengthTest()
        {
            Assert.False(Kata.ValidatePin("1"));
            Assert.False(Kata.ValidatePin("12"));
            Assert.False(Kata.ValidatePin("12"));
            Assert.False(Kata.ValidatePin("123"));
            Assert.False(Kata.ValidatePin("12345"));
            Assert.False(Kata.ValidatePin("1234567"));
            Assert.False(Kata.ValidatePin("-1234"));
            Assert.False(Kata.ValidatePin("1.234"));
            Assert.False(Kata.ValidatePin("-1.234"));
            Assert.False(Kata.ValidatePin("00000000"));
        }

        [Fact]
        public void NonDigitTest()
        {
            Assert.False(Kata.ValidatePin("a234"));
            Assert.False(Kata.ValidatePin(".234"));
            Assert.False(Kata.ValidatePin("123"));
        }

        [Fact]
        public void ValidTest()
        {
            Assert.True(Kata.ValidatePin("1234"));
            Assert.True(Kata.ValidatePin("1111"));
            Assert.True(Kata.ValidatePin("123456"));
            Assert.True(Kata.ValidatePin("090909"));
        }
        [Fact]
        public void LetterChangesTest()
        {   
            Console.WriteLine(Kata.LetterChanges("Hello3"));
            Console.WriteLine(Kata.LetterChanges("Rosie"));
            Console.WriteLine(Kata.LetterChanges("Defghi"));
            Console.WriteLine(Kata.LetterChanges("Hello12d"));
            Console.WriteLine(Kata.LetterChanges("Hello12n"));
            Console.WriteLine(Kata.LetterChanges("aBCdEfghi"));

        }
    }


