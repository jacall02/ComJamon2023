using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPlagio : Final
{
    [SerializeField] Password password;
    [SerializeField] GameObject movil;

    [SerializeField] GameObject screenPlagio;

    [SerializeField]
    private GameObject volumneEffectMOT;

    private void Awake()
    {
        ID = IDFinales.Plagio;
        password.AttachFinal(this);
        password.SetPassword("426781098");
    }

    public override void PasswordAccepted()
    {
        MostrarMovil();
    }

    public void MostrarMovil()
    {
        movil.transform.DOLocalMoveY(1.38f, 1.5f).SetEase(Ease.OutSine);
    }

    public override void ActivateFinal()
    {
        //screen plagio
        screenPlagio.SetActive(true);
        desactivador.ActivarNota(ID);
        volumneEffectMOT.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);

    }

}
