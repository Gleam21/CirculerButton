using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//[RequireComponent(typeof(Handle))]

public class MainButtonManager : MonoBehaviour
{


    bool subBool=false;
    

    //[SerializeField] enum Handle {   HandleType1,HandleType2 };

    void Awake()
    {
        GetComponentInParent<ActionButtonManager>().MainBtClicked = false;
         

    }

    // Update is called once per frame
    void Update()
    {
         
    } 

    public void BeginDrag()
    {
        GetComponentInParent<ActionButtonManager>().MainBtClicked = true;

        gameObject.GetComponent<Image>().color = GetComponentInParent<ActionButtonManager>().MainButtonColor;
        subBool = true;
        setSubsActive();
 
         
    }

    public void EndDrag()
    {

        subBool = false;
        setSubsActive();
        gameObject.GetComponent<Image>().color = Color.white;
      

    }

    void setSubsActive()
    {
        var obj = GetComponentInParent<ActionButtonManager>().SubObjList;
        int i = 0;
        
        foreach (var gameObject in obj)
        {
            obj[i].SetActive(subBool);
            i++; 
        }

    }

}
