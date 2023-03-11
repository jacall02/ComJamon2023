using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCross : Final
{
    [SerializeField]
    private GameObject gO;

    private void Awake()
    {
        ID = IDFinales.ClickLol;
    }

    public void DisableScreen()
    {   
        gO.SetActive(false);
        desactivador.ActivarNota(ID);
    }
}
