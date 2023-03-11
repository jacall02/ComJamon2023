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
    //WrongAnswer que se debe desactivar
    [SerializeField]
    private GameObject wrongAnswer;

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

        if (GameManager.instance.Submits > 1)
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
            wrongAnswer.SetActive(false);
            desactivador.DesactivarTodo();
            desactivador.ActivarNota(ID);
            finalAvailable = false;
        }
    }
}
