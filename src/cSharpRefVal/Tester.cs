using System;

namespace cSharpRefVal
{
    public class Tester
    {
        public void Run()
        {
            Test1(); //should stay 5 because you create a new instance in class for the method scope which points to a new object and won't change original
            Test2(); //should be 3 because you pass in by ref so you edit the same one
            Test3(); //should also be 3 because you pass in value of the pointer to the object, so you're still editing the same object
        }

        private void Test1()
        {
            var testClass = new TestClass();
            TestByValue(testClass);

            Console.WriteLine(testClass.TestVariable);
        }

        private void Test2()
        {
            var testClass = new TestClass();
            TestByRef(ref testClass);

            Console.WriteLine(testClass.TestVariable);
        }

        private void Test3()
        {
            var testClass = new TestClass();
            TestByDataChange(testClass);

            Console.WriteLine(testClass.TestVariable);
        }

        private void TestByValue(TestClass testClass)
        {
            testClass = TestClass.GetImageWithVariable3();
        }

        private void TestByRef(ref TestClass testClass)
        {
            testClass = TestClass.GetImageWithVariable3();
        }

        private void TestByDataChange(TestClass testClass)
        {
            testClass.ChangeNumberTo3();
        }
    }
}