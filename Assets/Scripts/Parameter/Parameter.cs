using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameter<T> where T : struct
{
    public delegate void OnValueChangeDelegate(T value);
    public OnValueChangeDelegate OnValueChangeDo;

    private T value;

    public T GetValue()
    {
        return value;
    }

    public void SetValue(T value)
    {
        Debug.Log(value);
        this.value = value;
        OnValueChangeDo?.Invoke(value);
    }
}
