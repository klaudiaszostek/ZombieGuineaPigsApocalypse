using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class CollectibleItem : MonoBehaviour
{
    public abstract float HealthValue{ get; set; }
    public abstract float CoinsValue { get; set;  }
}
