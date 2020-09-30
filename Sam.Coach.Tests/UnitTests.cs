using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Xunit;

namespace Sam.Coach.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(new [] {4,3,5,8,5,0,0,-3}, new [] {3,5,8})]
        [InlineData(new[] { 6,7,8,0,3,4,5,6 }, new[] { 0, 3, 4, 5, 6 })]
        [InlineData(new[] { 0,1,2 }, new[] { 0,1,2 })]
        [InlineData(new[] { 7,8,0 }, new[] { 7,8 })]
        [InlineData(new[] { 1, -2, -7, 0 }, new[] { -7,0 })]
        [InlineData(new[] { 9, 8, 7 }, new[] { 9})]

        // TODO: add more scenarios to ensure finder is working properly
        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {
            ILongestRisingSequenceFinder finder = new LongestRisingSequenceFinder();
            IEnumerable<int> actual = await finder.Find(data);

            // TODO: create the finder instance and get the actual result
            
            actual.Should().Equal(expected);
        }
    }
}
