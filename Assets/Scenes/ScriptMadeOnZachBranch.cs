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
        print("Some excelent text. this text is so great!" + Message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
