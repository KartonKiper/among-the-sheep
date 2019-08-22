using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SchowajElementy : MonoBehaviour
{
    public GameObject menuContainer;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sheep")
        {
            Debug.Log("obiekt na pokladzie elo mordo pozdro");
            menuContainer.SetActive(false);
        }
    }
}