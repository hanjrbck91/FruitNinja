using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private List<AudioClip> fruitSounds;
    private AudioSource audioSource; // Reference to the AudioSource component

    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayFruitCutSound()
    {
        // Check if there's at least one sound in the list
        if (fruitSounds.Count > 0)
        {
            // Play a random sound from the list using the AudioSource component
            audioSource.PlayOneShot(fruitSounds[Random.Range(0, fruitSounds.Count)]);
        }
    }
}
