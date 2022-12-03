namespace TestFigures
{
    public class TestTriangleArea
    {
        [Fact]
        public void IsTreangleAreaCorrect()
        {
            Assert.Equal(6.0, FiguresUtil.GetTriangleAreaBySides(3, 4, 5));
            Assert.Equal(12.0, FiguresUtil.GetTriangleAreaBySides(5, 5, 8));
        }

        [Fact]
        public void IsRightCorrect()
        {
            Assert.True(new Triangle(3, 4, 5).IsRight);
            Assert.False(new Triangle(1, 1, 1).IsRight);
        }

        [Fact]
        public void IsIuputCorrect()
        {
            Assert.Throws<ArgumentException>(() => FiguresUtil.GetTriangleAreaBySides(0, 1, 1));
            Assert.Throws<ArgumentException>(() => FiguresUtil.GetTriangleAreaBySides(1, 0, 1));
            Assert.Throws<ArgumentException>(() => FiguresUtil.GetTriangleAreaBySides(1, 1, 0));

            Assert.Throws<ArgumentException>(() => FiguresUtil.GetTriangleAreaBySides(-1, 1, 1));
            Assert.Throws<ArgumentException>(() => FiguresUtil.GetTriangleAreaBySides(1, -1, 1));
            Assert.Throws<ArgumentException>(() => FiguresUtil.GetTriangleAreaBySides(1, 1, -1));

            Assert.Throws<ArgumentException>(() => FiguresUtil.GetTriangleAreaBySides(1, 1, 2));
            Assert.Throws<ArgumentException>(() => FiguresUtil.GetTriangleAreaBySides(2, 1, 1));
            Assert.Throws<ArgumentException>(() => FiguresUtil.GetTriangleAreaBySides(1, 2, 1));

        }
    }
}
