using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var handler = Addressables.InitializeAsync();
        handler.WaitForCompletion();
        //Addressables.LoadAssetAsync<GameObject>("Sphere").Completed += (go) => { Instantiate(go.Result); };
        Addressables.LoadAssetAsync<TextAsset>("Assets/Project/Basic/sdk/sdk1.lua").Completed += (result) =>
        {
            Debug.Log(result.Result.text);
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
