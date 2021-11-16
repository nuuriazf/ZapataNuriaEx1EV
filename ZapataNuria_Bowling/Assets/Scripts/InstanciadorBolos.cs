using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorBolos : MonoBehaviour
{
    [SerializeField] GameObject bolos;
    int numBolos;

    // Start is called before the first frame update
    void Start()
    {
        CrearBolos();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CrearBolos()
    {
        float ajusteXpos = 0f;

        float ajusteZpos = 0f;

        Vector3 posicion = new Vector3(transform.position.x - ajusteXpos, transform.position.y, transform.position.z - ajusteZpos);

        Instantiate(bolos, posicion, Quaternion.identity);

        numBolos++;

        ajusteZpos--;
        ajusteXpos = -0.5f;

        while (numBolos < 3)
        {


            posicion = new Vector3(transform.position.x + ajusteXpos, transform.position.y, transform.position.z - ajusteZpos);

            Instantiate(bolos, posicion, Quaternion.identity);
            ajusteXpos++;
            numBolos++;

        }

        ajusteXpos = -1f;

        ajusteZpos--;

        while (numBolos < 6)
        {
            posicion = new Vector3(transform.position.x + ajusteXpos, transform.position.y, transform.position.z - ajusteZpos);

            Instantiate(bolos, posicion, Quaternion.identity);
            ajusteXpos++;
            numBolos++;
        }

        ajusteXpos = -1.5f;

        ajusteZpos--;

        while (numBolos < 10)
        {
            posicion = new Vector3(transform.position.x + ajusteXpos, transform.position.y, transform.position.z - ajusteZpos);

            Instantiate(bolos, posicion, Quaternion.identity);
            ajusteXpos++;
            numBolos++;
        }


    }

}