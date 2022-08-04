using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject Player;
    public float force;
    public float continueforce;
    public Text Life;
    private int PlayerLife = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoseLife()
    {
        PlayerLife -= 10;
        Life.text = "Score:" + PlayerLife.ToString();
    }
}
