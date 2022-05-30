namespace UnitTestApp.Test
{
    public class CalculationTest
    {
        public Calculation calculation { get; set; }
        public CalculationTest()
        {
            this.calculation = new Calculation();
        }

        [Fact]
        public void Add_notParametricValues_ReturnTotalValue()
        {
            //Arrange
            int a = 5;
            int b = 6;
           
            //Add
            var total= calculation.Add(a,b);    

            //Assert
            Assert.Equal(11,total);
        }

        [Theory]
        [InlineData(5,6,11)]
        public void Add_parametricValues_ReturnTotalValue(int a,int b, int expected)
        {
            var totalValue = calculation.Add(a, b);
            Assert.Equal(expected, totalValue);
        }
    }
}