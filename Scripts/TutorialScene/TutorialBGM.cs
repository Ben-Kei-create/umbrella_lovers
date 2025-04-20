using UnityEngine;

public class TutorialBGM : MonoBehaviour
{
    public AudioClip bgmClip; // Inspectorで設定できるようにする
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = bgmClip;
        audioSource.loop = true;
        audioSource.playOnAwake = false;
        audioSource.volume = 0.2f; // お好みで調整
        audioSource.Play();
    }
}