using UnityEngine;

public class Movement2D : MonoBehaviour
{
	[SerializeField]
	private	float	moveSpeed = 0.0f;
	[SerializeField]
	private	Vector3	moveDirection = Vector3.zero;

	private void Update()
	{
		transform.position += moveDirection * moveSpeed * Time.deltaTime;
	}

	public void MoveTo(Vector3 direction)
	{
		moveDirection = direction;
	}
	public GameObject ParticleFXExplosion;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag.Equals("Enemy")){
			Destroy(other.gameObject); 
			Destroy(this.gameObject);
			Instantiate(ParticleFXExplosion, this.transform.position, Quaternion.identity);
		}
	}
	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}

}
