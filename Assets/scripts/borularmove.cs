using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borularmove : MonoBehaviour
{

    public float hiz;


    private void Start()
    {
        Destroy(gameObject, 5);
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime;
    }
}
