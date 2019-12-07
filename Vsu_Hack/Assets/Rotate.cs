using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Vector3 q;
    public float speed;
    void Start()
    {
        q = transform.rotation.eulerAngles;
    }

    void Update()
    {
        q.y += speed;
        transform.rotation = Quaternion.Euler(q);
    }
}
