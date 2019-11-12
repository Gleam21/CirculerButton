using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//[RequireComponent(typeof(Handle))]

public class MainButtonManager : MonoBehaviour
{ 
    [HideInInspector] public bool MainBtClicked;


    //[SerializeField] enum Handle {   HandleType1,HandleType2 };
     


    void Start()
    {
        MainBtClicked = false;
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }





    public void BeginDrag()
    {


        Debug.Log("메인 으로부터 드래그 시작");

    }

    public void EndDrag()
    {


        Debug.Log("메인 으로부터 드래그 종료");

    }

}
