namespace StringCalcul.Test;

public class StringCalcul
{
    internal object Add(string numbers)
    {
        if (String.IsNullOrEmpty(numbers)) return 0;

        var delimiters = new [] { ',', '\n' };
        var result = numbers.Split(delimiters)
            .Select(s => int.Parse(s))
            .Sum();

        return result;
    }
}
