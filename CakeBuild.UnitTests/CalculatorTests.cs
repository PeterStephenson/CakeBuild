using NUnit.Framework;

namespace CakeBuild.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void When_adding_two_numbers__Then_the_result_is_correct()
        {
            var calculator = new Calculator();

            var result = calculator.Add( 1, 2 );

            Assert.That( result, Is.EqualTo( 3 ) );
        }
    }
}
