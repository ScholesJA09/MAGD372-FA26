using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cube : MonoBehaviour, IPooledObject
{
    public float upForce = 1f;
    public float sideForce = .1f;
    public bool useRandomColor = true;

    public void OnObjectSpawn()
    //void Start()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().linearVelocity = force;

        if(useRandomColor == true)
        {
            Color col = new Color(Random.value, Random.value, Random.value);
            GetComponent<Renderer>().material.color = col;
        }
    }
}