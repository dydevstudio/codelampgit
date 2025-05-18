using UnityEngine;
using UnityEngine.UI;

public class ExecutionOrder : MonoBehaviour {

    [Header("Property Mobil")]
    private string Nama_Mobil = "Lamborgini";
    [SerializeField] private int Kecepatan_Mobil = 120;
    [SerializeField] private bool Nitro = true;

    [SerializeField] private string Debugging;

    public GameObject gameObject;

    //public Text text;

    /*void Awake() {

    }*/

    // Start is called before the first frame update
    void Start() {
        print("Nama Mobil ini adalah " + Nama_Mobil);
        print("Kecepatan Mobil ini = " + Kecepatan_Mobil + " Km");
        print("Mobil ini punya Nitro " + Nitro);

        Test();
        GameObject.FindGameObjectsWithTag("Enemy");
        /*gameObject.SetActive(true);*/



    }



    void Test() {
        Debug.Log("function test ini jalan");
        Debugging = "Test";
        print(Debugging);
    }

    // Update is called once per frame
    void Update() {
        
    }

    /*void FixedUpdate() {

    }

    void LateUpdate() {

    } */

}
