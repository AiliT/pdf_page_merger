using System;

namespace DAL
{
    public interface ISearchableDocument<TDocument> : IDisposable
    {
        public int GetPageNumberContainingString(string searchString);
        public void CopyPageTo(int pageNumber, TDocument otherDocument);
    }
}
