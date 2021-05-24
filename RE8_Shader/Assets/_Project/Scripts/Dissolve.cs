using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using EasyButtons;
using Object = UnityEngine.Object;

[RequireComponent(typeof(Renderer))]
public class Dissolve : MonoBehaviour
{
    private Material _material;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material; 
    }

    [Button]
    public void AnimateDissolve()
    {
        AnimateTextureSwitch();
        Invoke(nameof(AnimateDissolveFactor), 2f);
    }
    
    void AnimateTextureSwitch()
    {
        _material.DOFloat(1, "_OpacityFactor", 4f).SetEase(Ease.InQuad);
    }

    void AnimateDissolveFactor()
    {
        _material.DOFloat(1, "_DissolveFactor", 4f).SetEase(Ease.InQuad);
    }
}
