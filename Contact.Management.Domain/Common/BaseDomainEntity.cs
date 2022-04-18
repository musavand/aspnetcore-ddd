using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Management.Domain.Common
{
    public abstract class BaseDomainEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string? CreateBy { get; set; }
        public DateTime LastModifyDate { get; set; }

        public string? ModifyBy { get; set; }
    }
}
