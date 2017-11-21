using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.DataEntity.Interface
{
    public interface IEntityGuid : IObjectWithGuid
    {
        byte[] RowVersion { get; set; }
    }
}
