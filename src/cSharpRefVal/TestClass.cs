namespace cSharpRefVal
{
    public class TestClass
    {
        public int TestVariable = 5;

        public static TestClass GetImageWithVariable3()
        {
            var testClass = new TestClass { TestVariable = 3 };
            return testClass;
        }

        public void ChangeNumberTo3()
        {
            TestVariable = 3;
        }
    }
}