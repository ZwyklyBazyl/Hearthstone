using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffects : MonoBehaviour
{
    public Effect[] effects;

    public void Use()
    {
        foreach (var e in effects)
        {
            e.Use();
        }
    }
}
