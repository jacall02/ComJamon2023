using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rejilla : Final
{
    private int nTornillos;

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

        }
    }
}
