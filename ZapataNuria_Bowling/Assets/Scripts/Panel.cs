using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{

    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(panel.activeSelf)
            {
                panel.SetActive(false);
            }
            else
            {
                panel.SetActive(true);
            }
        }
    }
}
