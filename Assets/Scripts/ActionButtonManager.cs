using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
 

public class ActionButtonManager : MonoBehaviour
{

    [Header("SubButtons Object Pool")]
    [SerializeField] GameObject SubButtonPrefab;
    public int maxPool;

    public List<GameObject> SubObjList = new List<GameObject>();


    subStructs? subs;


    

    public Color MainButtonColor;
    public Color SubButtonColor;

    [SerializeField] GameObject MainButton;
     


    Vector2 strPos;
    Vector2 endPos;

    //Vector3 vector;
    float r = 500.0f;
    //float angle;
    //Quaternion quaternion;
    float x, y;
    public Image image;

    [HideInInspector] public bool MainBtClicked;
   

    private void Awake()
    { 
         



        CreatePooling();
    }


    void Update()
    { 

        MouseTrail();


    } 

    public void CreatePooling()
    {

        //float angle = 45*Mathf.Deg2Rad;
        //float   Gap = 0 ;

        //Gap = 90 / maxPool / 2 ;


        for (int i = 0; i < maxPool; i++)
        {
            float angle = (Mathf.PI * 2 / maxPool) * (i + 1);



            x = Mathf.Cos(angle) * r + MainButton.transform.position.x;
            y = Mathf.Sin(angle) * r + MainButton.transform.position.y;

            
            Debug.Log("Angle: " + (angle * Mathf.Rad2Deg));
            var obj = Instantiate<GameObject>(SubButtonPrefab, transform);

            
            obj.transform.position = new Vector3(x, y, 0);
            
            obj.name = "SubButton" + i.ToString("0");



            switch (i)
            {
                case 1: obj.GetComponent<Image>().color = Color.blue;
                    break;
                case 2:
                    obj.GetComponent<Image>().color = Color.red;
                    break;
                case 3:
                    obj.GetComponent<Image>().color = Color.yellow;
                    break;
                case 4:
                    obj.GetComponent<Image>().color = Color.green;
                    break;
                case 5:
                    obj.GetComponent<Image>().color = Color.cyan;
                    break;

            }

            //if (i % 2 == 0)
            //{
            //    anglePlus =anglePlus* Gap  ;
            //    angle += anglePlus;
            //}
            //else
            //{
            //    angleMinus = angleMinus*Gap ;
            //    angle -= angleMinus;
            //}

            obj.SetActive(false);
            SubObjList.Add(obj);
             
        }


    }





    public void MouseTrail()
    {
        //마우스 궤적 이미지 구현
        if (Input.GetMouseButtonDown(0))
        {
            image.gameObject.SetActive(true);
            strPos = Input.mousePosition;
            image.transform.position = strPos;

        }

        if (Input.GetMouseButton(0))
        {
            //check = false;
            Vector2 myPos = Input.mousePosition;
            image.transform.localScale = new Vector2(Vector2.Distance(myPos, strPos), 1);
            image.transform.localRotation = Quaternion.Euler(0, 0, AngleInDeg(strPos, myPos));

            //StartCoroutine(DragLine());

            //strPos = Input.mousePosition;
            //image.transform.position = strPos;
        }

        if (Input.GetMouseButtonUp(0))
        {
            image.gameObject.SetActive(false);

        }

    }
    public static float AngleInRad(Vector3 vec1, Vector3 vec2)
    {
        return Mathf.Atan2(vec2.y - vec1.y, vec2.x - vec1.x);
    }

    public static float AngleInDeg(Vector3 vec1, Vector3 vec2)
    {
        return AngleInRad(vec1, vec2) * 180 / Mathf.PI;
    } 



}
