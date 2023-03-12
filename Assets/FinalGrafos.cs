using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGrafos : Final
{
    [SerializeField] Password password;

    void Awake()
    {
        ID = IDFinales.Bombardeo;
        password.AttachFinal(this);
        password.SetPassword("ADBC");
    }
    public override void PasswordAccepted()
    {
        // la contraseña es correcta y se acepta el final
        desactivador.ActivarNota(ID);
    }
}
