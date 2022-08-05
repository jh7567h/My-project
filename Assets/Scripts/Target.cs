using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject GameController;
    public GameObject CubeBlue, CubeYellow, CubeGreen, CubeRed;
    //public event Action<int, int> UpdateHealthBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 5, 0));
    }


    private void OnTriggerEnter(Collider other)
    {
        //GameController.GetComponent<GameController>().LoseLife();
        if (other.gameObject.CompareTag("BallBlue"))
        {
            takeDamage(CubeYellow, CubeRed, CubeGreen);
        }else if (other.gameObject.CompareTag("BallYellow"))
        {
            takeDamage(CubeBlue, CubeRed, CubeGreen);
        }
        else if (other.gameObject.CompareTag("BallRed"))
        {
            takeDamage(CubeBlue, CubeYellow, CubeGreen);
        }
        else if (other.gameObject.CompareTag("BallGreen"))
        {
            takeDamage(CubeBlue, CubeRed, CubeYellow);
        }
    }


    public void takeDamage(GameObject one, GameObject two, GameObject three)
    {
        one.GetComponent<HealthBarUI>().Damage();
        two.GetComponent<HealthBarUI>().Damage();
        three.GetComponent<HealthBarUI>().Damage();
    }


}
