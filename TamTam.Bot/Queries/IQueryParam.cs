namespace ExLib.TamTam.Bot.Queries
{
    public interface IQueryParam
    {
        string Name { get; }

        object Value { get; }

        string ValueString { get; }

        bool IsRequired { get; }

        bool IsSetValue { get; }
    }
}
