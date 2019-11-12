using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ActionButtonManager : MonoBehaviour
{
    [SerializeField] GameObject MainButtonPrefab;
    [SerializeField] GameObject SubButtonPrefab;

    Vector2 strPos;
    Vector2 endPos;

    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            image.gameObject.SetActive(true);
            strPos = Input.mousePosition;
            image.transform.position = strPos;
          
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 myPos = Input.mousePosition;
            image.transform.localScale = new Vector2(Vector2.Distance(myPos, strPos), 1);
            image.transform.localRotation = Quaternion.Euler(0, 0,
                AngleInDeg(strPos, myPos));
           
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
