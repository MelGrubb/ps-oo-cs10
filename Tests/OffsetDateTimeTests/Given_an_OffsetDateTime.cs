using Demo.Solutions.OffsetDateTime;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;

namespace Tests.OffsetDateTimeTests;

[TestFixture]
public class Given_an_OffsetDateTime
{
    [Test]
    public void Then_it_is_identical_to_an_identical_instance()
    {
        var value1 = new OffsetDateTime(2000, 01, 01, 00, 00, 00, new TimeSpan());
        var value2 = new OffsetDateTime(2000, 01, 01, 00, 00, 00, new TimeSpan());

        Assert.AreEqual(value1, value2);
        Assert.AreEqual((object)value1, (object)value2);
        Assert.IsTrue(value1 == value2);
    }

    [Test]
    public void Then_it_is_not_equal_to_a_non_identical_instance()
    {
        var value1 = new OffsetDateTime(2000, 01, 01, 00, 00, 00, new TimeSpan());
        var value2 = new OffsetDateTime(2001, 01, 01, 00, 00, 00, new TimeSpan());

        Assert.AreNotEqual(value1, value2);
        Assert.AreNotEqual((object)value1, (object)value2);
        Assert.IsTrue(value1 != value2);
    }

    [Test]
    public void Then_it_is_equal_to_an_earlier_time_in_a_later_offset()
    {
        var value1 = new OffsetDateTime(2000, 01, 01, 00, 00, 00, new TimeSpan());
        var value2 = new OffsetDateTime(1999, 12, 31, 23, 00, 00, TimeSpan.FromHours(1));

        Assert.AreEqual(value1, value2);
        Assert.AreEqual((object)value1, (object)value2);
        Assert.LessOrEqual(value1, value2);
        Assert.GreaterOrEqual(value1, value2);
        Assert.IsTrue(value1 == value2);
    }

    [Test]
    public void Then_it_is_equal_to_a_later_time_in_an_earlier_offset()
    {
        var value1 = new OffsetDateTime(2000, 01, 01, 00, 00, 00, new TimeSpan());
        var value2 = new OffsetDateTime(2000, 01, 01, 01, 00, 00, TimeSpan.FromHours(-1));

        Assert.AreEqual(value1, value2);
        Assert.AreEqual((object)value1, (object)value2);
        Assert.LessOrEqual(value1, value2);
        Assert.GreaterOrEqual(value1, value2);
        Assert.IsTrue(value1 == value2);
    }

    [Test]
    public void Then_it_is_less_than_the_same_time_in_a_later_offset()
    {
        var value1 = new OffsetDateTime(2000, 01, 01, 00, 00, 00, new TimeSpan());
        var value2 = new OffsetDateTime(2000, 01, 01, 00, 00, 00, TimeSpan.FromHours(1));

        Assert.Less(value1, value2);
        Assert.IsTrue(value1 < value2);
        Assert.IsTrue(value1 <= value2);
    }

    [Test]
    public void Then_it_is_greater_than_the_same_time_in_an_earlier_offset()
    {
        var value1 = new OffsetDateTime(2000, 01, 01, 00, 00, 00, new TimeSpan());
        var value2 = new OffsetDateTime(1999, 12, 31, 23, 00, 00, TimeSpan.FromHours(-1));

        Assert.Greater(value1, value2);
        Assert.IsTrue(value1 > value2);
        Assert.IsTrue(value1 >= value2);
    }
}