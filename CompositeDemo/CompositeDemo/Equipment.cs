using System;
using System.Collections.Generic;
namespace CompositeDemo
{
    internal abstract class Equipment
    {   
        public abstract void WornOut(int _damage);
        public abstract void Fix();
    }
}
