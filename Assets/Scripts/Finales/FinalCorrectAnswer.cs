using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCorrectAnswer : Final
{
    private int limiteSubmitsCorrect = 40;

    [SerializeField]
    private GameObject PantallaNegra;

    [SerializeField]
    private GameObject CorrectAnswer;

    [SerializeField]
    private GameObject WrongAnswer;

    [SerializeField]
    private protected float wrongAnswerDuration = 2f;

    [SerializeField]
    private GameObject volumneEffectTPV;

    bool finalAvailable;

    void Awake()
    {
        ID = IDFinales.Correct;
        finalAvailable = true;
    }

    public void ComprobacionCorrectAnswer()
    {
        if(!finalAvailable)
        {
            return;
        }
        Invoke("CerrarWrongAnswer", 0.1f);

        //musica soundManager
        SoundManager.instance.PlayEffect(0, 1f);

        Debug.Log(GameManager.instance.Submits);
        //comprobacion de si hemos pulsado E suficientes veces
        if (GameManager.instance.Submits >= limiteSubmitsCorrect)
        {
            Invoke("AbrirCorrectAnswer", 0.2f);

            //aplicamos efecto de volumen
            volumneEffectTPV.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
            // final desbloqueado
            desactivador.DesactivarTodo();
            desactivador.ActivarNota(ID);
            CerrarWrongAnswer();
            finalAvailable = false;
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
        if (!finalAvailable)
            return;
        WrongAnswer.SetActive(true);
    }
    public void AbrirCorrectAnswer()
    {
        CorrectAnswer.SetActive(true);
        PantallaNegra.SetActive(true);
    }

    public void SetFinalNotAvaileble()
    {
        CerrarWrongAnswer();
        finalAvailable = false;
    }
}
