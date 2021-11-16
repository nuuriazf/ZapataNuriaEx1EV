using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaMovimiento : MonoBehaviour
{

    [SerializeField] float fuerza;
    Rigidbody rbBola;
    [SerializeField] Transform puntero;
    InitGame initGame;
    Vector3 InitPos;
    bool lanzar;
    GameObject punteroobjeto;
    

    // Start is called before the first frame update
    void Start()
    {
        rbBola = GetComponent<Rigidbody>();
        fuerza = 1000f;
        lanzar = false;

        InitPos = transform.position;
        transform.position = (InitPos);
        punteroobjeto = GameObject.Find("Puntero");
        
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
            rbBola.AddForce(transform.forward * fuerza);
            lanzar = true;
            Destroy(punteroobjeto);

            rbBola.velocity = Vector3.zero;
            rbBola.angularVelocity = Vector3.zero;
        }
    }


        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Bolo")
            {
                TextoBolos.boloscaidos++;
            }
        if (other.gameObject.layer == 6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
   

    /*if (Input.GetKeyDown(KeyCode.Space))
    {
        print("espacio pulsado");
        transform.LookAt(puntero);
        rbBola.AddForce(new Vector3(0f, 0f, fuerza));



    }*/

}

