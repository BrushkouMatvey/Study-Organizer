﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using code.DataBase;
using code.Interfaces;

namespace code.Helper
{
    class UserDb
    {
        private SQLiteConnection _SQLiteConnection;

        public UserDb()
        {
            _SQLiteConnection = DependencyService.Get<ISQLiteDb>().GetConnection();
            _SQLiteConnection.CreateTable<User>();
        }

        public IEnumerable<User> GetUsers()
        {
            return (from u in _SQLiteConnection.Table<User>()
                    select u).ToList();
        }
        public User GetSpecificUser(int id)
        {
            return _SQLiteConnection.Table<User>().FirstOrDefault(t => t.Id == id);
        }
        public void DeleteUser(int id)
        {
            _SQLiteConnection.Delete<User>(id);
        }
        public string AddUser(User user)
        {
            var data = _SQLiteConnection.Table<User>();
            var d1 = data.Where(x => x.name == user.name && x.userName == user.userName).FirstOrDefault();
            if (d1 == null)
            {
                _SQLiteConnection.Insert(user);
                return "Sucessfully Added";
            }
            else
                return "Already Mail id Exist";
        }
        public bool updateUserValidation(string userid)
        {
            var data = _SQLiteConnection.Table<User>();
            var d1 = (from values in data
                      where values.name == userid
                      select values).Single();
            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }
        public bool updateUser(string username, string pwd)
        {
            var data = _SQLiteConnection.Table<User>();
            var d1 = (from values in data
                      where values.name == username
                      select values).Single();
            if (true)
            {
                d1.password = pwd;
                _SQLiteConnection.Update(d1);
                return true;
            }
            else
                return false;
        }
        public bool LoginValidate(string userName1, string pwd1)
        {
            var data = _SQLiteConnection.Table<User>();
            var d1 = data.Where(x => x.name == userName1 && x.password == pwd1).FirstOrDefault();
            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
