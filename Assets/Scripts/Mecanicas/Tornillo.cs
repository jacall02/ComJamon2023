using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornillo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //si el objeto que choca el collider es un destornillador
        if (collision.gameObject.tag == "Destornillador")
        {
            this.GetComponent<FallenObject>().Fall();

        }
    }
}
