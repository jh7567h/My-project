using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatText : MonoBehaviour
{
    public float Speed = 30f;
    public float Lifetime = 1.5f;

    private Text mText;
    private RectTransform mRect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void Awake()
    {
        mText = GetComponent<Text>();
        mRect = GetComponent<RectTransform>();
    }

    public void SetContent(string content, float time = 1.5f)
    {
        mText.text = content;
        Lifetime = time;
    }

    public void SetPosition(Vector3 pos)
    {
        mRect.position = RectTransformUtility.WorldToScreenPoint(Camera.main, pos);
    }
}
