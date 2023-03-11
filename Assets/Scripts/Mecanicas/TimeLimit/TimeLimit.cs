using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLimit : MonoBehaviour
{
    //creamos contador de x segundos y aparece TimeLimit
    [SerializeField]
    private float contadorTimeLimit = 10;

    //objeto TimeLimit que aparecerá en la pantalla
    [SerializeField]
    private GameObject TLimit;

    private bool finalAvailable;

    private void Start()
    {
        finalAvailable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!finalAvailable)
            return;

        contadorTimeLimit -= Time.deltaTime;
        //Debug.Log(contadorTimeLimit);
        if(contadorTimeLimit<=0)
        {
            //aparece TimeLimit
            TLimit.SetActive(true);
            finalAvailable = false;
        }
        else if(GameManager.instance.Submits != 0)
        {
            finalAvailable= false;
        }
    }
}
