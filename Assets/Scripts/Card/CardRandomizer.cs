using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRandomizer : MonoBehaviour
{
    [SerializeField] private Card card;
    [SerializeField] private ScriptableCardResources resources;

    private void Awake()
    {
        card.cardOperations.OnGenerateDo += () => GenerateCardParameters();
    }

    public void GenerateCardParameters()
    {
        CardParameters parameters = new CardParameters();

        int random = Random.Range(0, resources.names.Length);
        parameters.cardName = resources.names[random];

        random = Random.Range(0, resources.descriptions.Length);
        parameters.cardDescription = resources.descriptions[random];

        random = Random.Range(0, resources.images.Length);
        parameters.cardSprite = resources.images[random];

        card.SetParameters(parameters);
    }
}
