using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rejilla : MonoBehaviour
{
    private int nTornillos;

    private ClickableDrag cD;

    [SerializeField] Final myFinal;

    private void Awake()
    {
        nTornillos = GetComponentsInChildren<Tornillo>().Length;
    }

    public void RestarTornillo()
    {
        nTornillos--;
        if (nTornillos == 0)
        {
            GetComponent<FallenObject>().Fall();
            myFinal.ActivateFinal();
            if (cD != null)
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
