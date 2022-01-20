using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform bulletPrefab;
    //弹速
    public float maxSpeed;
    //射速
    public float maxShootSpeed;
    //射程
    public float maxRange;
    //伤害
    public float maxDamage;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootSkill();
    }

    public void ShootSkill()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 屏幕坐标转世界坐标
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 1;
            // 获得朝向的向量
            Vector3 diection = mousePos - this.transform.position;
            // 计算出旋转的角度
            float angle = Vector3.SignedAngle(this.transform.up, diection, Vector3.forward);

            Transform newtrans = transform;
            newtrans.Rotate(0, 0, angle);
            Instantiate(bulletPrefab, transform.position, newtrans.rotation);
        }

    }
}
