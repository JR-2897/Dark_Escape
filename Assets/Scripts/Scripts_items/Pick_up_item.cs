/*
 * Scripts ramasser les objets
 * Par Jean RAGUENEAU
 * Créer le 17/06/2019
 * 
 * v0.01 : création du fichier et initialisation du script le 17/06/2019
*/

//Bibliothéques unity nécessaire
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_up_item : MonoBehaviour
{
    //Récupere l'affichage ui et permet d'avoir le nombre de munitions et de clés
    public Stats stat;

    //Fonction permettant de récuper l'objet
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Player") //Permet de savoir si le gameobject est bien le joueur
        {
            Destroy(gameObject); //Détruit le coffre
            stat.ammunition += 5;
            stat.key++;
        }
    }
}
