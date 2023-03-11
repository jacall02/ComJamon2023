using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLimit : Final
{
    //creamos contador de x segundos y aparece TimeLimit
    [SerializeField]
    private float contadorTimeLimit = 10;

    //objeto TimeLimit que aparecerá en la pantalla
    [SerializeField]
    private GameObject TLimit;

    private bool finalAvailable;

    private void Awake()
    {
        finalAvailable = true;
        ID = IDFinales.Timelimit;
    }

    // Update is called once per frame
    void Update()
    {
        if (!finalAvailable)
            return;

        contadorTimeLimit -= Time.deltaTime;
        //Debug.Log(contadorTimeLimit);
        if(contadorTimeLimit<=0)
        {
            //aparece TimeLimit
            TLimit.SetActive(true);
            desactivador.DesactivarTodo();
            desactivador.ActivarNota(ID);
            finalAvailable = false;
        }
        else if(GameManager.instance.Submits != 0)
        {
            finalAvailable= false;
        }
    }
}
