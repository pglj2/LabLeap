using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal2 : MonoBehaviour
{

    public AudioSource other;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision.gameObject.tag "+collision.gameObject.tag);
        Debug.Log("collision.gameObject.name " + collision.gameObject.name);
        if (collision.gameObject.tag == "bola" || collision.gameObject.name == "bola")
            other.Play();
    }
}
