using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool selected;


    // Update is called once per frame
    void Update()
    {
        //comprobacion de permiso
        if (selected == true)
        {
            //coordenadas del raton
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //posicion del objeto sigue las coordenadas del raton todo el rato
            transform.position = new Vector2(cursorPos.x, cursorPos.y);
        }

        if (Input.GetMouseButtonUp(0))
        {
            // no permitimos seleccion
            selected = false;
        }
    }
    //cuando el cursor esta encima lo detecta
    void OnMouseOver()
     {
        //si se hace click izq
        if(Input.GetMouseButtonDown(0))
        {
            //permitimos seleccion
            selected = true;
        }

       
     } 

   
}
