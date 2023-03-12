using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirParticula : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Invoke("Destruirme", 0.8f);
    }

    private void Destruirme()
    {
        Destroy(gameObject);
    }
}
