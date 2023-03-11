using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalE : Final
{
    //numero de veces que se ha pulsdo E
    private int nE;
    //limite de veces que hay que pulsar E para final que suene musica
    [SerializeField]
    private int limitesE;
    public int EPressed { get { return nE; } }

    void Akawe()
    {
        ID = IDFinales.E;
        nE = 0;
    }

    public void PulsarE()
    {
        //musica soundManager
        SoundManager.instance.SeleccionAudio(0, 1f);
        //efecto
        nE++;
        Debug.Log("Veces pulsadas E: " + nE);

        //comprobacion de si hemos pulsado E suficientes veces
        if (EPressed >= limitesE)
        {
            //suena musica
            SoundManager.instance.SeleccionAudio(1, 1f);
            // final desbloqueado
            GameManager.instance.ConseguirFinal(ID);

            desactivador.DesactivarTodo();
        }
    }
}
