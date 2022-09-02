namespace Assignment_0.Tests;

public class UnitTest1
{
    [Fact]
    public void Main_Should_Print_Hello_World()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        Program.Main(Array.Empty<string>());
        // program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello, World!");       
    }
}