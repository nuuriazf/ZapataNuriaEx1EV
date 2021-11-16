using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    public float temporizador = 4f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cronometro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Cronometro()
    {
        while (temporizador >= 0f)
        {
            yield return new WaitForSeconds(1f);
            temporizador--;
        }

    }
}
