using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGrafos : Final
{
    [SerializeField] Password password;

    [SerializeField]
    private GameObject volumneEffectMARP;

    [SerializeField]
    private GameObject facultad;

    void Awake()
    {
        ID = IDFinales.Bombardeo;
        password.AttachFinal(this);
        password.SetPassword("ADBC");
    }
    public override void PasswordAccepted()
    {
        SoundManager.instance.PlayEffect(21, 1f);
        facultad.SetActive(true);
        //efecto volumen MARP
        volumneEffectMARP.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
        // la contraseña es correcta y se acepta el final
        desactivador.ActivarNota(ID);
    }
}
