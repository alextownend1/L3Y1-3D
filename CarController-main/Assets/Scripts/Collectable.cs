using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().currentCollectables++;
            Destroy(gameObject);
        }
    }
}
