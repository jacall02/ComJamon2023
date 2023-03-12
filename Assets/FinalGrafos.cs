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

    [SerializeField]
    private GameObject avion;

    [SerializeField]
    private GameObject pantallaNegra;

    [SerializeField]
    private GameObject X;

    [SerializeField]
    private GameObject textoUsuario;

    [SerializeField]
    private GameObject nombreCpp;

    void Awake()
    {
        ID = IDFinales.Bombardeo;
        password.AttachFinal(this);
        password.SetPassword("ADBC");
    }
    public override void PasswordAccepted()
    {
        SoundManager.instance.PlayEffect(21, 1f);
        X.SetActive(false);
        facultad.SetActive(true);
        avion.SetActive(true);
        textoUsuario.SetActive(false);
        nombreCpp.SetActive(false);
        //efecto volumen MARP
        volumneEffectMARP.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
        // la contraseña es correcta y se acepta el final
        desactivador.ActivarNota(ID);
        avion.GetComponent<Animator>().Play("Avion");
        Invoke("ShowBlackScreen", 3.5f);
    }

    private void ShowBlackScreen()
    {
           pantallaNegra.SetActive(true);
    }
}
