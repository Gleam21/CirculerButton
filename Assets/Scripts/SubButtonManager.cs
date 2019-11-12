using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SubButtonManager : MonoBehaviour
{ 

    private void Update()
    { 


    }
     

    public void Selected()
    { 
        if (Input.GetMouseButton(0))
        {
            Debug.Log("선택됨");

        }
         
    }
}
