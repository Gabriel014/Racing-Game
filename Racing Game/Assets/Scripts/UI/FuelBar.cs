using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour {
	[SerializeField]//deixa um objeto private disponivel para edição no unity 
	private float fill; //controla o nivel de preenchimento da barra

	[SerializeField]
	private Image content; //imagem da barra

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		fill = CarCollider.fuel;
		HandleBar();
	}

	private void HandleBar(){

		content.fillAmount = fill;
	}
}
