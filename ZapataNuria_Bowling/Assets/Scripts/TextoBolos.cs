using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoBolos : MonoBehaviour
{
    public static float boloscaidos;
    [SerializeField] Text ContadorBolos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ContadorBolos.text = "Bolos derribados: " + boloscaidos;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bolo")
        {
            boloscaidos++;
        }
    }
}
