using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour 
{
	public Rigidbody projectile;
	public float speed = 30;
	public GameObject gunShotSound;
	public GameObject particle;
	//public Transform endOFgun;
//	public ParticleSystem parti;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Rigidbody instantiatedProjectile = Instantiate (projectile,
			                                               transform.position,
			                                               transform.rotation)
				as Rigidbody;
			
			instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
			//audio.play();other.GetComponent.<AudioSource>().Play();
			//GameObject audi;
			//AudioClip audi;
			//audi.GetComponent.AudioSource().Play();
			//AudioSource.PlayClipAtPoint(audi,transform.position);
			GameObject GunShot = Instantiate (gunShotSound, this.transform.position, this.transform.rotation) as GameObject;
			//ParticleSystem.play();
			//GunShot.GetComponent<ParticleSytem>();
			//partii.AddComponent(ParticleSystem);
			GameObject Particle = Instantiate (particle, transform.position, Quaternion.identity)as GameObject;
		}
	}
		void OnTriggerEnter(Collider other) {
			if(other.gameObject.tag == "Enemy")
			{
				DestroyObject(other.gameObject);
			}
		}

}
