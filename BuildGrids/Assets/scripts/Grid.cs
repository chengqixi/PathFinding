using UnityEngine;
using System.Collections;

public class Grid: MonoBehaviour {
	public LayerMask unwalkableMask;
	public Vector2 gridWorldSize;
	public float nodeRadius;
	Node[,] grid;

	void OnDrawGizmos(){
		Gizoms.DrawWireCube (transform.position, new Vector3 (gridWorldSize.x, 1, gridWorldSize.y));

	}
}
