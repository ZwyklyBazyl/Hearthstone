using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSaver : MonoBehaviour
{
    [SerializeField] private Card card;


    private void Awake()
    {
        card.cardOperations.OnSaveDo += SaveIntoJson;
    }

    public void SaveIntoJson()
    {
        string cardParameters = JsonUtility.ToJson(card.cardParameters);
        string cardEffects = JsonUtility.ToJson(card.cardEffects);
        System.IO.File.WriteAllText(Application.dataPath + "/Saves/card.txt", cardParameters + cardEffects);
    }
}
