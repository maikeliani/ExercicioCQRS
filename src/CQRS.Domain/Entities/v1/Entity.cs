﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using CQRS.Domain.Contracts.v1;

namespace CQRS.Domain.Entities.v1
{
    public class Entity : IEntity
    {
        protected Entity(Guid id, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        protected Entity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public bool Equals(IEntity? other)
        {
            if (other is null) return false;
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
