using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CartaNContenedor : DropListener
{
    private Vector3 cardInitPos= Vector3.zero;

    [SerializeField] public GameObject panel;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "CartaN")
        {
            DragAndDrop dG = collision.gameObject.GetComponent<DragAndDrop>();
            if(dG != null)
            {
                //Guardamos de donde viene la carta
                cardInitPos= dG.GetInitPos();
                //Informamos que se quede aquí cuando la suelte
                dG.SetInitPos(this.transform.position);
                dG.SetListener(this);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CartaN")
        {
            DragAndDrop dG = collision.gameObject.GetComponent<DragAndDrop>();
            if (dG != null)
            {
                //Informamos que se quede aquí cuando la suelte
                dG.SetInitPos(cardInitPos);
            }
        }
    }

    public override void OnDrop(DragAndDrop dG)
    {
        if(dG.gameObject.tag == "CartaN" && dG.GetInitPos() == this.transform.position)
        {
            dG.enabled= false;
            //Llamar función carta
            panel.SetActive(true);

        }
    }
}
