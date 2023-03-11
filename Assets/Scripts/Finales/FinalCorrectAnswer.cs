using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCorrectAnswer : Final
{
    private int limiteSubmitsCorrect = 40;

    [SerializeField]
    private GameObject CorrectAnswer;

    void Awake()
    {
        ID = IDFinales.Correct;
       
    }

    public void ComprobacionCorrectAnswer()
    {
        //musica soundManager
        SoundManager.instance.PlayEffect(0, 1f);

        Debug.Log(GameManager.instance.Submits);
        //comprobacion de si hemos pulsado E suficientes veces
        if (GameManager.instance.Submits >= limiteSubmitsCorrect)
        {
            CorrectAnswer.SetActive(true);
            // final desbloqueado

            desactivador.DesactivarTodo();
            desactivador.ActivarNota(ID);
        }
    }
}
