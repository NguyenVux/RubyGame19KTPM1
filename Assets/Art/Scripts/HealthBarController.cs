using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarController : MonoBehaviour
{
    [SerializeField] private RectTransform m_rect;
    private float defaultWidth;
	private void Awake()
	{
		defaultWidth = m_rect.rect.width;
	}
	void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SetValue(float value)
    {
        if(value < 0.0f && value <1.0f)
        {
            throw new IndexOutOfRangeException("value should between 0 - 1 but recieve " + value.ToString());
        }

        float scale = defaultWidth * value;
        m_rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, scale);
    }
}
