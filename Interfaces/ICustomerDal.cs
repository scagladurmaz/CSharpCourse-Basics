﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Dal = Data Access Layer.Yani Crud işlemlerini bu dal sınıfında yaparık.
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class MySQLCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySQL Updated");
        }
    }

    class CustomerManagaer
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

}

