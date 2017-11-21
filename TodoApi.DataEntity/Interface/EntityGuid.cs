using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.DataEntity.Interface
{
    public class EntityGuid : IEntityGuid
    {
        public Guid Id { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
