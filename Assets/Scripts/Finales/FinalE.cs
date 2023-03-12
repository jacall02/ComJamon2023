using DG.Tweening;
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

    [SerializeField]
    private GameObject volumneEffectMus;
    public int EPressed { get { return nE; } }

    void Awake()
    {
        ID = IDFinales.E;
        nE = 0;
    }

    public void PulsarE()
    {
        //musica soundManager
        SoundManager.instance.PlayEffect(3, 1f);
        //efecto
        nE++;
        Debug.Log("Veces pulsadas E: " + nE);

        //comprobacion de si hemos pulsado E suficientes veces
        if (EPressed >= limitesE)
        {
            //suena musica
            SoundManager.instance.PlayMusic(1, 1f);

            //efecto camara trasladando el volume MUS con animacion de 2 segundos
            volumneEffectMus.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
            // final desbloqueado
            desactivador.ActivarNota(ID);
        }
    }
}
