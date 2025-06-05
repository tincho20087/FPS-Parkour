using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void UpdateMoneyTxt (string moneyamount)
    {
        txtMoney.text = moneyamount;
    }
}
