using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject kek;
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        _animator.SetTrigger("Click");
        var lol = transform.position;
        Manager.instance.scores++;
        Instantiate(kek, new Vector3(lol.x , lol.y - 2, lol.z), Quaternion.identity);
    }
}
