using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{

    public float cost;
    public MoneyManager moneyManager;


    // Start is called before the first frame update
    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    /* void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // Actualizar dinero por la compra
            moneyManager.UpdateMoney(-cost);
            Destroy(gameObject);
        }
    } */
}
