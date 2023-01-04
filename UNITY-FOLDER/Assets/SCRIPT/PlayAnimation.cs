// Systeme utiliser dans ce script
// On en rajouter comme using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    // Référence l'animator du le gameObject auquel est attaché ce script
    // Ici notre Animator s'appelle "anim"
    // le terme public nous permet de rendre visible l'objet dans l'inspector
    public Animator anim;

    // Référence la touche que l'on va utiliser pour déclencher l'animation
    public KeyCode playAnim = KeyCode.Space;


    // Fonction qui va se lancer lorsque le jeu ce lance
    void Start()
    {
        // prend l'Animator qui s'appelle anim et utilise le component Animator qui est dessus
        // Cette ligne de code permet d'accéder au composant qui est sur l'objet anim et de permettre son utilisation
        // Si on avait oublié de le mettre dans l'inspector, cette ligne assure qu'il sera bien trouvé au lancement du jeu
        anim = GetComponent<Animator>();
    }

    // Fonction qui va se lancer à chaque frame
    void Update()
    {
        // Condition : si (on appui sur la touche espace) alors fait quelque chose
        if(Input.GetKeyDown(playAnim))
        {
            // ce quelque chose c'est : déclancher l'animation
            anim.SetTrigger("move");
        }
    }
}
