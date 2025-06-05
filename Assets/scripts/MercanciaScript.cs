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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            //actualizar dinero por compra
            moneyManager.UpdateMoney(-cost);
            Destroy(gameObject);
        }
    }
}
