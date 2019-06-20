/*
 * Scripts de Pathfinding des ennemis
 * Par Jean RAGUENEAU
 * Créer le 11/06/2019
 * 
 * v0.02 : ajout de commentaires et du ciblage le 13/06/2019
 * v0.01 : création du fichier de script le 11/06/2019
*/

//Bibliothéques unity nécessaire
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ennemis_navigation : MonoBehaviour
{

    //Initialisation de la cible
    public GameObject Target;

    // Update is called once per frame
    void Update()
    {
        //Permet à la destination (ou target) d'être mouvante
        GetComponent<NavMeshAgent>().SetDestination(Target.transform.position);
    }
}