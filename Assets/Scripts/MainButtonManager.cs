using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//[RequireComponent(typeof(Handle))]

public class MainButtonManager : MonoBehaviour
{
    [SerializeField] Button SubButton;
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




    public void OnClick()
    {
         
        MainBtClicked = true;

        Debug.Log("드래그 시작"+MainBtClicked);

    }


}
