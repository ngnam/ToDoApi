using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.DataEntity.Interface
{
    public interface IValidDateEntity
    {
        DateTime? DateCreated { get; set; }
        DateTime? DateUpdated { get; set; }
        DateTime? DateDeleted { get; set; }
        bool Status { get; set; }
    }
}
