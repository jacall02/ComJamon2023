using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rejilla : MonoBehaviour
{
    private int nTornillos;

    private void Start()
    {
        nTornillos = GetComponentsInChildren<Tornillo>().Length;
    }
    public void RestarTornillo()
    {
        nTornillos--;
        if (nTornillos == 0)
        {
            GetComponent<FallenObject>().Fall();
        }
    }
}
