using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButtonManager : MonoBehaviour
{
    [SerializeField] GameObject MainButtonPrefab;
    [SerializeField] GameObject SubButtonPrefab;





    public void EndDrag()
    {

        Debug.Log("드래그 끝");
    }


    public void OnMouseDrag()
    {
      //  Debug.Log(Input.mousePosition);
         
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




}
