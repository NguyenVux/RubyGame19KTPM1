using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioSource m_FootStepSource;
    [SerializeField] private Rigidbody2D m_rigidBody = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(m_rigidBody.velocity.magnitude > 0.1f)
        {
            if (!m_FootStepSource.isPlaying)
            {
                m_FootStepSource.Play();

			}
        }
        else
        {
            m_FootStepSource.Stop();

		}
    }
}
