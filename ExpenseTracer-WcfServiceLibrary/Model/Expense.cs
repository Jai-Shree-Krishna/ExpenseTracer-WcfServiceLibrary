using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracer_WcfServiceLibrary.Model
{
	[DataContract]
	public class Expense
    {
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public float Amount { get; set; }

		[DataMember]
		public DateTime Date { get; set; }

		[DataMember]
		public string Description { get; set; }

		[DataMember]
		public string PaymentMethod { get; set; }

		[DataMember]
		public int UserId { get; set; }

		[DataMember]
		public int CategoryId { get; set; }
    }
}

/*
CREATE TABLE [dbo].[Expense]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Amount] FLOAT NOT NULL,
	[Date] DATETIME NOT NULL,
	[Description] NCHAR(50) NULL,
	[PaymentMethod] NCHAR(50) NULL,

	[UserId] INT NOT NULL,
	[CategoryId] INT NOT NULL,
	
	CONSTRAINT [FK_UserExpenseID] FOREIGN KEY ([UserId]) REFERENCES [User]([Id]),
	CONSTRAINT [FK_CategoryExpenseID] FOREIGN KEY ([CategoryId]) REFERENCES [Category]([CategoryId])
)
*/