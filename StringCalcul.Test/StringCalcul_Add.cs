namespace StringCalcul.Test
{
    public class StringCalcul_Add

    {
        private StringCalcul _calculator = new StringCalcul();
        [Fact]

        public void Returns0GivenEmptyString()
        {
            var result = _calculator.Add("");

            Assert.Equal(0, result);

        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void ReturnsNumberGivenStringWithOneNumber(string numbers, int exceptedResult)
        {
            var calcul = new StringCalcul();
            var result = _calculator.Add("1");

            Assert.Equal(exceptedResult, result);

        }

        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("2,3,4",9)]
        public void ReturnsSumGivenStringWithOneNumber(string numbers, int exceptedResult)
        {
            var calcul = new StringCalcul();
            var result = _calculator.Add("1");

            Assert.Equal(exceptedResult, result);

        }

        [Theory]
        [InlineData("\\n1,2,3", 6)]
        public void ReturnSumGivenStringWithThreeComaOrNewLineSeparatedNumbers
            (string numbers, int exceptedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(exceptedResult, result);
        }
    }
}