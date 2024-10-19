using System;
using System.Collections.Generic;
namespace CompositeDemo
{
    internal abstract class Equipment
    {
        public int Durability { get; protected set; }
        
        public abstract void WornOut(int _damage);
        public abstract void Fix();
    }
}
