﻿using Xunit;

namespace Minicloner.Tests
{
    public class CloneNullableTypesTests
    {
        [Fact]
        public void Clone_NullInt32()
        {
            int? nullInt32 = null;
            var cloned = new Cloner().Clone(nullInt32);

            Assert.Null(cloned);
        }

        [Fact]
        public void Clone_NotNullInt32()
        {
            int? notNullInt32 = 1;
            var cloned = new Cloner().Clone(notNullInt32);

            Assert.IsType<int>(cloned);
#pragma warning disable xUnit2005 // We are comparing instances not values
            Assert.NotSame(notNullInt32, cloned);
#pragma warning restore xUnit2005
            Assert.Equal(notNullInt32, cloned);
        }
    }
}