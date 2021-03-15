using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class buttonGlow : MonoBehaviour
{
    MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Behaviour halo = (Behaviour)GetComponent("Halo");

        halo.enabled = true; // false
    }
}
