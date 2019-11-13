using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public interface ISubButton
{
    void DidSelectCell(SubButtonManager subButton); 
}



public class SubButtonManager : MonoBehaviour
{


    public ISubButton subButtonDelegate;
    [SerializeField] Button subButton;
 

    private void Start()
    { 


    }

    public void OnClick()
    {
        subButtonDelegate.DidSelectCell(this);
    }

    public void Selected()
    { 
        if (Input.GetMouseButton(0))
        {
            Debug.Log("선택됨");

        }
         
    }
}
