namespace Data
{
    using System.Collections.Generic;

    public class MSMQ_Messages
    {
        public List<string> Messages(List<Book> table_books)
        {
            List<string> msgs = new List<string>();

            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(3); // очередь 3
            numbers.Enqueue(5); // очередь 3, 5
            numbers.Enqueue(8); // очередь 3, 5, 8



            // получаем первый элемент очереди
            int queueElement = numbers.Dequeue(); //теперь очередь 5, 8

            msgs.Add($"Получаем первый елемент очереди {queueElement} - {table_books[queueElement]}");

            Queue<Book> books = new Queue<Book>(); // Очередь книг
            foreach (Book book in table_books)
                books.Enqueue(book);

            Book bb = books.Peek();
            msgs.Add($"Получаем первый елемент, ьез его извлечения: {bb.Title} {bb.Age_Release} {bb.Id_Author} {bb.Id_Genre}");

            msgs.Add($"Сейчас в очереди - {books.Count}");

            foreach (Book bQueue in books)
                msgs.Add($"{bQueue.Title} {bQueue.Age_Release} {bQueue.Id_Author} {bQueue.Id_Genre}");

            // Извлекаем первый елемент из очереди:
            Book firstQueue = books.Dequeue();

            msgs.Add($"Первый елемент очереди книг: {firstQueue.Title} {firstQueue.Age_Release} {firstQueue.Id_Author} {firstQueue.Id_Genre}");

            return msgs;
        }

        //public List<string> MessagesAuthor(List<Author> table_books)
        //{
        //    List<string> msgs = new List<string>();

        //    Queue<int> numbers = new Queue<int>();

        //    numbers.Enqueue(3); // очередь 3
        //    numbers.Enqueue(5); // очередь 3, 5
        //    numbers.Enqueue(8); // очередь 3, 5, 8

        //    // получаем первый элемент очереди
        //    int queueElement = numbers.Dequeue(); //теперь очередь 5, 8

        //    Queue<Book> books = new Queue<Book>(); // Очередь книг
        //    //foreach (Author book in table_books)
        //    //    books.Enqueue(book);

        //    Book bb = books.Peek();
        //    msgs.Add($"{bb.Title} {bb.Age_Release} {bb.Id_Author} {bb.Id_Genre}");

        //    msgs.Add($"Сейчас в очереди - {books.Count}");

        //    foreach (Book bQueue in books)
        //        msgs.Add($"{bQueue.Title} {bQueue.Age_Release} {bQueue.Id_Author} {bQueue.Id_Genre}");

        //    // Извлекаем первый елемент из очереди:
        //    Book firstQueue = books.Dequeue();

        //    msgs.Add($"Первый елемент очереди книг: {firstQueue.Title} {firstQueue.Age_Release} {firstQueue.Id_Author} {firstQueue.Id_Genre}");

        //    return msgs;
        //}
    }
}
