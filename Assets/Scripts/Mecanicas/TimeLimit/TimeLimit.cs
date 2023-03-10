using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLimit : MonoBehaviour
{
    //creamos contador de x segundos y aparece TimeLimit
    private float contadorTimeLimit = 10;

    //objeto TimeLimit que aparecer� en la pantalla
    [SerializeField]
    private GameObject TLimit;

    // Update is called once per frame
    void Update()
    {
        contadorTimeLimit -= Time.deltaTime;
        Debug.Log(contadorTimeLimit);
        if(contadorTimeLimit<=0)
        {
            //aparece TimeLimit
            TLimit.SetActive(true);
        }
    }
}