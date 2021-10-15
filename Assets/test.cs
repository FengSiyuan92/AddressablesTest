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
        Addressables.LoadAssetAsync<GameObject>("Cube").Completed += (go) => { Instantiate(go.Result); };
        Addressables.LoadContentCatalogAsync(Addressables.RuntimePath + "/Game1/catalog.json").WaitForCompletion();
        Addressables.LoadAssetAsync<GameObject>("Cube").Completed += (go) => { 
            var ins =Instantiate(go.Result);
            ins.transform.position = new Vector3(2, 2, 2);
        };

        Addressables.CheckForCatalogUpdates();
        //Addressables.GetDownloadSizeAsync();
        //Addressables.DownloadDependenciesAsync();
        //Addressables.LoadAssetAsync<TextAsset>("Assets/Project/Basic/sdk/sdk1.lua").Completed += (result) =>
        //{
        //    Debug.Log(result.Result.text);
        //};
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
