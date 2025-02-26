using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FoodDecorator : Decorator
{
    public FoodDecorator(GuineaPig guineaPig) : base(guineaPig)
    {
        HP += 10;
    }
}
