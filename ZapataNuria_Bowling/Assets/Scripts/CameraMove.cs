using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
/*{
    [SerializeField] Transform playerPosition;
    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    void Update()
    {

        transform.position = new Vector3(transform.position.x, transform.position.y, playerPosition.position.z);
        transform.position = new Vector3(playerPosition.position.x, transform.position.y, playerPosition.position.z - 10);
        Vector3 targetPosition = new Vector3(transform.position.x, transform.position.y, playerPosition.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);

        transform.LookAt(playerPosition);
    }
}*/

{
    public GameObject ball;
    // private Vector3 offset;
    [SerializeField] Vector3 distancia;
    public float delay = 0.25f;
    private float followNow;
    public float smoothSpeed = 0.25f;

    void Start()
    {
        followNow = Time.time + delay;
        distancia = new Vector3(0f, 0.94f, -2.49f);
    }

    void Update()
    {
        if (Time.time > followNow)
        {
            if (ball != null)
            {
                Vector3 posicionfinal = ball.transform.position + distancia;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, posicionfinal, smoothSpeed);
                transform.position = smoothedPosition;

                //transform.position = ball.transform.position + distancia;
            }
            followNow += delay;
        }
    }
}
        