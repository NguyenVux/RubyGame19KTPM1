using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] HealthBarController healthBar;
	[SerializeField] float health = 100f;
    void Start()
    {
        OnHit(25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnHit(float damage)
    {
        healthBar.SetValue((health-damage)/100f);
    }
}
