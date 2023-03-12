using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPajaros : Final
{
    [SerializeField]
    private GameObject volumneEffectPVLI;

    private void Awake()
    {
        ID = IDFinales.Pajaros;
    }

    public override void ActivateFinal()
    {
        desactivador.ActivarNota(ID);
        volumneEffectPVLI.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
    }
}
