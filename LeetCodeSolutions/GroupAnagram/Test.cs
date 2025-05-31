using Xunit;
using System.Collections.Generic;
using System.Linq;

public class GroupAnagramsTests
{
    [Fact]
    public void TestGroupAnagrams()
    {
        var solution = new GroupAnagramsSolution();
        var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var expected = new List<List<string>>
        {
            new List<string> { "bat" },
            new List<string> { "nat", "tan" },
            new List<string> { "ate", "eat", "tea" }
        };

        var result = solution.GroupAnagrams(input);

        Assert.Equal(expected.Count, result.Count);

        foreach (var expectedGroup in expected)
        {
            bool matched = result.Any(actualGroup =>
                actualGroup.Count == expectedGroup.Count &&
                !actualGroup.Except(expectedGroup).Any());

            Assert.True(matched, $"Expected group [{string.Join(",", expectedGroup)}] not found in result.");
        }
    }
}
