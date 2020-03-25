using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    [SerializeField] private Card card;

    private Text cardName;
    private Text cardDescription;
    private Image cardImage;

    private void Awake() {
        
        card.OnGenerateDo += UpdateUI;

    }

    private void UpdateUI(CardParameters parameters)
    {
        cardName.text = parameters.cardName;
        cardDescription.text = parameters.cardDescription;
        cardImage.sprite = parameters.cardSprite;
    }
}
