using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    private Slider HPbar;
    private Camera mCamera;
    private RectTransform mRect;
    public Cube Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        HPbar = GetComponent<Slider>();
        mRect = GetComponent<RectTransform>();
        mCamera = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Target != null)
        {
            mRect.position = RectTransformUtility.WorldToScreenPoint(mCamera,Target.UIPoint.position);
            HPbar.value = Target.CurrentHP / Target.MaxHP;
        }

    }
}
