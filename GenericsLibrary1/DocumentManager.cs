using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLibrary1
{
    public class DocumentManager<T> where T: IDocument
    {
        private readonly Queue<T> documentQueue = new Queue<T>();

        public void AddDocument(T doc)
        {
            lock(this)
            {
                documentQueue.Enqueue(doc);
            }
        }

        public bool IsDocumentAvailable
        {
            get { return documentQueue.Count > 0; }
        }

        public T GetDocument()
        {
            T doc = default(T);
            lock(this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }

        public void DisplayAllDocuments()
        {
            foreach(T doc in documentQueue)
            {
                Console.WriteLine(((IDocument)doc).Title);
            }
        }

    }

    public interface IDocument
    {
        string Title { get; set; }
        string Content { get; set; }
    }

    public class Document : IDocument
    {
        public Document()
        {

        }

        public Document(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }

        public string Title { get; set; }
        public string Content { get; set; }
    }

}
