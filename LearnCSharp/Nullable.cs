namespace LearnCSharp
{
    public class Nullable<T>(T? value = default) where T : struct
    {
        private readonly object _value = value ?? default;

        public bool HasValue
        {
            get => _value != null;
        }

        public T GetValueOrDefault()
        {
            return HasValue ? (T)_value : default;
        }
    }
}
