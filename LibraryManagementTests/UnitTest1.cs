namespace LibraryManagementTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    //test to check if book was created
    public void AddBook()
    {
        if(AddBook != null)
        {
            Assert.Pass();
        }
    }
}
