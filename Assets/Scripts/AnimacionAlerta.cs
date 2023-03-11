using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionAlerta : MonoBehaviour
{
    [SerializeField] CanvasGroup myCanvas;

    void Start()
    {
        myCanvas.DOFade(0.75f, 1.0f).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
