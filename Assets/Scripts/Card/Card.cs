using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public delegate void OnGenerateDelegate(CardParameters parameters);
    public OnGenerateDelegate OnGenerateDo;

    public PlayerManager playerManager;

    private CardParameters cardParameters;
}
