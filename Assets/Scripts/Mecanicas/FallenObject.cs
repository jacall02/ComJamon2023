using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collision2D collision)
    {
        //si el objeto que choca el collider es un destornillador
        if(collision.gameObject.tag == "Destornillador")
        {
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;

        }
    }
}
