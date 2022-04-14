using IBuilder;

namespace Duffet.Builders;

public class BankBuilder : IBuilder<Bank>
{
    List<PropertyBuilder> builders = new();

    public Bank Build()
    {
        var bank = new Bank(builders.Select(x => x.Build()));
        return bank;
    }

    public PropertyBuilder Property()
    {
        var builder = new PropertyBuilder();
        builders.Add(builder);
        return builder;
    }
}