using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameLoadEffect : MonoBehaviour
{
    [SerializeField] private Camera myCamera;
    [SerializeField] private float animationDuration = 1.0f;
    [SerializeField] private float animationDelay = 1.0f;
    private void Start()
    {
        myCamera.GetComponent<Transform>().DOMove(new Vector3(0, 0, -10), animationDuration).SetDelay(animationDelay);
        myCamera.DOOrthoSize(5.0f, animationDuration).SetDelay(animationDelay);
    }
}
