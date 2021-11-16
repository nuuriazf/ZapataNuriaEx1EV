using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaMovimiento : MonoBehaviour
{

    [SerializeField] float fuerza;
    Rigidbody rbBola;
    [SerializeField] Transform puntero;
    InitGame initGame;
    Vector3 InitPos;
    bool lanzar;
    

    // Start is called before the first frame update
    void Start()
    {
        rbBola = GetComponent<Rigidbody>();
        fuerza = 1000f;
        lanzar = false;

        InitPos = transform.position;
        transform.position = (InitPos);
        
    }

    // Update is called once per frame
    void Update()
    {
        initGame = GameObject.Find("InitObject").GetComponent<InitGame>();
        

     
            EmpujeBola();
      
    }

    //Lanzar la bola con el espacio
    void EmpujeBola()
    {


        if (Input.GetKeyDown(KeyCode.Space) && lanzar == false)
        {
            print("espacio pulsado");
            transform.LookAt(puntero);
            rbBola.AddForce(new Vector3(0, 0, 500f) * fuerza * Time.deltaTime);
            lanzar = true;
        }

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            print("espacio pulsado");
            transform.LookAt(puntero);
            rbBola.AddForce(new Vector3(0f, 0f, fuerza));
          


        }*/

    }
}
