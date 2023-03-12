using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalProfesor : Final
{
    [SerializeField] Password password;
    [SerializeField] GameObject cartel;
    [SerializeField] GameObject tornillo;

    private void Awake()
    {
        ID = IDFinales.Profesores;
        password.AttachFinalColores(this);
        password.SetPassword2("DACA");
    }
    public override void PasswordAccepted()
    {
        // la contraseña es correcta y se acepta el final
        // quitar panel pantalla
        cartel.GetComponent<QuitarImagen>().MoveImage();
        tornillo.GetComponent<BoxCollider2D>().enabled = true;
        //desactivador.ActivarNota(ID);
    }


}
