
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController valuesController = new();

    [Fact]
    public void GetAllFromList()
    {
        var returnValues = valuesController.Get();
        Assert.NotNull(returnValues);
        
    }


    [Fact]
    public void GetItemFromList()
    {
        var returnValues = valuesController.Get(1);
        Assert.NotNull(returnValues);
        Assert.Equal("Dushey@", returnValues, false);
    }


    [Fact]
    public void Test1()
    {

    }
}