using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
public class Movement : MonoBehaviour
{
	[SerializeField] private Rigidbody2D m_rigidbody = null;
	[SerializeField] private float m_speed = 5.0f;
	// Start is called before the first frame update
	void Start()
    {
		Assert.IsNotNull(m_rigidbody);
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) 
        {
            m_rigidbody.velocity = Vector2.up* m_speed;
        } 
        else if (Input.GetKey(KeyCode.S))
		{
			m_rigidbody.velocity = Vector2.down * m_speed;
		}
		else if (Input.GetKey(KeyCode.A))
		{
			m_rigidbody.velocity = Vector2.left * m_speed;
		}
		else if (Input.GetKey(KeyCode.D))
		{
			m_rigidbody.velocity = Vector2.right * m_speed;
		}
		else
		{
			m_rigidbody.velocity = Vector2.zero;
		}
	}
}
