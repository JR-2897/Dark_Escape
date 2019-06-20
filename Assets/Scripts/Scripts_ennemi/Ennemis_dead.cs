/*
 * Scripts pour tuer les ennemis
 * Par Jean RAGUENEAU
 * Créer le 13/06/2019
 * 
 * v0.02 : changement de nom de fichier le 14/06/2019
 * v0.01 : création du fichier et initialisation du script le 13/06/2019
*/

//Bibliothéques unity nécessaire
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis_dead : MonoBehaviour
{
    //Fonction permettant à un ennemi de tuer le joueur
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Projectiles") //Permet de savoir si le gameobject est bien une balle
        {
            Destroy(gameObject); //Détruit l'ennemi
        }
    }
}
