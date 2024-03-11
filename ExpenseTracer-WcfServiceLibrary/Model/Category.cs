using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracer_WcfServiceLibrary.Model
{
    [DataContract]
    class Category
    {
        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        [DataMember]
        public int UserId { get; set; }
    }
}

/*
    CREATE TABLE [dbo].[Category]
    (
        [CategoryId] INT IDENTITY(1,1) PRIMARY KEY,
        [CategoryName] NCHAR(50) NOT NULL,
        [UserId] INT NOT NULL,
        CONSTRAINT [FK_UserId] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
    )
*/