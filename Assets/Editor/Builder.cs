using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;

public class Builder
{
   

    public static void BuildWebGL() {
        //���� ����
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();

        buildPlayerOptions.scenes = GetBuildScenes();
        buildPlayerOptions.locationPathName = "builds/WebGL";
        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.None;  // BuildOptions.None�� ���

        //���� ����
        BuildPipeline.BuildPlayer(buildPlayerOptions);

    }

    private static string[] GetBuildScenes()
    {
        return EditorBuildSettings.scenes
            .Where(scene => scene.enabled)
            .Select(scene => scene.path)
            .ToArray();
    }

}
