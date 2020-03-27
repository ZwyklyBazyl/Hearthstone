using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffects : MonoBehaviour
{
    public IntEffect[] effects;
    [SerializeField] private Card card;

    private void Awake()
    {
        card.cardOperations.OnUseDo += Use;
    }

    public void Use()
    {
        foreach(var e in effects)
        {
            e.Use();
        }
    }
}
