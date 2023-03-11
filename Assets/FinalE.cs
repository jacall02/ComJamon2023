using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalE : MonoBehaviour
{

    //numero de veces que se ha pulsdo E
    private int nE;

    //limite de veces que hay que pulsar E para final que suene musica
    [SerializeField]
    private int limitesE;

    public int EPressed { get { return nE; } }

    private SoundManager soundManager;

    public void PulsarE()
    {
        //musica soundManager
        soundManager.SeleccionAudio(0, 1f);
        //efecto
        nE++;
        Debug.Log("Veces pulsadas E: " + nE);

        //comprobacion de si hemos pulsado E suficientes veces
        if (EPressed >= limitesE)
        {
            //suena musica
            soundManager.SeleccionAudio(1, 1f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameManager.instance.GetSoundManager;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
