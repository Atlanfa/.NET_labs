namespace UnitTest_Library
{
    using Data;
    using System.Linq;
    using Logic_Querys;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_List_Book_Choice_Author_Id__Verify_Test()
        {
            LINQ_QUERYs query1 = new LINQ_QUERYs();
            IQueryable<Book> found = query1.ListBooksAuthId(1);
            Assert.AreEqual(3, found.ToArray().Length);
        }

        [TestMethod]
        public void Get_List_Authors_Who_Burn_IN_Choice_Year_Test()
        {
            LINQ_QUERYs query2 = new LINQ_QUERYs();
            const int year = 1888;
            IQueryable<Author> found = query2.ListAuthorsYear(year);
            Assert.AreEqual(1, found.ToArray().Length);
        }

        [TestMethod]
        public void Get_Top_3_Oldest_Authors_Test()
        {
            LINQ_QUERYs query3 = new LINQ_QUERYs();
            IQueryable<Author> found = query3.Top3OldestAuthors();
            Assert.AreEqual(3, found.ToArray().Length);
        }

        [TestMethod]
        public void Get_Top_3_Youngest_Authors_Test()
        {
            LINQ_QUERYs query3 = new LINQ_QUERYs();
            IQueryable<Author> found = query3.Top3YoungAuthors();
            Assert.AreEqual(3, found.ToArray().Length);
        }

        [TestMethod]
        public void Get_List_Books_The_Same_Years_Release_Test()
        {
            LINQ_QUERYs query5 = new LINQ_QUERYs();
            int age_release = 1988;
            IQueryable<Book> found = query5.BooksAgeRelease(age_release);
            Assert.AreEqual(2, found.ToArray().Length);
        }
    }
}
