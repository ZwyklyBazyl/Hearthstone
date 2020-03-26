using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Parameter<int> health = new Parameter<int>();
    public Parameter<int> mana = new Parameter<int>();
    public Parameter<int> speed = new Parameter<int>();
}
