

namespace DesignApp.Tests
{
    public class Type_Tests
    {

        [Test]
        public void WhenComparedTwoInt_ShouldBeEqual()
        {

            //arrange

            int number1 = 29;
            int number2 = 29;

            //Assert
            Assert.AreEqual(number1, number2);

        }


        [Test]
        public void WhenComparedTwoString_ShouldBeEqual()
        {

            //arrange

            string employee1 = "Bartek";
            string employee2 = "Bartek";

            //Assert
            Assert.AreEqual(employee1, employee2);

        }

        [Test]
        public void WhenComparedTwoEmployeesAge_ShouldNotBeEqual()
        {

            //arrange

            int age1 = 29;
            int age2 = 25;

            //Assert
            Assert.AreNotEqual(age1, age2);

        }

        [Test]
        public void WhenComparedTwoEmployees_ShouldNotBeEqual() 
        {

            //arrange

            var employee1 = GetEmployee("Adam", "Suś", 29);
            var employee2 = GetEmployee("Mariusz", "Sywak", 25);

            //Assert
            Assert.AreNotEqual(employee1, employee2);
        
        }

        private Employee GetEmployee(string name, string surname, int age) 
        {

            return new Employee(name,surname,age);
        
        }

    }
}
