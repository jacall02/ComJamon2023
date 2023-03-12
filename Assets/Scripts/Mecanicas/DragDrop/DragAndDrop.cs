using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool selected;

    private Vector3 initPos;

    public bool returnToInitAfterDrop = false;

    DropListener dListener;

    // Update is called once per frame
    void Update()
    {
        //comprobacion de permiso
        if (selected == true)
        {
            //coordenadas del raton
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //posicion del objeto sigue las coordenadas del raton todo el rato
            transform.position = new Vector3(cursorPos.x, cursorPos.y,-5);
        }

        if (selected && Input.GetMouseButtonUp(0))
        {
            Drop();
        }
    }
    //cuando el cursor esta encima lo detecta
    void OnMouseOver()
    {
        //si se hace click izq
        if(!selected && Input.GetMouseButtonDown(0))
        {
            //permitimos seleccion
            selected = true;
            initPos = this.transform.position;
        }
    }


    public void SetInitPos(Vector3 pos)
    {
        initPos = pos;
    }

    public Vector3 GetInitPos()
    {
        return initPos;
    }


    public void Drop()
    {
        // no permitimos seleccion
        selected = false;
        //bd
        if (returnToInitAfterDrop)
        {
            this.transform.position = initPos;
        }

        if(dListener != null)
        {
            dListener.OnDrop(this);
            dListener = null;
        }
    }

    public void SetListener(DropListener dL)
    {
        dListener = dL;
    }
}
