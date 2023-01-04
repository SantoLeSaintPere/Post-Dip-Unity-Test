using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{

    // le terme public nous permet de rendre visible l'objet dans l'inspector
    // Un float est une variable qui correspont à une nombre décimal (nombre à virgule)
    // Ici notre float correspond à la vitesse de déplacement de notre Objet
    // Ici notre valeur de base sera de 10f mais on peut la changer dans l'inspector vu quelle est public
    public float speed = 10;

    // Ici le float sera la vitesse de rotation de notre objet
    public float rotationSPeed = 50;


    // Référence les touches que l'on va utiliser pour déplacer notre personnage
    public KeyCode moveKeyForward = KeyCode.Z;
    public KeyCode moveKeyBackWard = KeyCode.S;

    // Fonction qui va se lancer lorsque le jeu ce lance
    void Start()
    {
        
    }

    // Fonction qui va se lancer à chaque frame
    void Update()
    {

        // Condition : si (on appui sur la touche espace) alors faire une action
        if (Input.GetKey(moveKeyForward))
        {
            // Envoie un message dans la console
            //Sert pour le test
            Debug.Log("AVANCE");

            // Translate nous permet de déplacer un objet
            // L'action ici sera de déplacer notre component transform (la position de notre objet) sur une direction donné par un Vecteur à 3 dimension en le multipliant par notre vitesse et le temps
            // La direction de vector se traduit par +1 sur l'axe Z de l'objet
            // Vector3(0,0,1) veut dire Vecteur de type trois dimension (0 sur l'axe X, 0 sur l'axe Y, +1 sur l'Axe Z
            transform.Translate(new Vector3(0,0,1) * speed * Time.deltaTime);
        }

        if (Input.GetKey(moveKeyBackWard))
        {
            Debug.Log("RECULE");

            //Ici le vecteur 3 correspond à -1 sur l'axe Zde l'objet
            transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Q))
        {
            // Ici on utilise Rotate pour opérer une rotation sur notre Objet
            // Même principe que pour déplacer un objet avec Translate
            // Ici le vector3.up correspond à un vector3(0,1,0) c'est à dire un vecteur qui fera bouger notre objet uniquement sur l'axe Y
            transform.Rotate(-Vector3.up * rotationSPeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotationSPeed * Time.deltaTime);
        }
    }
}
