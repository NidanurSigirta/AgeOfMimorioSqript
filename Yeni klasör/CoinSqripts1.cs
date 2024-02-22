using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSqripts : MonoBehaviour
{

    Text text;
    public static int coin;
   
    void Start()
    {
       text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text=coin.ToString();
    }
}
