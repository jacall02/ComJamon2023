using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PopUpTween : MonoBehaviour
{
    [SerializeField] private float animationDuration;
    [SerializeField] private Transform myTransform;
    [SerializeField] private Vector3 finalSize;
    [SerializeField] private Ease easeType;
    public Tween PopUp()
    {
        myTransform.localScale = Vector3.zero;
        return myTransform.DOScale(finalSize, animationDuration).SetEase(easeType);
    }
    void Start()
    {
        PopUp();
    }
}
