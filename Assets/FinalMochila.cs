using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.AudioSettings;

public class FinalMochila : Final
{
    [SerializeField] Password password;

    [SerializeField]
    private GameObject volumneEffectMD;

    [SerializeField]
    private GameObject screen;

    [SerializeField]
    private GameObject guillem;
    [SerializeField]
    private GameObject explosion;


    private void Awake()
    {
        ID = IDFinales.RobarMochila;
        password.AttachFinal2(this);
        password.SetPassword2("0301");
    }

    public override void PasswordAccepted()
    {
        ActivateFinal();
    }
    public override void ActivateFinal()
    {
        desactivador.ActivarNota(ID);

        foreach (Transform g in screen.transform)
        {
            g.gameObject.SetActive(false);
        }

        volumneEffectMD.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);

        guillem.transform.DOLocalMoveX(-2.23f, 8.0f).OnComplete(()=>Explota());

    }

    private void Explota()
    {
        explosion.SetActive(true);
        explosion.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        explosion.transform.DOScale(new Vector3(9.8f, 9.9f, 9.8f), 1.5f);
    }
}
