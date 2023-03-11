using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableDrag : MonoBehaviour
{
    private bool selected;

    private Vector3 initPos;


    private bool restartPosition = true;

    // Update is called once per frame
    void Update()
    {
        //comprobacion de permiso
        if (selected == true)
        {
            //coordenadas del raton
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //posicion del objeto sigue las coordenadas del raton todo el rato
            transform.position = new Vector3(cursorPos.x, cursorPos.y, -5);
        }

        if (selected && restartPosition)
        {          
            if (Input.GetMouseButtonDown(0))
            {
                // no permitimos seleccion
                selected = false;
                //bd
                this.transform.position = initPos;        
            }
        }
    }
    //cuando el cursor esta encima lo detecta
    void OnMouseOver()
    {
        //si se hace click izq
        if (!selected && Input.GetMouseButtonDown(0))
        {
            //permitimos seleccion
            Invoke("grabObject", 0.1f);
        }
    }

    private void grabObject()
    {
        selected = true;
        initPos = this.transform.position;
    }

    //Determina si hacer click reestablcece la posición del objecto o no
    public void SetRestartPosition(bool b)
    {
        restartPosition = b;
    }
}
