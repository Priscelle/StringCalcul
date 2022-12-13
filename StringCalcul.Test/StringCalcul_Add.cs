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
        public void Returns0GivenStringWith1()
        {
            var calcul = new StringCalcul();
            var result = calcul.Add("1");

            Assert.Equal(1, result);

        }
    }
}