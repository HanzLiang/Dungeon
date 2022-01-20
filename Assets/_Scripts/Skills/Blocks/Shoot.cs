using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform bulletPrefab;
    //����
    public float maxSpeed;
    //����
    public float maxShootSpeed;
    //���
    public float maxRange;
    //�˺�
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
            // ��Ļ����ת��������
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 1;
            // ��ó��������
            Vector3 diection = mousePos - this.transform.position;
            // �������ת�ĽǶ�
            float angle = Vector3.SignedAngle(this.transform.up, diection, Vector3.forward);

            Transform newtrans = transform;
            newtrans.Rotate(0, 0, angle);
            Instantiate(bulletPrefab, transform.position, newtrans.rotation);
        }

    }
}
