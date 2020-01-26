namespace ExLib.TamTam.Bot.Queries
{
    public class QueryParam<T> : IQueryParam
    {
        private T _value;
        public string Name { get; }
        object IQueryParam.Value => Value;
        public string ValueString => Value?.ToString();

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                IsSetValue = value != null;
            }
        }

        public bool IsRequired { get; private set; }

        public bool IsSetValue { get; private set; }

        public QueryParam(string name, ITamTamQuery holder) : this(name, default(T), holder)
        {
            IsSetValue = false;
        }

        public QueryParam(string name, T defaultValue, ITamTamQuery holder)
        {
            Name = name;
            Value = defaultValue;
            IsSetValue = true;
            holder.AddParam(this);
        }

        public QueryParam<T> Required()
        {
            IsRequired = true;
            return this;
        }

    }
}