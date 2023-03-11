using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornillo : MonoBehaviour
{
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    //si el objeto que choca el collider es un destornillador
    //    if (collision.gameObject.tag == "Destornillador")
    //    {
    //        this.GetComponent<FallenObject>().Fall();
    //    }
    //}

    private bool tornilloQuitado;
    private void Start()
    {
        tornilloQuitado= false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destornillador")
        {
            collision.GetComponent<ClickableDrag>().SetRestartPosition(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destornillador")
        {
            collision.GetComponent<ClickableDrag>().SetRestartPosition(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (tornilloQuitado)
            return;
        if (Input.GetMouseButton(0))
        {
            if (collision.gameObject.tag == "Destornillador")
            {
                this.GetComponent<FallenObject>().Fall();
                Invoke("AvisaRejilla", 0.2f);
                tornilloQuitado = true;
            }
        }
        //si el objeto que choca el collider es un destornillador
            
    }

    private void AvisaRejilla()
    {
        this.GetComponentInParent<Rejilla>().RestarTornillo();
    }
}
