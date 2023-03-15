using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    [SerializeField]
    float pause = .5f;

    [SerializeField]
    ParticleSystem DeathEffects;

    bool hasDied = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Terrain" && hasDied == false)
        {
            hasDied = true;
            FindObjectOfType<PlayerController>().DisableControl();
            DeathEffects.Play();
            GetComponent<AudioSource>().Play();
            Invoke("Reload", pause);
        }
    }

    void Reload()
    {
        SceneManager.LoadScene(1);
    }
}
