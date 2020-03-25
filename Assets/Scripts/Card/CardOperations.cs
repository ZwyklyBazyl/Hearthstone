using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardOperations
{

    public delegate void OnSaveDelegate();
    public OnSaveDelegate OnSaveDo;

    public delegate void OnGenerateDelegate();
    public OnGenerateDelegate OnGenerateDo;

    public delegate void OnUseDelegate();
    public OnUseDelegate OnUseDo;

    public void Save()
    {
        OnSaveDo?.Invoke();
    }

    public void Generate()
    {
        OnGenerateDo?.Invoke();
    }

    public void Use()
    {
        OnUseDo?.Invoke();
    }

}
