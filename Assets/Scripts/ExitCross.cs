using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCross : Final
{
    [SerializeField]
    private GameObject gO;

    [SerializeField]
    private GameObject volumneEffectDV;

    private void Awake()
    {
        ID = IDFinales.ClickLol;
    }

    public void DisableScreen()
    {   
        gO.SetActive(false);
        SoundManager.instance.PlayEffect(24, 1f);
        volumneEffectDV.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
        desactivador.ActivarNota(ID);
    }
}
