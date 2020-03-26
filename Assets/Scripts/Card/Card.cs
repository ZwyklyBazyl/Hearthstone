using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public delegate void OnParametersChangeDelegate(CardParameters parameters);
    public OnParametersChangeDelegate OnParametersChangeDo;

    public PlayerManager playerManager;

    public CardOperations cardOperations;
    public CardEffects cardEffects;

    private CardParameters cardParameters;

    public void SetParameters(CardParameters parameters)
    {
        cardParameters = parameters;
        OnParametersChangeDo?.Invoke(parameters);
    }
}
