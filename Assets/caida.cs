using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caida : MonoBehaviour
{
    private Rigidbody rb;
    private bool activado = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Físicamente inactivo al inicio
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!activado)
        {
            rb.isKinematic = false; // Se activa cuando choca
            activado = true;
        }
    }

    void Update()
    {
        // si querés hacer algo frame a frame, va acá
    }
}
