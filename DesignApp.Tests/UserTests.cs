using System.Reflection.Metadata;

namespace DesignApp.Tests
{
    public class Tests
    {
       

        [Test]
        public void WhenPoinsAreAdded_ShouldReturnSumPoints()
        {
            //arrange

            var employee = new Employee("Adam", "Suœ", 29);
            employee.Addscore(5);
            employee.Addscore(4);
            employee.Addscore(3);
            employee.Addscore(2);
            employee.Addscore(3);


            //act

            var result = employee.Result;

            //assert

            Assert.AreEqual(17, result);
        }

        [Test]
        public void WhenPoinsAreAdded_ShouldReturnSumPoints1()
        {
            //arrange

            var employee = new Employee("Mariusz", "Sywak", 25);
            employee.Addscore(2);
            employee.Addscore(3);
            employee.Addscore(-5);
            employee.Addscore(3);
            employee.Addscore(2);


            //act

            var result = employee.Result;

            //assert

            Assert.AreEqual(5, result);
        }

        [Test]
        public void WhenPoinsAreAdded_ShouldReturnSumPoints3()
        {
            //arrange

            var employee = new Employee("Krzysztof", "Danielik", 25);
            employee.Addscore(4);
            employee.Addscore(3);
            employee.Addscore(-7);
            employee.Addscore(3);
            employee.Addscore(-2);


            //act

            var result = employee.Result;

            //assert

            Assert.AreEqual(1, result);
        }
    }
}