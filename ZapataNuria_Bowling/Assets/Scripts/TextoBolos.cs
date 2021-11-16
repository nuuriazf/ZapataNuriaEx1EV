using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoBolos : MonoBehaviour
{
    [SerializeField] Text ContadorBolos;
    // Start is called before the first frame update
    void Start()
    {
        ContadorBolos.text = "Bolos derribados: " + GameManager.boloscaidos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
