using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMadeOnZachBranch : MonoBehaviour
{
    // Start is called before the first frame update
    public string Message; 
    void Start()
    {
        Debug.Log("Test debug");
        print("Do{} While(); more like Do{} Wild();" + Message);
        print("Hey this is NOT even better than charlies text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
