using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            finishEffect.Play();
            Invoke("ReloadScene", 0.5f);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene("Level1");
    }
}
