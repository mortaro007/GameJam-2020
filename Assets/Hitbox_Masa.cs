using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox_Masa : MonoBehaviour
{
    private bool atinge = false;

    GameObject cube;

    int scor;

    float raza = 1f;

    void Start()
    {
        cube = GameObject.Find("chiloti");
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        atinge = true;
        if (col.gameObject.name == "chiloti")
        {
            if (Physics.CheckSphere(new Vector3(-12.136f, 12.003f, -14.325f), raza))
            {
                cube.transform.position = new Vector3(-11.904f, 11.8858f, -14.4891f);
                cube.GetComponent<Rigidbody>().useGravity = false;
                cube.GetComponent<Rigidbody>().detectCollisions = true;
                cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
                cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            }
            else
            {
                cube.transform.position = new Vector3(-12.136f, 12.003f, -14.325f);
                cube.GetComponent<Rigidbody>().useGravity = false;
                cube.GetComponent<Rigidbody>().detectCollisions = true;
                cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
                cube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            }
        }

    }


}
