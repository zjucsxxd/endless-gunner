using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ShittyRenderManager : MonoBehaviour
{
	[SerializeField] RenderTexture shittyTexture;
	[SerializeField] int howShitty = 3;

	void Awake()
	{
		shittyTexture.width = Screen.width / howShitty;
		shittyTexture.height = Screen.height / howShitty;
	}
}
