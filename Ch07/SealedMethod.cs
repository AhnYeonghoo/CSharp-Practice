using System;

class Base
{
    public virtual void SealMe()
    {

    }
}

class Derived : Base
{
    public sealed override void SealMe()
    {
        
    }
}

