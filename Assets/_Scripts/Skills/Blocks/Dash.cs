using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 mousePosition, targetPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DashSkill();
    }

    public void DashSkill()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
            Debug.Log(123123);
            mousePosition = Input.mousePosition;
            targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 1f));
            Vector3 diection = targetPosition - transform.position;
            transform.Translate(diection.normalized, Space.World);
            // transform.position += diection.normalized;
        }
        
    }
}
