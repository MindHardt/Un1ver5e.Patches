namespace Un1ver5e.Patches.Tests;

public class OptionalTests
{
    [Fact]
    public void TestValueAccess()
    {
        var optionalWithValue = new Optional<int>(1);
        var optionalWithoutValue = Optional<int>.Empty;

        Assert.True(optionalWithValue.HasValue);
        Assert.Equal(1, optionalWithValue.Value);
        
        Assert.False(optionalWithoutValue.HasValue);
        Assert.Throws<InvalidOperationException>(() => optionalWithoutValue.Value);
    }

    [Fact]
    public void TestCreationEquality()
    {
        const int expectedValue = 1;
        Optional<int> opt1 = expectedValue;
        Optional<int> opt2 = Optional.Create(expectedValue);
        Optional<int> opt3 = Optional<int>.Create(expectedValue);
        
        Optional<int>[] opts = { opt1, opt2, opt3 };
        
        Assert.All(opts, x => Assert.Equal(expectedValue, x));
    }

    [Fact]
    public void TestNullable()
    {
        string? nullString = null;
        
        Optional<string> optionalString = Optional.FromNullable(nullString);
        
        Assert.Equal(Optional<string>.Empty, optionalString);
    }

    [Fact]
    public void TestDataPreserved()
    {
        int @int = Random.Shared.Next();
        string @string = Guid.NewGuid().ToString();

        Optional<int> optionalInt = @int;
        Optional<string> optionalString = @string;
        
        Assert.Equal(@int, optionalInt.Value);
        Assert.Equal(@string, optionalString.Value);
    }
}