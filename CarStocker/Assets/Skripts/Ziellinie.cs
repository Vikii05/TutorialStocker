using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ziellinie : MonoBehaviour
{
    public Text txtBestTime;
    public Text counters;
    float time = 0;
    float besttime = float.MaxValue;

  
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Countthing.currentcount = Countthing.maxcount;
        counters.text= "Counter: " + Countthing.currentcount;
        
        if (time<besttime)
        {
            besttime = time;
            txtBestTime.text = "Best Time: " + besttime.ToString("0.##") + " Sekunden";
        }

        time = 0;
    
    }


}

public static class Countthing
{
    public static int maxcount = 3;
    public static int currentcount;

}