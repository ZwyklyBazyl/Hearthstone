using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRandomizer
{
    [SerializeField] private ScriptableCardResources resources;

    public CardParameters GenerateCardParameters()
    {
        CardParameters parameters = new CardParameters();

        int random = Random.Range(0, resources.names.Length);
        parameters.cardName = resources.names[random];

        random = Random.Range(0, resources.descriptions.Length);
        parameters.cardDescription = resources.descriptions[random];

        random = Random.Range(0, resources.images.Length);
        parameters.cardSprite = resources.images[random];

        return parameters;
    }
}
