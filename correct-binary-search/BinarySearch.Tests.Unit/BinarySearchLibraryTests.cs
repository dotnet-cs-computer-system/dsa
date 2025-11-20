using BinarySearch.Core;
using FluentAssertions;

namespace BinarySearch.Tests.Unit;

public class BinarySearchLibraryTests
{
    [Fact]
    public void Search_ReturnCorrectValue_WhenArrayIsProvided()
    {
        // arrange
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int n = 4;
        int expectedIndex = 3;
        
        // action 
        int result = BinarySearchLibrary.Search(array, n);

        // assert 
        result.Should().Be(expectedIndex);
    }
}