/*
 * Scripts pour tuer les ennemis tant qu'il y a des munitions
 * Par Jean RAGUENEAU
 * Créer le 14/06/2019
 * 
 * v0.03 : ajout fonctionnalité plus de munitions le 17/06/2019
 * v0.02 : changement variable temps de vie d'une balle le 17/06/2019
 * v0.01 : création du fichier et initialisation du script le 14/06/2019
*/

//Bibliothéques unity nécessaire
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //Instensation
    public GameObject ProjectilePrefab; //Balle
    public GameObject Spawner; //Position de l'arme à feu
    public float Power = 600f; //Puissance de feu
    public Stats stat; //Récuperer l'affichage ui et permet d'avoir le nombre de munitions

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && stat.ammunition > 0) //Vérifie si le joueur à appuyer sur la touche de tire
        {
            //Permet de créer le gameobject
            GameObject g = Instantiate(ProjectilePrefab, Spawner.transform.position, Quaternion.identity);

            //Permet au projectile d'aller tout droit
            g.GetComponent<Rigidbody>().AddForce(transform.forward * Power);

            //Détruit la balle après 2 seconde
            Destroy(g, 2);

            //Ne tire plus si atteint 0
            stat.ammunition--;

        }
    }
}
