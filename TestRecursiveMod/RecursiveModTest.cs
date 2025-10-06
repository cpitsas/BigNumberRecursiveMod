using BigNumberRecursiveMod;

namespace TestRecursiveMod;

public class RecursiveModTest
{
    [Fact]
    public void T01()
    {
        string numberSequence = "777635";
        string divder = "32";

        int mod = RecursiveMod.CalculateMod(numberSequence, divder);

        Assert.Equal(3, mod);
    }

    [Fact]
    public void T02()
    {
        string numberSequence = "999999";
        string divder = "68";

        int mod = RecursiveMod.CalculateMod(numberSequence, divder);

        Assert.Equal(59, mod);
    }

    [Fact]
    public void T03()
    {
        string numberSequence = "491984984";
        string divder = "978";

        int mod = RecursiveMod.CalculateMod(numberSequence, divder);

        Assert.Equal(128, mod);
    }

    [Fact]
    public void T04()
    {
        string numberSequence = "41646849849849161654198498498498498498498498465416515151564651189198484000084984987496874984984984894984984984984981";
        string divder = "97";

        int mod = RecursiveMod.CalculateMod(numberSequence, divder);

        Assert.True(mod < 97);
    }
}