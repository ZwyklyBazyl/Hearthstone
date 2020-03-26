using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffects : MonoBehaviour
{
    public IntEffect effect;
    [SerializeField] private Card card;

    private void Awake()
    {
        card.cardOperations.OnUseDo += Use;
    }

    public void Use()
    {
        effect.Use();
    }
}
