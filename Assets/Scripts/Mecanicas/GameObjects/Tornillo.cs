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

        if (Input.GetMouseButton(0))
        {
            if (collision.gameObject.tag == "Destornillador")
            {
                this.GetComponent<FallenObject>().Fall();
                this.GetComponentInParent<Rejilla>().RestarTornillo();
            }
        }
        //si el objeto que choca el collider es un destornillador
            
    }
}
