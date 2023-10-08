using FluentAssertions;
using Moq;

namespace LockSolver.UnitTest;

public class Tests
{
    [TestFixture]
    public class LockSolverTests
    {
        [Test]
        public void Should_Find_Correct_Lock_Code_When_All_Hints_Match()
        {
            var exactMAtchHint = new Mock<IHint>();
            exactMAtchHint.Setup(x => x.IsMatch("123")).Returns(true);
            var rightDigitWrongPlaceHint = new Mock<IHint>();
            rightDigitWrongPlaceHint.Setup(x => x.IsMatch("123")).Returns(true);
            var twoRightDigitWrongPlaceHint = new Mock<IHint>();
            twoRightDigitWrongPlaceHint.Setup(x => x.IsMatch("123")).Returns(true);
            var noMatchHint = new Mock<IHint>();
            noMatchHint.Setup(x => x.IsMatch("123")).Returns(true);

            List<IHint> hints = new List<IHint>
            {
                exactMAtchHint.Object,
                rightDigitWrongPlaceHint.Object,
                twoRightDigitWrongPlaceHint.Object,
                noMatchHint.Object
            };

            LockSolverClass solver = new LockSolverClass(hints, 3);
            
            //Act
            string solution = solver.Solve();
            
            //Assert
            solution.Should().Be("123");


        }

        [Test]
        public void Should_Return_No_Solution_When_Hints_Do_Not_Match()
        {
            //Arrange
            var exactMatchHint = new Mock<IHint>();
            exactMatchHint.Setup(x => x.IsMatch(It.IsAny<string>())).Returns(false);
            List<IHint> hints = new List<IHint>
            {
                exactMatchHint.Object
            };
            LockSolverClass solver = new LockSolverClass(hints, 3);
            
            //Act
            string solution = solver.Solve();
            //Assert
            solution.Should().Be("No Key Found");
        }
    }
}