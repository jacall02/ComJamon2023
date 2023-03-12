using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsarParticulas : MonoBehaviour
{
    [SerializeField]
    private GameObject particulas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(particulas, new Vector3(cursorPos.x, cursorPos.y, -6.0f), Quaternion.identity);
        }
    }
}
