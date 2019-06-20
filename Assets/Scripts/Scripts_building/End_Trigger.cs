/*
 * Scripts pour afficher la fin du jeu
 * Par Jean RAGUENEAU
 * Créer le 17/06/2019
 * Inspiré par le tuto Winning level : https://www.youtube.com/watch?v=Iv7A8TzreY4&list=PLPV2KyIb3jR53Jce9hP7G5xC4O9AgnOuL&index=10
 * 
 * v0.01 : création du fichier et initialisation du script le 17/06/2019
*/

//Bibliothéques unity nécessaire
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class End_Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Permet de vérifier si l'entité entrant dans le trigger est bien le joueur
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("EndMessage");
        }
    }
}
