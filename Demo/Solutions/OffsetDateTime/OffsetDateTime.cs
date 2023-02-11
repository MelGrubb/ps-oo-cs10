using System;

namespace Demo.Solutions.OffsetDateTime;

public struct OffsetDateTime : IEquatable<OffsetDateTime>, IComparable
{
    public DateTime Value { get; init; }
    public TimeSpan Offset { get; init; }

    public OffsetDateTime(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
    {
        Value = new DateTime(year, month, day, hour, minute, second);
        Offset = offset;
    }

    public bool Equals(OffsetDateTime other)
    {
        var val1 = Value.Add(Offset);
        var val2 = other.Value.Add(other.Offset);

        return val1.Equals(val2);
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Offset);
    }

    public int CompareTo(OffsetDateTime other)
    {
        return Value.Add(Offset).CompareTo(other.Value.Add(other.Offset));
    }

    public int CompareTo(object? other)
    {
        if (other == null) { return 1; }
        if (other is OffsetDateTime otherOffsetDateTime)
        {
            return CompareTo(otherOffsetDateTime);
        }
        else
        {
            throw new ArgumentException("Invalid type for comparison", nameof(other));
        }
    }

    public static bool operator ==(OffsetDateTime left, OffsetDateTime right) => left.Equals(right);

    public static bool operator !=(OffsetDateTime left, OffsetDateTime right) => !left.Equals(right);

    public static bool operator <(OffsetDateTime left, OffsetDateTime right) => left.CompareTo(right) < 0;

    public static bool operator <=(OffsetDateTime left, OffsetDateTime right) => left.CompareTo(right) <= 0;

    public static bool operator >(OffsetDateTime left, OffsetDateTime right) => left.CompareTo(right) > 0;

    public static bool operator >=(OffsetDateTime left, OffsetDateTime right) => left.CompareTo(right) >= 0;
}
