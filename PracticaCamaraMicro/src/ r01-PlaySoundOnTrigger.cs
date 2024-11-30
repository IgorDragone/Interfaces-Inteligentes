using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    public AudioSource audioSource; // Arrastra aquí el AudioSource desde el Inspector.

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Egg"))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}
