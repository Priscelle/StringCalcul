namespace StringCalcul.Test
{
    public class StringCalcul_Add

    {
        [Fact]
        public void Returns0GivenEmptyString()
        {
            var calcul = new StringCalcul();
            var result = calcul.Add("");

            Assert.Equal(0, result);

        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void ReturnsNumberGivenStringWithOneNumber(string numbers, int exceptedResult)
        {
            var calcul = new StringCalcul();
            var result = calcul.Add("1");

            Assert.Equal(exceptedResult, result);

        }

        [Theory]
        [InlineData("1,3", 3)]
        [InlineData("2,3",5)]
        public void ReturnsSumGivenStringWithOneNumber(string numbers, int exceptedResult)
        {
            var calcul = new StringCalcul();
            var result = calcul.Add("1");

            Assert.Equal(exceptedResult, result);

        }
    }
}