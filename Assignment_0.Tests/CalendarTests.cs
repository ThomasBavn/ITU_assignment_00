namespace Assignment_0.Tests;

public class CalendarTests
{
    [Fact]
    public void Not_leap_Year_because_not_divisible_by_4()
    {
        // Act
        var result = Calendar.IsLeapYear(2022) &&
            Calendar.IsLeapWithDateTime(2022);
        // Assert
        result.Should().Be(false);

    }

    [Fact]
    public void Is_Leap_year_because_divisible_by_4()
    {
        // Act
        var result = Calendar.IsLeapYear(1616) &&
            Calendar.IsLeapWithDateTime(1616);
        // Assert
        result.Should().Be(true);
    }

    [Fact]
    public void Not_leap_year_because_divisible_by_100()
    {
        // Act
        var result = Calendar.IsLeapYear(1500) &&
            Calendar.IsLeapWithDateTime(1500);
        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Still_leap_year_because_divisible_by_400()
    {
        // Act
        var result = Calendar.IsLeapYear(1600) &&
            Calendar.IsLeapWithDateTime(1600);
        // Assert
        result.Should().Be(true);
    }

    [Fact]
    public void isLeapYearUsingDateTime()
    {
        var result = Calendar.IsLeapWithDateTime(2020);
        result.Should().Be(true);
    }

}