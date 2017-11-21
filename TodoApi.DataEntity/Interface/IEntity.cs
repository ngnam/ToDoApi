using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.DataEntity.Interface
{
    public interface IEntity : IObjectWithLong
    {
        byte[] RowVersion { get; set; }        
    }
}
