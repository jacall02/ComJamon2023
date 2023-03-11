using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionAlerta : MonoBehaviour
{
    [SerializeField] CanvasGroup myCanvas;
    [SerializeField] GameObject pantallaOcultar;
    [SerializeField] GameObject pantallaMostrar;

    void Start()
    {
        myCanvas.DOFade(0.75f, 1.0f).SetLoops(-1, LoopType.Yoyo);
        pantallaOcultar.SetActive(false);
        pantallaMostrar.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
