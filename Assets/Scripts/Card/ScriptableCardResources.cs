using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardResources", menuName = "Card/Resources")]
public class ScriptableCardResources : ScriptableObject
{
    public string[] names;
    public string[] descriptions;
    public Sprite[] images;
}
