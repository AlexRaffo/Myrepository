using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SavePoint : MonoBehaviour
{
    [SerializeField] private int nivel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            PlayerPrefs.SetInt("nivel",nivel);
            SceneManager.LoadScene("Nivel" + nivel);
        }

    }
}
