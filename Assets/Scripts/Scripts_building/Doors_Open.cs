/*
 * Scripts d'ouverture des portes
 * Par Jean RAGUENEAU
 * Créer le 13/06/2019
 * 
 * v0.02 : changement de nom de fichier le 13/06/2019
 * v0.01 : création du fichier et initialisation du script le 13/06/2019
*/

//Bibliothéques unity nécessaire
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors_Open : MonoBehaviour
{
    //Permet de récupérer l'affichage et le nombre de clés qu'à le joueur
    public Stats stat;

    //Fonction permettant lorsque le joueur est collé à la porte de l'ouvrir (en la détruisant)
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Player" && stat.key > 0) //Permet de savoir si le gameobject est bien un joueur
        {
            //Détruit la porte
            Destroy(gameObject);

            //Retire une clé
            stat.key--;
        }
    }
}
