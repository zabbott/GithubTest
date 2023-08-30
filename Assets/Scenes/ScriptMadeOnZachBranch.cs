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
        print("Yippee :3" + Message);
        print("My message is the coolest :)" + Message);

        print("I exist only to cause merge conflicts and chaos" + Message);
        print("Some excelent text. this text is so great!" + Message);
        print("Do{} While(); more like Do{} Wild();" + Message);
        print("Hey this is NOT even better than charlies text");
        print("Some excelent AGAIN text. this text is so great!" + Message);
        print("Hey this is even better than charlies text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
