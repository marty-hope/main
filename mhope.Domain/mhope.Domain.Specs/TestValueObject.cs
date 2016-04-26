using System;

namespace mhope.Domain.Specs
{
    public class TestValueObject : ValueObject<TestValueObject>
    {
        private readonly string _value;
        private const int MaxLength = 100;

        public TestValueObject(string value)
        {
            _value = value;
        }

        public static Result<TestValueObject> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return Result.Fail<TestValueObject>("Value cannot be null or empty.");
            }
            value = value.Trim();

            if (value.Length > MaxLength)
            {
                return Result.Fail<TestValueObject>($"Value is cannot be longer than {MaxLength}");
            }
            return Result.Ok(new TestValueObject(value));

        }
        protected override bool EqualsCore(TestValueObject other)
        {
            return _value == other._value;
        }

        protected override int GetHashCodeCore()
        {
            return _value.GetHashCode();
        }
        public static explicit operator TestValueObject(string customerName)
        {
            return Create(customerName).Value;
        }

        public static implicit operator string(TestValueObject customerName)
        {
            return customerName._value;
        }
    }
}
