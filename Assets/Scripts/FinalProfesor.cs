using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalProfesor : Final
{
    [SerializeField] Password password;
    [SerializeField] GameObject cartel;
    [SerializeField] GameObject tornillo;

    [SerializeField]
    private GameObject volumneEffectP3;
    [SerializeField]
    private GameObject guille;

    private void Awake()
    {
        ID = IDFinales.Profesores;
        password.AttachFinal2(this);
        password.SetPassword2("DACA");
    }
    public override void PasswordAccepted()
    {
        // la contraseņa es correcta y se acepta el final
        // quitar panel pantalla
        cartel.GetComponent<QuitarImagen>().MoveImage();
        tornillo.GetComponent<BoxCollider2D>().enabled = true;
    }

    public override void ActivateFinal()
    {
        SoundManager.instance.PlayEffect(25, 1f);
        desactivador.ActivarNota(ID);
        guille.SetActive(true); 
        volumneEffectP3.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
    }

}
