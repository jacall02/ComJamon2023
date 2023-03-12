using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rejilla : Final
{
    private int nTornillos;

    private ClickableDrag cD;

    [SerializeField]
    private GameObject volumneEffectPVLI;
    private void Awake()
    {
        ID = IDFinales.Pajaros;
        nTornillos = GetComponentsInChildren<Tornillo>().Length;
    }

    public void RestarTornillo()
    {
        nTornillos--;
        if (nTornillos == 0)
        {
            GetComponent<FallenObject>().Fall();
            volumneEffectPVLI.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
            desactivador.ActivarNota(IDFinales.Pajaros);
            cD.ResetPosition();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (cD == null) { 
            cD = collision.GetComponent<ClickableDrag>();
        }
    }
}
