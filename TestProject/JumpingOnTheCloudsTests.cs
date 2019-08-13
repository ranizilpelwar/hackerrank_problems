using System;
using ConsoleApp;
using Xunit;

namespace TestProject
{
    public class JumpingOnTheCloudsTests
    {
        [Fact]
        public void GivenNoClouds_WhenJumpingOnTheClouds_ThenExpectedMinimumJumpsIsReturned()
        {
            Assert.Equal(0, JumpingOnTheClouds.Go(new int[] { }));
        }

        [Fact]
        public void GivenOneSafeCloud_WhenJumpingOnTheClouds_ThenExpectedMinimumJumpsIsReturned()
        {
            Assert.Equal(0, JumpingOnTheClouds.Go(new int[] { 0 }));
        }

        [Fact]
        public void GivenSample1_WhenJumpingOnTheClouds_ThenExpectedMinimumJumpsIsReturned()
        {
            //Assert.Equal("1346", JumpingOnTheClouds.GetPath(new int[] { 0,0,0,0,1,0 }));
            Assert.Equal(3, JumpingOnTheClouds.Go(new int[] { 0,1,0,0,0,1,0 }));
        }

        [Fact]
        public void GivenSample2_WhenJumpingOnTheClouds_ThenExpectedMinimumJumpsIsReturned()
        {
            //Assert.Equal("1346", JumpingOnTheClouds.GetPath(new int[] { 0,0,0,0,1,0 }));
            Assert.Equal(4, JumpingOnTheClouds.Go(new int[] { 0, 0, 1, 0, 0, 1, 0 }));
        }

        [Fact]
        public void GivenSample3_WhenJumpingOnTheClouds_ThenExpectedMinimumJumpsIsReturned()
        {
            //Assert.Equal("1346", JumpingOnTheClouds.GetPath(new int[] { 0,0,0,0,1,0 }));
            Assert.Equal(3, JumpingOnTheClouds.Go(new int[] { 0, 0, 0, 0, 1, 0 }));
        }

        [Fact]
        public void GivenExample_WhenJumpingOnTheClouds_ThenExpectedMinimumJumpsIsReturned()
        {
            //Assert.Equal("1346", JumpingOnTheClouds.GetPath(new int[] { 0, 0, 1, 0, 0, 1, 0 }));
            Assert.Equal(4, JumpingOnTheClouds.Go(new int[] { 0, 0, 1, 0, 0, 1, 0}));
        }

        [Fact]
        public void GivenTestCase1_WhenJumpingOnTheClouds_ThenExpectedMinimumJumpsIsReturned()
        {
            //Assert.Equal("1346", JumpingOnTheClouds.GetPath(new int[] { 0, 0, 1, 0, 0, 1, 0 }));
            Assert.Equal(3, JumpingOnTheClouds.Go(new int[] { 0, 0, 0,1,0,0 }));
        }
    }
}
