using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plunger : MonoBehaviour
{
    public float force;
    

    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Player != null)
        {
            int num = Random.Range(-50, -500);
            Player.GetComponent<Rigidbody>().AddForce(new Vector3(num, num, force));//小球向随机方向弹射
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player = collision.transform.gameObject;
    }

    private void OnCollisionExit(Collision collision)
    {
        Player = null;
    }
}
