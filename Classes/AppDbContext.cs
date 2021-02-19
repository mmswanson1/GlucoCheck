﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlucoCheck.Classes
{
    internal class AppDbContext : DbContext
    {
        #region Properties

        public static readonly string DbFilePath;
        #endregion

        #region Constructors

        static AppDbContext()
        {
            DbFilePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\GlucoCheck.db";
        }

        public AppDbContext() : base(new SQLiteConnection($"DATA Source={DbFilePath}"), false)
        {
        }

        public AppDbContext(DbConnection connection) : base(connection, true)
        {
        }

        public DbSet<LogEntry> log { get; set; }
        #endregion
    }
}