using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rejilla : Final
{
    private int nTornillos;

    private ClickableDrag cD;

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
