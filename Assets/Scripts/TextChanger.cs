using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    private float _duration = 3;

    void Start()
    {
        _text.DOText("Текст успешно заменен", _duration);
        _text2.DOText("Привет", _duration).SetRelative();
        _text3.DOText("Текст взломан", _duration, true ,ScrambleMode.All);
    }
}
