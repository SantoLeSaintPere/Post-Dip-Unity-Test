// Systeme utiliser dans ce script
// On en rajouter comme using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    // Référence l'animator du le gameObject auquel est attaché ce script
    // Ici notre Animator s'appelle "anim"
    // le terme public nous permet de rendre visible l'objet dans l'inspector
    public AudioSource audioSRC;

    // Fonction qui va se lancer lorsque le jeu ce lance
    void Start()
    {
        // prend l'Animator qui s'appelle anim et utilise le component AudioSource qui est dessus
        // Cette ligne de code permet d'accéder au composant qui est sur l'objet audioSRC et de permettre son utilisation
        // Si on avait oublié de le mettre dans l'inspector, cette ligne assure qu'il sera bien trouvé au lancement du jeu
        audioSRC = GetComponent<AudioSource>();
    }

    // Fonction qui va se lancer à chaque frame
    void Update()
    {
        
    }


    // Fonction qui va se lancer lorsque notre objet auquel le script est attaché rentre en collision avec un autre Objet
    private void OnCollisionEnter(Collision collision)
    {
        // ici on dit à l'AudioSource audioSRC de lancer la fonction qui est déjà scripté dans le composant AudioSource
        // La fonction Play() lancer le son
        audioSRC.Play();
    }
}
