using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajonComportamiento : MonoBehaviour
{


    private bool cajonAbierto = true;

    [SerializeField]
    private Animator animatorCajonDestornillador;

    [SerializeField]
    private Collider2D destornillador;

    [SerializeField]
    private Collider2D carta;

    private void Start()
    {
        destornillador.enabled = false;
        carta.enabled= false;
    }

    public void AbrirCajon()
    {
        if (cajonAbierto)
        {
            animatorCajonDestornillador.SetBool("abrir", true);
            Invoke("SetUpObjects", 0.3f);
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

    private void SetUpObjects()
    {
        cajonAbierto = false;
        destornillador.enabled = true;
        carta.enabled = true;
    }

}
