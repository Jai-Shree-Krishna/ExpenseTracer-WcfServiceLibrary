using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracer_WcfServiceLibrary.Model
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string EmailId { get; set; }

        [DataMember]
        public string Password { get; set; }

        // Other user-related properties (e.g., email, password)
    }

    /*
       CREATE TABLE [dbo].[User]
        (
	        [Id] INT NOT NULL PRIMARY KEY,
	        [EmailId] NCHAR(50) NOT NULL,
	        [Password] NCHAR(50) NOT NULL,
	        [UserName] NCHAR(50) NOT NULL
        )
    */
}
