using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Coin : MonoBehaviour
{
    public int Value { get; set; } = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Pickup();
        }
    }

    public void Pickup()
    {
        GameManager.Instance.PickupCoin(this);
        Destroy(gameObject);
    }
}
