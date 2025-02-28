using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    // Library Management System
    public class Library
    {
        private List<ILibraryObserver> users = new List<ILibraryObserver>();
        private IFeeCalculationStrategy feeStrategy;
        private Dictionary<string, IDocument> documents = new Dictionary<string, IDocument>();
        private Dictionary<string, string> loans = new Dictionary<string, string>(); // key=documentId -> val=userId

        public Library(IFeeCalculationStrategy feeStrategy)
        {
            this.feeStrategy = feeStrategy;
        }

        public void RegisterObserver(ILibraryObserver observer)
        {
            users.Add(observer);
        }

        public void AddDocument(IDocument document)
        {
            documents[document.Id] = document;
            NotifyObservers($"New document added: {document.Title}");
        }

        public void BorrowDocument(string documentId, User user)
        {
            if (documents.ContainsKey(documentId) && !loans.ContainsKey(documentId))
            {
                loans[documentId] = user.Id;
                NotifyObservers($"Document borrowed: {documents[documentId].Title}");
            }
        }

        public double ReturnDocument(string documentId, int days)
        {
            if (loans.ContainsKey(documentId))
            {
                IDocument doc = documents[documentId];
                double fee = feeStrategy.CalculateFee(doc, days);
                loans.Remove(documentId);
                NotifyObservers($"Document returned: {doc.Title}");
                return fee;
            }
            return 0.0;
        }

        private void NotifyObservers(string message)
        {
            foreach (var observer in users)
            {
                observer.Update(message);
            }
        }
    }
}
