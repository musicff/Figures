using System;
using System.Collections.Generic;
using System.Linq;
namespace TestFigures
{
    public class TestCircleArea
    {
        [Fact]
        public void IsCircleAreaCorrect()
        {
            Assert.Equal(Math.PI * 4, FiguresUtil.GetCircleAreaByRadius(2));
            Assert.Equal(Math.PI * 9, FiguresUtil.GetCircleAreaByRadius(3));
        }

        [Fact]
        public void IsInputValid()
        {
            Assert.Throws<ArgumentException>(() => FiguresUtil.GetCircleAreaByRadius(0));
            Assert.Throws<ArgumentException>(() => FiguresUtil.GetCircleAreaByRadius(-1));
        }
    }
}
