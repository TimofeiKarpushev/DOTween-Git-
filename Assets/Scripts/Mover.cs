using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _xVector;
    [SerializeField] private float _yVector;
    [SerializeField] private float _zVector;

    private float _duration = 15;

    void Start()
    {
        transform.DOMove(new Vector3(_xVector, _yVector, _zVector), _duration);
    }
}
