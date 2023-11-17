using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Renderer))]
public class ColorChager : MonoBehaviour
{
    [SerializeField] private Color _targetColor;

    private Material _material;
    private float _duration = 1f;

    private void Start()
    {
        _material = GetComponent<Renderer>().material;
        _material.DOColor(_targetColor, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
