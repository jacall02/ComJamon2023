using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPajaros : Final
{
    [SerializeField]
    private GameObject volumneEffectPVLI;

    [SerializeField]
    private GameObject negro;

    [SerializeField]
    private GameObject paharo;

    private void Awake()
    {
        ID = IDFinales.Pajaros;
    }

    public override void ActivateFinal()
    {
        //final pajaros fotos
        FotosPajaro();
        desactivador.ActivarNota(ID);
        volumneEffectPVLI.transform.DOLocalMove(new Vector3(1.46f, -0.73f, -8.63f), 2.0f);
    }
    private void FotosPajaro()
    {
        Invoke("PonerNegro", 1f);
        Invoke("QuitarNegro", 4f);

    }

    private void PonerNegro()
    {
        //activar negro durante 2 segundos
        negro.SetActive(true);
        SoundManager.instance.PlayMusic(17, 0.6f);
        Invoke("PajaroChillido", 2.8f);
    }
    private void QuitarNegro()
    {
        negro.SetActive(false);
        //aparece pajaro
        paharo.SetActive(true);
        //alas pajaro
        //pajaro berrido
    }

    private void PajaroChillido()
    {
        SoundManager.instance.PlayMusic(18, 0.4f);
    }
}
