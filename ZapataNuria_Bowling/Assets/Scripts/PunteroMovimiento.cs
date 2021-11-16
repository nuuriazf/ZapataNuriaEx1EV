using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunteroMovimiento : MonoBehaviour
    

{
    [SerializeField] GameObject temporizador;
    [SerializeField] GameObject puntero;
    private float tiempo;
    InitGame InitGame; 


    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 15f;
        temporizador = GameObject.Find("InitObject");
        InitGame = temporizador.GetComponent<InitGame>();
    }

    // Update is called once per frame
    void Update()
    {
        Desaparece();
        MoverPuntero();
    }

    void Desaparece()
    {
        tiempo = InitGame.temporizador;
        if (tiempo == 0)
        {
            Destroy(puntero);
        }
    }


    void MoverPuntero()
    {
        if (InitGame.temporizador > 0f)
        {
            float desplX = Input.GetAxis("Horizontal");
            float posX = transform.position.x;
            float limiteX = 5.5f;

            if ((posX < limiteX || desplX < 0f) && (posX > -limiteX || desplX > 0f))
            {
                transform.Translate(Vector3.right * speed * desplX * Time.deltaTime);
            }
        }
    }
}
