using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBlocks : MonoBehaviour
{    

    [Header("------放置物品系统------")]
    public Transform targetObject;
    public Transform obj;
    public float maxDistance = 5f;
    private Vector3 mousePosition, targetPosition;
    public SpriteRenderer circlerender;
    public bool placeFlag = false;
    public bool isPlace = false;
    void Start()
    {
        GameObject[] circle = GameObject.FindGameObjectsWithTag("DistanceCircle");
        circlerender = circle[0].GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlaceBlockSkill();



    }

    public void PlaceGrids()
    {

    }

    public void PlaceBlockSkill()
    {
        bool isPress = Input.GetMouseButtonDown(1);
        if (!placeFlag && isPress)
        {
            circlerender.enabled = true;
            placeFlag = true;
            mousePosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 1f));
            obj = Instantiate(targetObject, targetPosition, targetObject.transform.rotation);

        }

        if (placeFlag)
        {
            mousePosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 1f));
            obj.position = targetPosition;
            // PlaceBlockSkill();
            if (Input.GetMouseButtonUp(1))
            {
                float distance = (transform.position - targetPosition).magnitude;
                Debug.Log(distance);
                if (distance > 1) Destroy(obj.gameObject);
                circlerender.enabled = false;
                placeFlag = false;

            }
        }

    }



}
