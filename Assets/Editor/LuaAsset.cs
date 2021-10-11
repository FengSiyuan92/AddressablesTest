using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor.Experimental.AssetImporters;

[ScriptedImporter(1, ".lua")]
public class LuaAsset : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        var content = File.ReadAllText(ctx.assetPath);
        var main = new TextAsset(content);
        ctx.AddObjectToAsset("main obj", main);
        ctx.SetMainObject(main);
    }
}
