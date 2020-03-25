using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Effect
{
    public delegate void OnUseDelegate();
    public OnUseDelegate OnUseDo;

    public void Use()
    {
        OnUseDo?.Invoke();
    }

    public void SetValue<T>(double value, Parameter<T> param) where T : struct
    {
        param.SetValue((T)Convert.ChangeType(value, typeof(T)));
    }

    public void ChangeValue<T>(double value, Parameter<T> param) where T : struct
    {
        dynamic v = param.GetValue();
        v = (double)Convert.ChangeType(v, typeof(double));

        param.SetValue(v + value);

    }


}
