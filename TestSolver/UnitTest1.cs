using _2plus2Solver;
namespace TestSolver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlus()
        {
            var solver = new Solver();
            Assert.IsTrue(solver.Plus(2, 2) == 4);
            Assert.IsTrue(solver.Plus(2, 3) == 5);
            Assert.IsTrue(solver.Plus(1, 1) == 2);
        }
        [TestMethod]
        public void TestMult()
        {
            var solver = new Solver();
            Assert.IsTrue(solver.Mult(2, 2) == 4);
            Assert.IsTrue(solver.Mult(2, 3) == 6);
            Assert.IsTrue(solver.Mult(1, 1) == 1);
        }
        [TestMethod]
        public void TestMinus()
        {
            var solver = new Solver();
            Assert.IsTrue(solver.Minus(2, 2) == 0);
            Assert.IsTrue(solver.Minus(5, 3) == 2);
            Assert.IsTrue(solver.Minus(0, 1) == -1);
        }
    }
}