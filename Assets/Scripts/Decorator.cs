using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Decorator : GuineaPig
{
    protected GuineaPig guineaPig;
    public Decorator(GuineaPig guineaPig)
    {
        this.guineaPig = guineaPig;
    }
}
