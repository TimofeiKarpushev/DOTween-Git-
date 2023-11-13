using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    private float _xVector = 180;
    private float _yVector = 0;
    private float _zVector = 0;

    private float _duration = 1;

    private void Start()
    {
        transform.DORotate(new Vector3(_xVector, _yVector, _zVector), _duration).SetLoops(-1, LoopType.Restart);
    }
}
