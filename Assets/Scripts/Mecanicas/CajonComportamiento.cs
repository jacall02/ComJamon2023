using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajonComportamiento : MonoBehaviour
{


    private bool cajonAbierto = true;

    [SerializeField]
    private Animator animatorCajonDestornillador;

    public void AbrirCajon()
    {
        if (cajonAbierto)
        {
            animatorCajonDestornillador.SetBool("abrir", true);
            cajonAbierto = false;

        }
    }

    public void CerrarCajon()
    {
        if (!cajonAbierto)
        {
            animatorCajonDestornillador.SetBool("abrir", true);
            cajonAbierto = false;
        }
    }


}
