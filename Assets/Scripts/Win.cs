using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField]
    float pause = .5f;

    [SerializeField]
    ParticleSystem VictoryEffects;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            VictoryEffects.Play();
            GetComponent<AudioSource>().Play();
            Invoke("Reload", pause);
        }
    }

    void Reload()
    {
        SceneManager.LoadScene(1);
    }
}
