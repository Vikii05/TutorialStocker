using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Counter : MonoBehaviour
{
    public Text textminuscount;


    // Start is called before the first frame update
    void Start()
    {
        textminuscount.text = "Counter: " + Countthing.maxcount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
      

        if (Countthing.currentcount>0)
        {
           Countthing.currentcount--;
        }

        textminuscount.text="Counter: " +Countthing.currentcount;

    }



}
