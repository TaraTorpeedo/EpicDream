using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerr : MonoBehaviour
{
    public Transform PlayerTransform; //Pelaaja jota kameraa seuraa

    public float smoothing = 5f; //Kameran nopeus

    Vector3 offset; //Offset pelaajasta

    // Start is called before the first frame update
    void Start()
    {
        //Laskee offsetin
        offset = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetCamPos = PlayerTransform.position + offset;
        transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
