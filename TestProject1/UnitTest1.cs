using System.IO;
using System.Text;
using NUnit.Framework;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var folder = @"C:\yi\temp";
        foreach (var file in Directory.GetFiles(folder))
        {
            int i = 0;
            while (i++ < 10)
            {
                var content = File.ReadAllText(file);
                using var streamWriter = File.AppendText(file);
                streamWriter.Write(new StringBuilder().Append(content));
            }
        }
    }
}