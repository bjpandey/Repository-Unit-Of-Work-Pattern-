using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Web;
using WebApplication1.Models.Infrastructure;

namespace WebApplication1.Models
{

    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope _transaction;
        private readonly BroadwayDBBEntities2 _db;


        public UnitOfWork()
        {
            _db = new BroadwayDBBEntities2();

        }

        public void Dispose()
        {

        }

        public void StartTransaction()
        {

            _transaction = new TransactionScope();





        }

        public void Commit()
        {
            _db.SaveChanges();
            _transaction.Complete();
        }

        public DbContext Db
        {
            get { return _db; }
        }



    }
}