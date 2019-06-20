/* Script créer le 07/06/2019
 * Par Jean RAGUENEAU
 * Script controllant le mouvement du joueur
 * 
 * v0.04 : suppression du start le 14/06/2019
 * v0.03 : modification et ajouts de commentaires le 13/06/2019
 * v0.02 : révision du code avec ajout en-tête le 11/06/2019
 * v0.01 : création du code de base le 07/06/2019
 */

//Bibliothéques unity nécessaire
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    //Variable gérant la vitesse du joueur
    public float Speed = 30f;
    //Variable gérant la vitesse de rotation
    public float Speed_rotate = 2f;

    //Varaibles gérant les touches de déplacement
    public KeyCode Forward = KeyCode.Z; //Avancer
    public KeyCode Back = KeyCode.S; //Reculer
    public KeyCode Right = KeyCode.D; //Tourner vers la droite
    public KeyCode Left = KeyCode.Q; //Tourner vers la gauche

    // Update is called once per frame
    void Update()
    {
        Rigidbody r = GetComponent<Rigidbody>(); //Permet le déplacement du joueur

        //Permet de faire avancer le joueur
        if (Input.GetKey(Forward))
        {
            r.AddForce(transform.forward * Speed);
        }

        //Permet de faire reculer le joueur
        if (Input.GetKey(Back))
        {
            r.AddForce(-transform.forward * Speed);
        }

        //Permet de tourner vers la droite
        if (Input.GetKey(Right))
        {
            transform.Rotate(new Vector3(0, Speed_rotate, 0));
        }

        //Permet de tourner vers la gauche
        if (Input.GetKey(Left))
        {
            transform.Rotate(new Vector3(0, -Speed_rotate, 0));
        }

    }
}
