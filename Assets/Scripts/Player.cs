using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody rigid;
    private Vector3 lastDir;

    public float force;
    public float continueforce;
    public float speed = 30;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0,0,force));//��С����ٶ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, continueforce * Time.deltaTime));//��С��ʩ�ӳ�����
    }

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = new Vector3(1, 0, 1) * speed;
    }

    private void LateUpdate()
    {
        lastDir = rigid.velocity;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "Ball")//С����ǽ���򷴵�
        {
            Vector3 reflexAngle = Vector3.Reflect(lastDir, other.contacts[0].normal);
            rigid.velocity = reflexAngle.normalized * lastDir.magnitude;
        }
        else if (other.gameObject.tag == "Target")//С������ս�Ե�ص����
        {
            this.transform.position = new Vector3(48, 2, 45);
        }
    }
}
