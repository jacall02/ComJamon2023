using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    protected DesactivadorBotones desactivador;
    protected IDFinales ID = 0;

    void Start()
    {
        desactivador = GameObject.FindObjectOfType<DesactivadorBotones>();
    }
    public virtual void PasswordAccepted() { }

    public virtual void ActivateFinal() { }
}
