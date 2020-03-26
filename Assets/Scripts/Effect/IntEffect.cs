using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class IntEffect : Effect<int>
{
    public override void GetParameter()
    {
        switch (effectParameter)
        {
            case EffectParameter.HP:
                OnUseDo?.Invoke(player.health);
                break;
            case EffectParameter.MP:
                OnUseDo?.Invoke(player.mana);
                break;
            case EffectParameter.SPEED:
                OnUseDo?.Invoke(player.speed);
                break;
        }
    }
}
