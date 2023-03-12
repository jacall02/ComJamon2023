using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorMusicAleatorio : MonoBehaviour
{
    [SerializeField]
    private float contadorCambioMusica = 5f;

    [SerializeField]
    private  int posibilidadMusicaMiedo = 2;

    private void Start()
    {
        InvokeRepeating("MusicaAleatoria", 5f,contadorCambioMusica);
    }

    public void MusicaAleatoria()
    {
        if(Random.Range(0,10)<= posibilidadMusicaMiedo)
        {

            int i = Random.Range(7, 17);
            SoundManager.instance.PlayEffect(i, 1f);
        }
    }
}
