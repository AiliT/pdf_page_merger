using System;

namespace DAL
{
    public interface ISearchableDocument<TDocument> : IDisposable
    {
        public int GetPageNumberContainingString(string searchString);
        public bool TryGetPageNumberContainingString(string searchString, out int number);
        public void CopyPageTo(int pageNumber, TDocument otherDocument);
    }
}
