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

        Debug.Log( GetComponentInParent<ActionButtonManager>().MainButtonColor);

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

        Debug.Log("메인 으로부터 드래그 시작");
         
    }

    public void EndDrag()
    {

        subBool = false;
        setSubsActive();
        gameObject.GetComponent<Image>().color = Color.white;
        Debug.Log("메인 으로부터 드래그 종료");

    }

    void setSubsActive()
    {
        var obj = GetComponentInParent<ActionButtonManager>().SubButtons;
        int i = 0;
        
        foreach (var gameObject in obj)
        {
            obj[i].SetActive(subBool);
            i++; 
        }

    }

}
