using UnityEngine;

public class music_bg : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    public AudioClip bg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        musicSource.clip = bg;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
