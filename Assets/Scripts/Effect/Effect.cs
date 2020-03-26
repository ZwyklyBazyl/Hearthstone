using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class Effect<T> where T : struct
{
    public delegate void OnUseDelegate(Parameter<T> param);
    public OnUseDelegate OnUseDo;

    public double value;
    public EffectParameter effectParameter;
    public EffectOperation operation;
    protected Player player;

    public void SetPlayer(Player p)
    {
        player = p;
    }

    public void Use()
    {
        GetEffect();
        GetParameter();
    }

    public void SetValue(Parameter<T> param)
    {
        param.SetValue((T)Convert.ChangeType(value, typeof(T)));
    }

    public void ChangeValue(Parameter<T> param)
    {
        dynamic v = param.GetValue();
        v = (double)Convert.ChangeType(v, typeof(double));

        param.SetValue(v + value);
    }

    public virtual void GetEffect()
    {

        switch (operation)
        {
            case EffectOperation.CHANGE:
                OnUseDo = ChangeValue;
                break;
            case EffectOperation.SET:
                OnUseDo = SetValue;
                break;
        }
    }


    public virtual void GetParameter()
    {
    }
}

public enum EffectParameter
{
    HP,
    MP,
    SPEED
}

public enum EffectOperation
{
    SET,
    CHANGE
}
