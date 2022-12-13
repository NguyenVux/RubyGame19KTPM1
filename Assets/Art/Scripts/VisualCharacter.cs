using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class VisualCharacter : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] private Animator m_animator = null;
	[SerializeField] private Rigidbody2D m_rigidbody = null;
	void Start()
	{
		Assert.IsNotNull(m_animator);
		Assert.IsNotNull(m_rigidbody);
	}

	// Update is called once per frame
	void Update()
	{
		m_animator.SetFloat("Look X", m_rigidbody.velocity.x);
		m_animator.SetFloat("Look Y", m_rigidbody.velocity.y);
		m_animator.SetFloat("Speed", m_rigidbody.velocity.magnitude);
	}
}
