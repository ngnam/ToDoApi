using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.DataEntity.Interface
{
    public interface IObjectWithGuid
    {
        Guid Id { get; set; }
    }
}
