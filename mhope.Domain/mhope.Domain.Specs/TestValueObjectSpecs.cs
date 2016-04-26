using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Should;
using SpecsFor;

namespace mhope.Domain.Specs
{
    public class TestValueObjectSpecs
    {
        [TestFixture]
        public class TestResultWithTestValueObject
        {
            [Test]
            public void when_test_value_object_is_null_result_is_failure()
            {
                var sut = TestValueObject.Create(null);
                Assert.That(sut.IsFailure, Is.EqualTo(true));
            }

            [Test]
            public void when_test_object_has_0_character_result_is_failure()
            {
                var sut = TestValueObject.Create(GetTestString(0));
                Assert.That(sut.IsSuccess, Is.EqualTo(false));
            }

            [Test]
            public void when_test_object_has_1_character_result_is_success()
            {
                var sut = TestValueObject.Create(GetTestString(1));
                Assert.That(sut.IsSuccess, Is.EqualTo(true));
            }
            [Test]
            public void when_test_object_has_100_characters_result_is_success()
            {
                var sut = TestValueObject.Create(GetTestString(100));
                Assert.That(sut.IsSuccess, Is.EqualTo(true));
            }

            [Test]
            public void when_test_object_has_101_characters_result_is_failure()
            {
                var sut = TestValueObject.Create(GetTestString(101));
                Assert.That(sut.IsFailure, Is.EqualTo(true));
            }

            private string GetTestString(int lengthOfString)
            {
                StringBuilder ret = new StringBuilder();
                for (int i = 0; i < lengthOfString; i++)
                {
                    ret.Append("A");
                }
                return ret.ToString();
            }
        }
    }
}
