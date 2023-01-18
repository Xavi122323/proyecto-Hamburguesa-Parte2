﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XR_EjercicioHamburguesa.Models;

namespace XR_EjercicioHamburguesa.Data
{
    public class XRBurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public XRBurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Burger>();
        }

        public int AddNewBurger(Burger burger)
        {
            Init();
            if (burger.Id != 0)
            {
                return conn.Update(burger);
            }
            else
            {
                return conn.Insert(burger);
            }
        }

        public List<Burger> GetAllBurgers()
        {
            Init();
            List<Burger> burgers = conn.Table<Burger>().ToList();
            return burgers;
        }

        public int DeleteBurger(Burger burger)
        {
            Init();
            return conn.Delete(burger);
        }
    }
}
