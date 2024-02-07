using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EXP_RequireComponent : MonoBehaviour
{
    private Rigidbody rigid;

    private void Start() 
    {
        rigid = GetComponent<Rigidbody>();
    }
}

