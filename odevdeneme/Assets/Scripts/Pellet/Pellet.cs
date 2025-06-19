using System;
using Unity.VisualScripting;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        PelletCollector.Instance.PelletCollected();
        Destroy(gameObject);
    }
}
