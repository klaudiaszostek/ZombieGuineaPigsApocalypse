using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CoinDecorator : Decorator
{ 
    public CoinDecorator(GuineaPig guineaPig) : base(guineaPig)
    {
        Coins += 50;
    }
}
