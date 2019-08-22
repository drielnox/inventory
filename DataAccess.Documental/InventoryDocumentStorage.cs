using LiteDB;
using SmartInventorySystem.Model;
using System;

namespace DataAccess.Documental
{
    public class InventoryDocumentStorage : IDisposable
    {
        bool disposed = false;
        
        private readonly string _connString;
        private LiteDatabase db;

        public LiteCollection<DispenseSummary> DispenseSummaries => db.GetCollection<DispenseSummary>();

        public InventoryDocumentStorage()
            : this("lite.db")
        {
        }

        public InventoryDocumentStorage(string connString)
        {
            _connString = connString;

            MapEntities();
            Initialize();
        }

        ~InventoryDocumentStorage()
        {
            Dispose(false);
        }

        private void Initialize()
        {
            db = new LiteDatabase(_connString);
        }

        private void MapEntities()
        {
            var mapper = BsonMapper.Global;

            mapper.Entity<DispenseSummary>()
                .Id(x => x.DispenserId);
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                db.Dispose();
            }

            disposed = true;
        }
    }
}
