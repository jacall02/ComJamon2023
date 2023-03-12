using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CppDragTarget : DropListener
{
    [SerializeField] private TextMeshProUGUI text;
    private bool canDrop = false;

    public override void OnDrop(DragAndDrop dG)
    {
        if (canDrop)
        {
            text.text = "solucion.cpp";
            dG.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "cpp")
        {
            DragAndDrop dG = collision.GetComponent<DragAndDrop>();
            if (dG != null)
            {
                canDrop = true;
                dG.SetListener(this);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "cpp")
        {
            canDrop = false;
        }
    }
}
