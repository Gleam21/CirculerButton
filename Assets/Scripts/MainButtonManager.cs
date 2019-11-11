using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Handle))]

public class MainButtonManager : MonoBehaviour
{
    [SerializeField] Button SubButton;

    [SerializeField] enum Handle {   HandleType1,HandleType2 };
     


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("메인 버튼 눌려짐");
    }



}
