//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RapidSoft.VTB24.BankConnector.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientPersonalMessage
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public System.Guid SessionId { get; set; }
        public string Message { get; set; }
        public Nullable<System.DateTime> FromDateTime { get; set; }
        public Nullable<System.DateTime> ToDateTime { get; set; }
        public System.DateTime InsertedDate { get; set; }
        public string Title { get; set; }
    }
}
