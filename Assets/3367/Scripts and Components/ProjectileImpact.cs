using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ProjectileImpact : MonoBehaviour
{
    [SerializeField]
    private bool enableDebugHitMessage;
    [SerializeField]
    private UnityEvent m_MyEvent;

    public void ExecuteEvent()
    {
        if(enableDebugHitMessage == true)
        {
            Debug.Log("ProjectileImpactScript: Hit");
        }

        m_MyEvent.Invoke();
    }
}
