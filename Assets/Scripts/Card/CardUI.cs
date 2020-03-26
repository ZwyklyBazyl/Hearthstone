using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    [SerializeField] private Card card;

    [SerializeField] private Text cardName;
    [SerializeField] private Text cardDescription;
    [SerializeField] private Image cardImage;

    private void Awake()
    {
        card.OnParametersChangeDo += UpdateUI;
    }

    private void UpdateUI(CardParameters parameters)
    {
        cardName.text = parameters.cardName;
        cardDescription.text = parameters.cardDescription;
        cardImage.sprite = parameters.cardSprite;
    }
}
