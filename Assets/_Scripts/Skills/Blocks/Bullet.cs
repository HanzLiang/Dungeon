using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 sp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 1f * Time.deltaTime, 0, Space.Self);
        sp = Camera.main.WorldToScreenPoint(transform.position);
        if (sp.y > Screen.height || sp.y <0 || sp.x < 0 || sp.x > Screen.width)
        {
            Destroy(this.gameObject);
        }
    }
}
