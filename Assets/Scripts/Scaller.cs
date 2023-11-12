using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scaller : MonoBehaviour
{
    [SerializeField] private float _xVector;
    [SerializeField] private float _yVector;
    [SerializeField] private float _zVector;

    private float _duration = 1;

    void Start()
    {
        transform.DOScale(new Vector3(_xVector, _yVector, _zVector), _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
