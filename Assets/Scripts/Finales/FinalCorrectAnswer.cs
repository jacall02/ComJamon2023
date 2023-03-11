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

    [SerializeField]
    private protected float wrongAnswerDuration = 2f;

    void Awake()
    {
        ID = IDFinales.Correct;
       
    }

    public void ComprobacionCorrectAnswer()
    {
        Invoke("CerrarWrongAnswer", 0.1f);

        //musica soundManager
        SoundManager.instance.PlayEffect(0, 1f);

        Debug.Log(GameManager.instance.Submits);
        //comprobacion de si hemos pulsado E suficientes veces
        if (GameManager.instance.Submits >= limiteSubmitsCorrect)
        {
            Invoke("AbrirCorrectAnswer", 0.2f);
            // final desbloqueado

            desactivador.DesactivarTodo();
            desactivador.ActivarNota(ID);
        }
        else
        {
            Invoke("AbrirWrongAnswer", 0.2f);
            //sino se ha pulsado 40 veces
            //Aparece Wrong Answer
        }
    }

    public void CerrarWrongAnswer()
    {
        WrongAnswer.SetActive(false);
    }
    public void AbrirWrongAnswer()
    {
        WrongAnswer.SetActive(true);
    }
    public void AbrirCorrectAnswer()
    {
        CorrectAnswer.SetActive(true);
    }
}
