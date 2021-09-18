using UnityEngine;
using System.Collections;

public class PlayerD3 : MonoBehaviour {

	public GameObject Player;
	public GameObject Ragdoll;
	[SerializeField] private GameObject Spawn;

	void OnTriggerEnter(Collider other){
		if (other.tag == "PR") {
			Destroy (Player);
			
			Instantiate( Ragdoll,  Spawn.transform.position, Spawn.transform.rotation );
            
		}
	}


}
