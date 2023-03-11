using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCorrectAnswer : Final
{
    private int limiteSubmitsCorrect = 40;

    [SerializeField]
    private GameObject CorrectAnswer;

    [SerializeField]
    private GameObject WrongAnswer;

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
        else
        {
            //sino se ha pulsado 40 veces
            //Aparece Wrong Answer
            WrongAnswer.SetActive(true);
            Invoke("CerrarWrongAnswer", 0.2f);
        }
    }

    public void CerrarWrongAnswer()
    {
        WrongAnswer.SetActive(false);
    }
}
