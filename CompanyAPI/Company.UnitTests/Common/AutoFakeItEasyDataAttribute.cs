using AutoFixture.AutoFakeItEasy;
using AutoFixture;
using AutoFixture.Xunit2;

namespace Company.UnitTests.Common
{
    public class AutoFakeItEasyDataAttribute : AutoDataAttribute
    {
        public AutoFakeItEasyDataAttribute()
            : base(() => new Fixture().Customize(new AutoFakeItEasyCustomization()))
        {
        }
    }
}
