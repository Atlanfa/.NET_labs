using System;
using System.Data;
using System.ServiceModel;
using System.Runtime.Serialization;

[ServiceContract]
public interface IService
{
    [OperationContract]
    string Insert_Book(BookService book);
    [OperationContract]
    string Insert_Author(AuthorService author);
    [OperationContract]
    string Insert_Genre(GenreService genre);
    [OperationContract]
    string Update_Book(BookService book);
    [OperationContract]
    string Update_Author(AuthorService author);
    [OperationContract]
    string Update_Genre(GenreService genre);
    [OperationContract]
    DataSet Read_Book();
    [OperationContract]
    DataSet Read_Author();
    [OperationContract]
    DataSet Read_Genre();
}

[DataContract]
public class BookService
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Title { get; set; }
    [DataMember]
    public int Age_Release { get; set; }
    [DataMember]
    public int Id_Author { get; set; }
    [DataMember]
    public int Id_Genre { get; set; }
    [DataMember]
    public DateTime Date_Updated { get; set; }
}

[DataContract]
public class AuthorService
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public int Date_of_Birth { get; set; }
}

[DataContract]
public class GenreService
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
}
