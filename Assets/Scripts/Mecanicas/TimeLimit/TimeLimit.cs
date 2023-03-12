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

    [SerializeField] private GameObject humoIzq;
    [SerializeField] private GameObject humoDer;

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
        if (contadorTimeLimit <= 0)
        {
            humoIzq.SetActive(true);
            humoDer.SetActive(true);
        }
        //Debug.Log(contadorTimeLimit);

        if (GameManager.instance.Submits >= 1)
        {
            finalAvailable = false;
        }
    }

    public void TryEnding()
    {
        if (!finalAvailable)
            return;

        if (contadorTimeLimit <= 0)
        {
            //aparece TimeLimit
            TLimit.SetActive(true);
            desactivador.DesactivarTodo();
            desactivador.ActivarNota(ID);
            finalAvailable = false;
        }
    }
}
