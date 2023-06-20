using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    int step = 0;
   
    void Update(){
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        
        if(y>=2f)
        {
            step = 1;
        }
        /*if ()
        {

        }
        if ()
        {

        }*/
        switch (step)
        {
            case 1: this.transform.position += new Vector3(0, 2f*Time.deltaTime, 0); break;
            case 2: break;
            case 3: break;
        }
    }
}
