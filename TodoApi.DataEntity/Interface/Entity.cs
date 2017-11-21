using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.DataEntity.Interface
{
    public abstract class Entity : IEntity
    {
        public long Id { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
