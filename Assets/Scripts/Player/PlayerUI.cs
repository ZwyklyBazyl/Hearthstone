using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Text hp;
    [SerializeField] private Text mp;
    [SerializeField] private Text speed;

    public void SetUI()
    {
        hp.text = "HP: " + player.health.GetValue();
        mp.text = "MP: " + player.mana.GetValue();
        speed.text = "SPEED: " + player.speed.GetValue();
    }
}
