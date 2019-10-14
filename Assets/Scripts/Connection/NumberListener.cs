using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NumberListener : AndroidJavaProxy
{
    


    // TODO: replace with full Java name for LoginListener interface
    public NumberListener() : base("iti.gr.androidlib.NumberListener")
    {
    }

    public void listen(int num)
    {
        Debug.Log("---> " + num);
        
    }
}
