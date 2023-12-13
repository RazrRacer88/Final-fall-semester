using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    public float speed = 10f;

    private Rigidbody _zombieRb;
    private GameObject _Player;

    // Start is called before the first frame update
    void Start()
    {
        _zombieRb = GetComponent<Rigidbody>();
        _Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 lookDirection = (_Player.transform.position - transform.position).normalized;
        _zombieRb.AddForce(lookDirection * speed);
    }
}
