using System;
using System.Data.Entity;

namespace IT.Models
{
    public class RejectionRequests
    {

        public int rejectionID { get; set; }
        public string serialNumber { get; set; }
        public string barcode { get; set; }
        public string serviceTag { get; set; }
        public string businessArea { get; set; }
        public string justification { get; set; }
        public string costCenter { get; set; }
        public DateTime timeStamp { get; set; }

    }

    public class RejectionRequestsDBContext : DbContext
    {
        public DbSet<RejectionRequests> RejectionRequests { get; set; }
    }

}